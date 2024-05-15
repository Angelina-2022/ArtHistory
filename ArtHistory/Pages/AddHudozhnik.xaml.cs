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
    /// Логика взаимодействия для AddHudozhnik.xaml
    /// </summary>
    public partial class AddHudozhnik : Page
    {
        public AddHudozhnik()
        {
            InitializeComponent();
        }

        private string fileName;

        //выбор изображения
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            AddImage();
        }

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
            tbFIO.Clear();
            tbEpoha.Clear();
            tbDate.Clear();
            tbBiografia.Document.Blocks.Clear();
        }
        //сохранить
        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {
            // Вызвать функцию сохранения данных
            SaveData();
        }

        private void SaveData()
        {
            try
            { 
            // Получение пути к папке Images
            string imagesPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                TbHudozhniki table = new TbHudozhniki();

                // Получить текст из RichTextBox
                string biografiaText = new TextRange(tbBiografia.Document.ContentStart, tbBiografia.Document.ContentEnd).Text;

                // Сохранение значения в базу данных
                table.Fio = tbFIO.Text.ToString();
                table.Date = tbDate.Text.ToString();
                table.Biografia = biografiaText;
                table.Epoha = tbEpoha.Text.ToString();
                table.ImagePath = System.IO.Path.Combine(imagesPath, fileName);


                db.TbHudozhniki.Add(table);
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
