﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;

namespace aegeanapp
{
    public partial class WebView_Page : PhoneApplicationPage
    {
        public WebView_Page()
        {
            InitializeComponent();
        }

        private void WebBrsr_Loaded(object sender, RoutedEventArgs e)
        {
            WebBrsr.Source = new Uri(URLs.url, UriKind.Absolute);
        }
    }
}