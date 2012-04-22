using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace GrandAStudio.Filmia
{
    public partial class MainPage : PhoneApplicationPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        

        private void btnPlay_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Categories.xaml", UriKind.Relative));
        }

        private void btnOption_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Options.xaml", UriKind.Relative));
        }

        private void btnStats_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/StatsPage.xaml", UriKind.Relative));
        }

        private void btnFacebook_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void btnTwitter_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}