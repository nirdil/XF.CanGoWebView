using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Webkit;
using Android.Widget;
using Xamarin.Forms.Platform.Android;

namespace CanGoApp.Droid
{
    public class CustomWebViewClient : FormsWebViewClient
    {
        public delegate void AddressChangedEventHandler(string url);
        public event AddressChangedEventHandler AddressChanged;
        public CustomWebViewClient(WebViewRenderer renderer) : base(renderer) { }
        public override void DoUpdateVisitedHistory(WebView view, string url, bool isReload)
        {
            base.DoUpdateVisitedHistory(view, url, isReload);
            AddressChanged?.Invoke(view.Url);
        }
    }
}