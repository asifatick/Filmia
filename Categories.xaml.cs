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
using System.Windows.Data;
using System.Windows.Media.Imaging;


namespace GrandAStudio.Filmia
{
    public partial class Categories : PhoneApplicationPage
    {
        Moviadb1DataContext db = App.CurrentApp.DB;
        public Categories()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            checkButtonState(btnCAt00, 1, btnCAt00_Tap);
            
            checkButtonState(btnCAt90, 3, btnCAt90_Tap);

            checkButtonState(btnCAt80, 2, btnCAt80_Tap);

            checkButtonState(btnCAtQT, 4, btnCAtQT_Tap);

            checkButtonState(btnCAtStars, 9, btnCAtStars_Tap);
           
            checkButtonState(btnCAtRan, 8, btnCAtRan_Tap);            

            checkButtonState(btnCAtRoles, 5, btnCAtRoles_Tap);

            checkButtonState(btnCAtOscars,7, btnCAtOscars_Tap);

            checkButtonState(btnCAtDirectors, 10, btnCAtDirectors_Tap);

            checkButtonState(btnCAtAC, 11, btnCAtAC_Tap);

            checkButtonState(btnCAtHS, 12, btnCAtHS_Tap);

            checkButtonState(btnCAtAdvanced, 13, btnCAtAdvanced_Tap);

            checkButtonState(btnCAtOldies, 6, btnCAtOldies_Tap);

        }

        private void checkButtonState(Image btn, int p, EventHandler<GestureEventArgs> evt)
        {
            Categories cat = db.Categories.Where(c => c.IID == (long)p).FirstOrDefault();
            if (cat.IsUnlocked == 1)
            {
                btn.Tap +=new EventHandler<GestureEventArgs>(evt);
                ((BitmapImage)btn.Source).UriSource = new Uri(@"Images/category blue.png", UriKind.Relative);
                if (cat.IsCompleted == 1)
                {
                    ((BitmapImage)btn.Source).UriSource = new Uri(@"Images/category green.png", UriKind.Relative);
                }
            }
        }

        private void btnCAt00_Tap(object sender, GestureEventArgs e)
        {
            StartGame(1);      

        }

        private void StartGame(int p)
        {
            App.ViewModel.CurrentCat = p;
            NavigationService.Navigate(new Uri("/GamePage.xaml", UriKind.Relative));
        }

        private void btnCAt90_Tap(object sender, GestureEventArgs e)
        {
            StartGame(3);  
        }

        private void btnCAt80_Tap(object sender, GestureEventArgs e)
        {
            StartGame(2);  
        }

        private void btnCAtQT_Tap(object sender, GestureEventArgs e)
        {
            StartGame(4);  
        }

        private void btnCAtStars_Tap(object sender, GestureEventArgs e)
        {
            StartGame(9);  
        }

        private void btnCAtRan_Tap(object sender, GestureEventArgs e)
        {
            StartGame(8);  
        }

        private void btnCAtRoles_Tap(object sender, GestureEventArgs e)
        {
            StartGame(5);  
        }

        private void btnCAtOscars_Tap(object sender, GestureEventArgs e)
        {
            StartGame(7);  
        }

        private void btnCAtDirectors_Tap(object sender, GestureEventArgs e)
        {
            StartGame(10);  
        }

        private void btnCAtAC_Tap(object sender, GestureEventArgs e)
        {
            StartGame(11);  
        }

        private void btnCAtHS_Tap(object sender, GestureEventArgs e)
        {
            StartGame(12);  
        }

        private void btnCAtAdvanced_Tap(object sender, GestureEventArgs e)
        {
            StartGame(13);  
        }

       

        private void btnCAtOldies_Tap(object sender, GestureEventArgs e)
        {
            StartGame(6);  
        }

       
    }
}