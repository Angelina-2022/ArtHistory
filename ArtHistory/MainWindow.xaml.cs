using ArtHistory.Pages;
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace ArtHistory
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();

            // Установка начальной страницы на HomePage.xaml
            MainContent.Content = new HomePage();


        }
        

        private void Home(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new HomePage());
        }

        private void Epohi(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Epohi());
        }


        private void AddEpoha(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddEpoha());
        }

        private void AddHudozhnik(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddHudozhnik());
        }

        private void AddKartina(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddKartina());

        }

        private void AddTermins(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddTermin());
        }
        private void AddLink(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AddLink());
        }

        private void Kartina(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Kartini());
        }

        private void Termins(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Slovar());
        }

        private void Hudozhniki(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Hudozhniki());
        }

        private void Links(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new Links());
        }

        private void About(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new About());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MainContent_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }

}
