using ArtHistory.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для Kartini.xaml
    /// </summary>
    public partial class Kartini : Page
    {
        public Kartini()
        {
            InitializeComponent();

            try
            {
                LoadDB();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public ObservableCollection<Item> Items { get; set; }
        public class Item
        {
            public int Id { get; set; }
            public string Nazvanie { get; set; }
            public string Avtor { get; set; }
            public string Data { get; set; }
            public string Opisanie { get; set; }
            public string Epoha { get; set; }
            public string Pictures { get; set; }
            public bool Favorite { get; set; }

        }
        private void LoadDB()
        {

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities()) // Измените имя класса контекста в соответствии с вашим проектом
            {
                // Создание коллекции элементов для передачи на страницу
                Items = new ObservableCollection<Item>();

                // Запрос данных из базы данных
                var queryResults = db.TbKartini.ToList();

                // Добавление полученных данных в коллекцию
                foreach (var item in queryResults)
                {
                    Items.Add(new Item
                    {
                        Id = item.Id,
                        Nazvanie = item.Nazvanie,
                        Avtor = item.Avtor,
                        Data = item.Date,
                        Opisanie = item.Opisanie,
                        Epoha = item.Epoha,
                        Pictures = item.ImagePath,
                        Favorite = item.Favorite
                    });
                }

                // Привязка коллекции данных к элементу управления ItemsControl на странице
                ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
                itemsControl.ItemsSource = Items;

                foreach (var item in Items)
                {
                    // Получение полного пути к изображению
                    string imagePath = item.Pictures;

                    // Создание нового объекта Image
                    Image image = new Image();

                    // Проверка наличия изображения в БД
                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        // Если изображение есть, загрузить из файла
                        image.Source = new BitmapImage(new Uri(imagePath));
                    }
                    else
                    {
                        // Если изображения нет, установить изображение из ресурсов
                        image.Source = new BitmapImage(new Uri("\\Resources\\3.png", UriKind.Relative));
                    }
                }
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
                    context.TbKartini.Remove(context.TbKartini.Find(selectedItem.Id)); // Измените имя таблицы и свойство поиска в соответствии с вашим проектом
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

            Kartini page1 = new Kartini();

            // Отобразить страницу EditPage во фрейме MainContent
            mainContent.Content = page1;

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Получение введенного текста из текстового поля
            string searchText = searchTextBox.Text.ToLower(); // Преобразуем текст в нижний регистр

            // Фильтрация коллекции элементов по совпадениям с введенным текстом в столбцах Name и Date
            var filteredItems = Items.Where(i => i.Nazvanie.ToLower().Contains(searchText) || i.Avtor.ToLower().Contains(searchText) || i.Epoha.ToLower().Contains(searchText));

            // Обновление источника данных в элементе управления ItemsControl
            ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
            itemsControl.ItemsSource = filteredItems;
        }



        private void FavoriteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Получение элемента, на который нажали
                var item = (sender as FrameworkElement).DataContext as Item;

                // Подключение к базе данных с использованием Entity Framework
                using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
                {
                    // Получение объекта из БД по идентификатору
                    TbKartini epoha = db.TbKartini.SingleOrDefault(x => x.Id == item.Id);

                    // Изменение значения столбца Favorite на противоположное
                    epoha.Favorite = !epoha.Favorite;

                    // Сохранение изменений в БД
                    db.SaveChanges();

                    // Отображение сообщения в зависимости от значения Favorite
                    string message = epoha.Favorite ? "добавлено в избранное" : "удалено из избранного";
                    MessageBox.Show(message);

                    // Обновление коллекции Items
                    LoadDB();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void ShowFavorites_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Подключение к базе данных с использованием Entity Framework
                using (ArtHistoryDBEntities db = new ArtHistoryDBEntities()) // Измените имя класса контекста в соответствии с вашим проектом
                {
                    // Запрос данных из базы данных, отфильтрованных по Favorite = True
                    var queryResults = db.TbKartini.Where(x => x.Favorite == true).ToList();

                    // Очистка текущей коллекции Items
                    Items.Clear();

                    // Добавление отфильтрованных данных в коллекцию
                    foreach (var item in queryResults)
                    {
                        Items.Add(new Item
                        {
                            Id = item.Id,
                            Nazvanie = item.Nazvanie,
                            Data = item.Date,
                            Avtor = item.Avtor,
                            Epoha = item.Epoha,
                            Opisanie = item.Opisanie,
                            Pictures = item.ImagePath, // Измените имя поля в соответствии с вашим проектом
                            Favorite = item.Favorite
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            LoadItems();
        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {
            // Получить выбранный элемент
            Item selectedItem = (Item)((Button)sender).CommandParameter;
            // Создать экземпляр страницы EditPage и передать ей выбранный элемент
            EditKartina editPage = new EditKartina(selectedItem);
            try
            {
                // Получить ссылку на окно MainWindow
                MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

                // Получить ссылку на фрейм MainContent
                Frame mainContent = mainWindow.MainContent;



                // Отобразить страницу EditPage во фрейме MainContent
                mainContent.Content = editPage;
            }
            catch (Exception ex)
            {
                // Обработать исключение и отобразить сообщение об ошибке
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }


        private void CheckButton_Click(object sender, RoutedEventArgs e)
        {

            // Получить выбранный элемент
            Item selectedItem = (Item)((Button)sender).CommandParameter;

            // Создать экземпляр страницы ViewEpoha и передать ей выбранный элемент
            ViewKartina viewPage = new ViewKartina(selectedItem);

            try
            {
                // Получить ссылку на окно MainWindow
                MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

                // Получить ссылку на фрейм MainContent
                Frame mainContent = mainWindow.MainContent;

                // Отобразить страницу ViewEpoha во фрейме MainContent
                mainContent.Content = viewPage;
            }
            catch (Exception ex)
            {
                // Обработать исключение и отобразить сообщение об ошибке
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }


        }
    }
}
