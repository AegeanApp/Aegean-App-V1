using System;
using System.Windows;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;

namespace aegeanapp
{
    public partial class math_PAGE : PhoneApplicationPage
    {
        public math_PAGE()
        {
            InitializeComponent();
        }
        private void ShowInBrowser(string url)
        {
            Microsoft.Phone.Tasks.WebBrowserTask wbt = new Microsoft.Phone.Tasks.WebBrowserTask();
            wbt.Uri = new Uri(url);
            wbt.Show();
        }
        //older version to get pdf
        private async void LaunchPDF()
        {
            var installedLocation = Windows.ApplicationModel.Package.Current.InstalledLocation;
            var assets = await installedLocation.GetFolderAsync("Assets");
            var pdf = await assets.GetFileAsync("math_Schedule.pdf");
            await Windows.System.Launcher.LaunchFileAsync(pdf);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
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

        private void OPENeCLASS(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://cms.math.aegean.gr/");

            //URLs.url = "https://eclass.aegean.gr/";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
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
            NavigationService.Navigate(new Uri("/Cal_MATH.xaml", UriKind.Relative));
        }

        private void math_MSc_Click(object sender, RoutedEventArgs e)
        {
            ShowInBrowser("http://www.actuar.aegean.gr/postgraduate.html");

           // URLs.url = "http://www.math.aegean.gr/pms/index.html";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }

        private void schedule_icsd_Click(object sender, RoutedEventArgs e)
        {
            //LaunchPDF();
            ShowInBrowser("http://samosweb.aegean.gr/math/mathweb/images/articles/announcements/2016-2017/%CE%A9%CE%A1%CE%9F%CE%9B%CE%9F%CE%93%CE%99%CE%9F%20%CE%A0%CE%A1%CE%9F%CE%93%CE%A1%CE%91%CE%9C%CE%9C%CE%91%20E16-17_version_02.pdf");
        }

        private void TextBlock_Tap(object sender, System.Windows.Input.GestureEventArgs e)/// main page math
        {
            ShowInBrowser("https://www.math.aegean.gr/in/index.htm");

            //URLs.url = "https://www.math.aegean.gr/in/index.htm";
            //NavigationService.Navigate(new Uri("/WebView_Page.xaml", UriKind.Relative));
        }
    
    }
}