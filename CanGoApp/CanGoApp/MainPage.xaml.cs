using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Xamarin.Forms;

namespace CanGoApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void GoBackClicked(object sender, EventArgs e)
        {
            webView.GoBack();
        }

        private void GoForwardClicked(object sender, EventArgs e)
        {
            webView.GoForward();
        }

        private void GoToGoogleClicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = "https://www.google.com" };
        }

        private void GoToAngularClicked(object sender, EventArgs e)
        {
            webView.Source = new UrlWebViewSource { Url = "https://angular.realworld.io/" };
        }
    }
}
