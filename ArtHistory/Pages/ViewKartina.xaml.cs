using ArtHistory.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static ArtHistory.Pages.Kartini;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewKartina.xaml
    /// </summary>
    public partial class ViewKartina : Page
    {
        public int id;
        public ViewKartina(Item selectedItem)
        {
            InitializeComponent();

            // Получение данных
            try
            {
                // Заполнение полей страницы данными из выбранного элемента
                id = selectedItem.Id;
                tbName.Text = selectedItem.Nazvanie;
                tbAvtor.Text = selectedItem.Avtor;
                tbDate.Text = selectedItem.Data;


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
       

      
    }
}
