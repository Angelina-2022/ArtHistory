using ArtHistory.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddTermin.xaml
    /// </summary>
    public partial class AddTermin : Page
    {
        public AddTermin()
        {
            InitializeComponent();
        }

        private void Button_ClickOtmena(object sender, RoutedEventArgs e)
        {
            tbTermin.Clear();
            tbOpisanie.Document.Blocks.Clear();
        }


        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {
            SaveData();
        }
        private void SaveData()
        {
            try {
            // Получить текст из RichTextBox
            string opisanieText = new TextRange(tbOpisanie.Document.ContentStart, tbOpisanie.Document.ContentEnd).Text;

            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                if (string.IsNullOrEmpty(tbTermin.Text) || string.IsNullOrEmpty(opisanieText))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }
                TbSlovar table = new TbSlovar
                {
                    Termin = tbTermin.Text.ToString(),
                    Opisanie = opisanieText
                };

                db.TbSlovar.Add(table);
                db.SaveChanges();
            }
            MessageBox.Show("термин сохранен");
            }
            catch
            {
                // Обработка исключения
                MessageBox.Show("Ошибка. Убедитесь что все поля заполнены", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

    }
}
