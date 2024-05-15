using ArtHistory.Model;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddLink.xaml
    /// </summary>
    public partial class AddLink : Page
    {
        public AddLink()
        {
            InitializeComponent();
        }
        private void Button_ClickSave(object sender, RoutedEventArgs e)
        {
            SaveData();
        }

        private void SaveData()
        {
            try { 
            // Подключение к базе данных с использованием Entity Framework
            using (ArtHistoryDBEntities db = new ArtHistoryDBEntities())
            {
                // Получить текст из RichTextBox
                string opisanieText = new TextRange(tbOpisanie.Document.ContentStart, tbOpisanie.Document.ContentEnd).Text;


                if (string.IsNullOrEmpty(tbLink.Text) || string.IsNullOrEmpty(opisanieText))
                {
                    MessageBox.Show("Пожалуйста, заполните все поля.");
                    return;
                }

                TbSsilki table = new TbSsilki
                {
                    Ssilka = tbLink.Text.ToString(),
                    Opisanie = opisanieText
                };

                db.TbSsilki.Add(table);
                db.SaveChanges();
            }
            MessageBox.Show("ссылка сохранена");
            }
            catch
            {
                // Обработка исключения
                MessageBox.Show("Ошибка. Убедитесь что все поля заполнены", "Ошибка сохранения", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_ClickOtmena(object sender, RoutedEventArgs e)
        {
            tbLink.Clear();
            tbOpisanie.Document.Blocks.Clear();
        }

    }
}
