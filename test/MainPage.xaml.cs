﻿using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Tasks;
using Windows.Devices.Geolocation;//Provides the Geocoordinate class.
namespace aegeanapp
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }
        public bool checkLocationSetting()
        {
            var GeoLocator1 = new Geolocator();

            if (GeoLocator1.LocationStatus == PositionStatus.Disabled)
            {
                // Location Service is turned OFF
                // Provide a visual message asking user to turn it ON
                MessageBoxResult result = MessageBox.Show("Η χρήση της τοποθεσίας σας δεν είναι ενεργή", "Error", MessageBoxButton.OKCancel);
                if (result == MessageBoxResult.OK)
                {
                    return false;
                    //NavigationService.GoBack();
                }
                //This block of code is used only for the bool cases
                else
                {
                    return false;
                    //NavigationService.GoBack();
                }
              
                
            }
            else
            {
                return true;// Location Service is already enabled. Proceed with your app functionality.
            }
        }
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        private void Button_Click_to_ICSD(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/icsd_page.xaml", UriKind.Relative));
        }

        private void saxm_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/saxm_page.xaml", UriKind.Relative));
        }

        private void math_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/math-PAGE.xaml", UriKind.Relative));
        }

        private void Logo_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ShowInBrowser("https://www.aegean.gr");
        }
        private void b_food1_click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Sitisi_MainPage.xaml", UriKind.Relative));
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if(checkLocationSetting()==true)
            {
                NavigationService.Navigate(new Uri("/MapsPage.xaml", UriKind.Relative));
            }
            else
            {
                return;
            }
           
        }

        private void ApplicationBarIconButton_Click(object sender, EventArgs e)
        {
            MarketplaceReviewTask m=new MarketplaceReviewTask();
            m.Show();
        }

        private void ApplicationBarIconButton_Click_1(object sender, EventArgs e)
        {
            EmailComposeTask et = new EmailComposeTask();
            et.Subject = "Aegean App - Feedback";
            et.To = "aegean_app@hotmail.com";
            et.Show();
        }

        private void ApplicationBarIconButton_Click_2(object sender, EventArgs e)
        {
            NavigationService.Navigate(new Uri("/about.xaml", UriKind.Relative));

        }

       

  

       

        // Sample code for building a localized ApplicationBar
        //private void BuildLocalizedApplicationBar()
        //{
        //    // Set the page's ApplicationBar to a new instance of ApplicationBar.
        //    ApplicationBar = new ApplicationBar();

        //    // Create a new button and set the text value to the localized string from AppResources.
        //    ApplicationBarIconButton appBarButton = new ApplicationBarIconButton(new Uri("/Assets/AppBar/appbar.add.rest.png", UriKind.Relative));
        //    appBarButton.Text = AppResources.AppBarButtonText;
        //    ApplicationBar.Buttons.Add(appBarButton);

        //    // Create a new menu item with the localized string from AppResources.
        //    ApplicationBarMenuItem appBarMenuItem = new ApplicationBarMenuItem(AppResources.AppBarMenuItemText);
        //    ApplicationBar.MenuItems.Add(appBarMenuItem);
        //}
    }
}