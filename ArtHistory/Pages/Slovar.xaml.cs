
using ArtHistory.Model;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для Slovar.xaml
    /// </summary>
    public partial class Slovar : Page
    {
        public ObservableCollection<Item> Items { get; set; }

        public class Item
        {
            public int Id { get; set; }
            public string Termin { get; set; }
            public string Opisanie { get; set; }
            public bool Favorite { get; set; }
        }
        
        public Slovar()
        {
            InitializeComponent();

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities()) // Измените имя класса контекста в соответствии с вашим проектом
            {
                // Создание коллекции элементов для передачи на страницу
                Items = new ObservableCollection<Item>();

                // Запрос данных из базы данных
                var queryResults = db.TbSlovar.ToList();

                // Добавление полученных данных в коллекцию
                foreach (var item in queryResults)
                {
                    Items.Add(new Item
                    {
                        Id = item.Id,
                        Termin = item.Termin,
                        Opisanie = item.Opisanie,
                        Favorite = item.Favorite
                    });
                }

                // Привязка коллекции данных к элементу управления ItemsControl на странице
                ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
                itemsControl.ItemsSource = Items;

            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Получение введенного текста из текстового поля
            string searchText = searchTextBox.Text.ToLower();

            // Фильтрация коллекции элементов по совпадениям с введенным текстом в столбцах Name и Date
            var filteredItems = Items.Where(i => i.Termin.ToLower().Contains(searchText) || i.Opisanie.ToLower().Contains(searchText));

            // Обновление источника данных в элементе управления ItemsControl
            ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
            itemsControl.ItemsSource = filteredItems;
        }

        // Событие для сортировки по возрастанию
        private void SortAscending_Click(object sender, RoutedEventArgs e)
        { // Сортировка коллекции по возрастанию значения свойства Name
            var sortedItems = Items.OrderBy(i => i.Termin);

            // Обновление источника данных в элементе управления ItemsControl
            ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
            itemsControl.ItemsSource = sortedItems;
        }

        // Событие для сортировки по убыванию
        private void SortDescending_Click(object sender, RoutedEventArgs e)
        {
            // Сортировка коллекции по убыванию значения свойства Name
            var sortedItems = Items.OrderByDescending(i => i.Termin);

            // Обновление источника данных в элементе управления ItemsControl
            ItemsControl itemsControl = (ItemsControl)this.FindName("ItemsControl");
            itemsControl.ItemsSource = sortedItems;
        }

        private void LoadDB()
        {
            // Перезагрузка страницы


            // Получить ссылку на окно MainWindow
            MainWindow mainWindow = (MainWindow)Window.GetWindow(this);

            // Получить ссылку на фрейм MainContent
            Frame mainContent = mainWindow.MainContent;

            Slovar page1 = new Slovar();

            // Отобразить страницу EditPage во фрейме MainContent
            mainContent.Content = page1;

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
                        TbSlovar epoha = db.TbSlovar.SingleOrDefault(x => x.Id == item.Id);

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
                    var queryResults = db.TbSlovar.Where(x => x.Favorite == true).ToList();

                    // Очистка текущей коллекции Items
                    Items.Clear();

                    // Добавление отфильтрованных данных в коллекцию
                    foreach (var item in queryResults)
                    {
                        Items.Add(new Item
                        {
                            Id = item.Id,
                            Termin = item.Termin,
                            Opisanie = item.Opisanie,
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

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

            // Получить выбранный элемент
            Item selectedItem = (Item)((Button)sender).CommandParameter;
            // Создать экземпляр страницы EditPage и передать ей выбранный элемент
            EditTermin editPage = new EditTermin(selectedItem);
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
                    context.TbSlovar.Remove(context.TbSlovar.Find(selectedItem.Id)); // Измените имя таблицы и свойство поиска в соответствии с вашим проектом
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

            Slovar page1 = new Slovar();

            // Отобразить страницу EditPage во фрейме MainContent
            mainContent.Content = page1;

        }

        private void All_Click(object sender, RoutedEventArgs e)
        {
            LoadItems();
        }
    }
}
