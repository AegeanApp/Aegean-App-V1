using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;


namespace aegeanapp
{
    public partial class saxm_page : PhoneApplicationPage
    {
        public saxm_page()
        {
            InitializeComponent();
        }

        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        //old version to get pdf
        private async void LaunchPDF()
        {            
            var installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var assets = await installedLocation.GetFolderAsync("Assets");
            var pdf = await assets.GetFileAsync("saxm_Schedule.pdf");
            await Windows.System.Launcher.LaunchFileAsync(pdf);
        }
        private void OPENeCLASS(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://eclass.aegean.gr/");

            //URLs.url = "https://eclass.aegean.gr/";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void search(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://www.google.com");
        }

        private void sef(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://sef.samos.aegean.gr/");

            //URLs.url = "https://sef.samos.aegean.gr/";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

        private void mail(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa"); 

            //URLs.url = "https://webmail.aegean.gr/owa/auth/logon.aspx?replaceCurrent=1&url=https%3a%2f%2fwebmail.aegean.gr%2fowa";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void EUDOXUS_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://eudoxus.gr/");

            //URLs.url = "http://eudoxus.gr/";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void Academic_Calendar_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Uri("/Cal_SAXM.xaml", UriKind.Relative));
        }

        private void saxm_MSc_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.actuar.aegean.gr/postgraduate.html"); 

            //URLs.url = "http://www.actuar.aegean.gr/postgraduate.html";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void schedule_icsd_Click(object sender, RoutedEventArgs e)
        {
            //LaunchPDF();
            ShowInBrowser("http://www.actuar.aegean.gr/orologio_programma.pdf");
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)
        {
            ShowInBrowser("http://www.actuar.aegean.gr/");

            //URLs.url = "http://www.actuar.aegean.gr/";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

       


        
    }
}