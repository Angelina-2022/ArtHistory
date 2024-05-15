using GalaSoft.MvvmLight.Messaging;
using System.Windows.Controls;
using System.Windows.Media;

namespace ArtHistory.Pages
{
    /// <summary>
    /// Логика взаимодействия для About.xaml
    /// </summary>
    public partial class About : Page
    {
        public About()
        {
            InitializeComponent();

            string text = "\r\n\r\nНазвание приложения:" +
                "\r\nArtHistory - Информационно-справочная система по истории изобразительного искусства " +
                "\r\n\r\nАвтор:" +
                "\r\nБатина А.В." +
                "\r\n\r\nГод:" +
                "\r\n2024";

            // Вставляем FlowDocument в RichTextBox
            RTB.AppendText(text);
        }

    }
}
