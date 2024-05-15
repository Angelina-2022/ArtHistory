using ArtHistory.Model;
using System;
using System.IO;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddKartina.xaml
    /// </summary>
    public partial class AddKartina : Page
    {
        public AddKartina()
        {
            InitializeComponent();
        }


        //выбор изображения
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            AddImage();
        }

        private string fileName;

        private void AddImage()
        {
            Microsoft.Win32.OpenFileDialog dialog = new Microsoft.Win32.OpenFileDialog();
            dialog.Filter = "Image files (*.png, *.jpg, *.bmp)|*.png;*.jpg;*.bmp";
            if (dialog.ShowDialog() == true)
            {
                string filePath = dialog.FileName;
                fileName = System.IO.Path.GetFileName(filePath);

                string imagesPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location), "Images");

                if (!Directory.Exists(imagesPath))
                {
                    Directory.CreateDirectory(imagesPath);
                }

                string destinationPath = System.IO.Path.Combine(imagesPath, fileName);
                if (File.Exists(destinationPath))
                {
                    int i = 1;
                    while (File.Exists(destinationPath))
                    {
                        string copyName = $"{System.IO.Path.GetFileNameWithoutExtension(fileName)}_{i}{System.IO.Path.GetExtension(fileName)}";
                        destinationPath = System.IO.Path.Combine(imagesPath, copyName);
                        i++;
                    }
                }

                File.Copy(filePath, destinationPath, true);
                selectedImagePath.Content = destinationPath;

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(destinationPath);
                bitmap.EndInit();
                selectedImage.Source = bitmap;
            }
        }

        //отмена
        private void Button_ClickOtmena(object sender, RoutedEventArgs e)
        {
            tbName.Clear();
            tbAvtor.Clear();
            tbEpoha.Clear();
            tbDates.Clear();
            tbOpisanie.Document.Blocks.Clear();
        }
        //сохранить
        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {
            // Вызвать функцию сохранения данных
            SaveData();
        }

        private void SaveData()
        {
            try {  
            // Получение пути к папке Images
            string imagesPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                TbKartini table = new TbKartini();

                // Получить текст из RichTextBox
                string opisanieText = new TextRange(tbOpisanie.Document.ContentStart, tbOpisanie.Document.ContentEnd).Text;

                // Сохранение значения в базу данных
                table.Nazvanie = tbName.Text.ToString();
                table.Avtor = tbAvtor.Text.ToString();
                table.Date = tbDates.Text.ToString();
                table.Opisanie = opisanieText;
                table.Epoha = tbEpoha.Text.ToString();
                table.ImagePath = System.IO.Path.Combine(imagesPath, fileName);


                db.TbKartini.Add(table);
                db.SaveChanges();
            }
            MessageBox.Show("сохранено!");
            }
            catch
            {
                // Обработка исключения
                MessageBox.Show("Ошибка. Убедитесь что все поля заполнены", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }

        }


    }
}
