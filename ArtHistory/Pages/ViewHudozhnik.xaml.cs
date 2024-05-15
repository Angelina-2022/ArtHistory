using ArtHistory.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static ArtHistory.Pages.Hudozhniki;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewHudozhnik.xaml
    /// </summary>
    public partial class ViewHudozhnik : Page
    {
        public ViewHudozhnik(Item selectedItem)
        {
            InitializeComponent();

            // Получение данных
            try
            {
                // Заполнение полей страницы данными из выбранного элемента
                tbFIO.Text = selectedItem.FIO;
                tbDate.Text = selectedItem.Date;
                tbEpoha.Text = selectedItem.Epoha;


                // Вывод в RichTextBox
                string text = selectedItem.Biografia;
                tbBiografia.AppendText(text);


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
      
    }
}
