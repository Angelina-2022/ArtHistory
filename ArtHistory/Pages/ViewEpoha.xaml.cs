using ArtHistory.Model;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using static ArtHistory.Pages.Epohi;


namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewEpoha.xaml
    /// </summary>
    public partial class ViewEpoha : Page
    {

        public ViewEpoha(Item selectedItem)
        {
            InitializeComponent();

            // Получение данны
            try
            {
                // Заполнение полей страницы данными из выбранного элемента
                tbName.Text = selectedItem.Name;
                tbDate.Text = selectedItem.Date;

                 int Id = selectedItem.Id;

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
