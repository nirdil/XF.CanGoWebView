using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Android.Content;
using System.Threading.Tasks;
using Android.Webkit;
using System.ComponentModel;
using CanGoApp.Controls;
using CanGoApp.Droid;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace CanGoApp.Droid
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        public CustomWebViewRenderer(Context context) : base(context)
        {
        }

        protected override WebViewClient GetWebViewClient()
        {
            CustomWebViewClient webViewClient = new CustomWebViewClient(this);
            webViewClient.AddressChanged += AddressChanged;
            return webViewClient;
        }

        private void AddressChanged(string url)
        {
            if (Element is CustomWebView customWebView && Control != null)
            {
                customWebView.CustomCanGoBack = Control.CanGoBack();
                customWebView.CustomCanGoForward = Control.CanGoForward();
            }
        }
    }
}