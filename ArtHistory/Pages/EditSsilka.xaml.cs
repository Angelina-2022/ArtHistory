using ArtHistory.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using static ArtHistory.Pages.Links;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditSsilka.xaml
    /// </summary>
    public partial class EditSsilka : Page
    {
        public int id;

        public EditSsilka(Item selectedItem)
        {
            InitializeComponent();

            try
            {
                id = selectedItem.Id;

                // Заполнение полей страницы данными из выбранного элемента
                tbLink.Text = selectedItem.Ssilka;

                // Вывод в RichTextBox
                string text = selectedItem.Opisanie;
                tbOpisanie.AppendText(text);




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                // Получить выбранную строку из таблицы
                TbSsilki table = db.TbSsilki.ToList().Find(t => t.Id == id); // здесь selectedId - идентификатор выбранной строки

                // Получить текст из RichTextBox
                string opisanieText = new TextRange(tbOpisanie.Document.ContentStart, tbOpisanie.Document.ContentEnd).Text;

                // Обновление выбранной строки в базе данных
                try
                {
                    table.Ssilka = tbLink.Text.ToString();
                    table.Opisanie = opisanieText;


                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка сохранения: {ex.Message}");
                }
            }
            MessageBox.Show("сохранено!");
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
                    context.TbSsilki.Remove(context.TbSsilki.Find(selectedItem.Id)); // Измените имя таблицы и свойство поиска в соответствии с вашим проектом
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

            Links page1 = new Links();

            // Отобразить страницу EditPage во фрейме MainContent
            mainContent.Content = page1;

        }
    }
}
