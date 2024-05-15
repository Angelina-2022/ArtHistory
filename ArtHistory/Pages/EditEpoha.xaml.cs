using ArtHistory.Model;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Media.Imaging;
using static ArtHistory.Pages.Epohi;


namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditEpoha.xaml
    /// </summary>
    public partial class EditEpoha : Page
    {
        public int id;

        public EditEpoha(Item selectedItem)
        {
            InitializeComponent();
            // Получение данных
            try
            {
                id = selectedItem.Id;

                // Заполнение полей страницы данными из выбранного элемента
                tbName.Text = selectedItem.Name;
                tbDate.Text = selectedItem.Date;


                // Вывод в RichTextBox
                string text = selectedItem.Opisanie;
                tbOpisanie.AppendText(text);


                // Загрузка изображения из базы данных
                using (var context = new ArtHistoryDBEntities())
                {
                    // Получение полного пути к изображению
                    string imagePath = selectedItem.Pictures;

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        // Создание нового объекта Image и загрузка в него изображения из файла
                        BitmapImage image = new BitmapImage(new Uri(imagePath));

                        // Присвоение изображения элементу управления Image
                        imageElement.Source = image;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // Получение пути к папке Images
            string imagesPath = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "Images");

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                // Получить выбранную строку из таблицы
                TbEpohi table = db.TbEpohi.ToList().Find(t => t.Id == id); // здесь selectedId - идентификатор выбранной строки

                // Получить текст из RichTextBox
                string opisanieText = new TextRange(tbOpisanie.Document.ContentStart, tbOpisanie.Document.ContentEnd).Text;

                // Обновление выбранной строки в базе данных
                try
                {
                    table.Nazvanie = tbName.Text.ToString();
                    table.Date = tbDate.Text.ToString();
                    table.Opisanie = opisanieText;
                    if (!string.IsNullOrEmpty(fileName))
                    {
                        table.ImagePath = System.IO.Path.Combine(imagesPath, fileName);
                    }
                    else
                    {
                        table.ImagePath = table.ImagePath; // оставляем прежнее значение
                    }
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
            MessageBox.Show("сохранено!");
        }


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

                BitmapImage bitmap = new BitmapImage();
                bitmap.BeginInit();
                bitmap.UriSource = new Uri(destinationPath);
                bitmap.EndInit();
                imageElement.Source = bitmap;
            }
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            // Создаем окно с подтверждением
            var result = MessageBox.Show("Вы действительно хотите удалить этот элемент?", "Подтверждение удаления", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Проверяем результат
            if (result == MessageBoxResult.Yes)
            {
                // Удаляем элемент
                // Получить выбранный элемент
                Item selectedItem = (Item)((Button)sender).CommandParameter;

                // Удалить элемент из базы данных
                using (var context = new ArtHistoryDBEntities())
                {
                    context.TbEpohi.Remove(context.TbEpohi.Find(selectedItem.Id)); // Измените имя таблицы и свойство поиска в соответствии с вашим проектом
                    context.SaveChanges();
                }
                // Отобразить сообщение об успешном удалении
                MessageBox.Show("Элемент успешно удален.");
                try
                {
                    // Обновить список элементов
                    LoadItems(); // Вызовите метод для обновления списка элементов

                }
                catch (Exception ex)
                {
                    // Обработать исключение и отобразить сообщение об ошибке
                    MessageBox.Show($"Произошла ошибка: {ex.Message}");
                }

            }

        }
        private void LoadItems()
        {
            // Перезагрузка страницы


            // Получить ссылку на окно MainWindow
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            // Получить ссылку на фрейм MainContent
            Frame mainContent = mainWindow.MainContent;

            Epohi page1 = new Epohi();

            // Отобразить страницу EditPage во фрейме MainContent
            mainContent.Content = page1;

        }
    }
}
