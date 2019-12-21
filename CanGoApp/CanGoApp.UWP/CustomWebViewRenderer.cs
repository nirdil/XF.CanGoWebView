using CanGoApp.Controls;
using CanGoApp.UWP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;

[assembly: ExportRenderer(typeof(CustomWebView), typeof(CustomWebViewRenderer))]
namespace CanGoApp.UWP
{
    public class CustomWebViewRenderer : WebViewRenderer
    {
        bool _registeredControl = false;
        long _goBackRegistrationToken = 0;
        long _goForwardRegistrationToken = 0;

        protected override void Dispose(bool disposing)
        {
            UnregisterControl();
            base.Dispose(disposing);
        }

        protected override void OnElementChanged(ElementChangedEventArgs<WebView> e)
        {
            base.OnElementChanged(e);
            RegisterControl();
        }

        private void UnregisterControl()
        {
            if (Control != null && _registeredControl)
            {
                _registeredControl = false;
                Control.UnregisterPropertyChangedCallback(Windows.UI.Xaml.Controls.WebView.CanGoBackProperty, _goBackRegistrationToken);
                Control.UnregisterPropertyChangedCallback(Windows.UI.Xaml.Controls.WebView.CanGoForwardProperty, _goForwardRegistrationToken);
            }
        }

        private void RegisterControl()
        {
            if (Control != null && !_registeredControl)
            {
                _registeredControl = true;
                _goBackRegistrationToken = Control.RegisterPropertyChangedCallback(Windows.UI.Xaml.Controls.WebView.CanGoBackProperty, new Windows.UI.Xaml.DependencyPropertyChangedCallback(OnWebViewCanGoBackChanged));
                _goForwardRegistrationToken = Control.RegisterPropertyChangedCallback(Windows.UI.Xaml.Controls.WebView.CanGoForwardProperty, new Windows.UI.Xaml.DependencyPropertyChangedCallback(OnWebViewCanGoForwardChanged));
            }
        }

        private void OnWebViewCanGoBackChanged(Windows.UI.Xaml.DependencyObject sender, Windows.UI.Xaml.DependencyProperty dp)
        {
            ((CustomWebView)Element).CustomCanGoBack = Control.CanGoBack;
        }

        private void OnWebViewCanGoForwardChanged(Windows.UI.Xaml.DependencyObject sender, Windows.UI.Xaml.DependencyProperty dp)
        {
            ((CustomWebView)Element).CustomCanGoForward = Control.CanGoForward;
        }
    }
}
