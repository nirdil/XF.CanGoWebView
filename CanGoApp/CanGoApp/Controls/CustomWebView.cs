using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CanGoApp.Controls
{
    public class CustomWebView : WebView
    {
        public CustomWebView() { }
        public static BindableProperty CustomCanGoForwardProperty =
            BindableProperty.Create(
                nameof(CustomCanGoForward),
                typeof(bool),
                typeof(CustomWebView),
                false,
                BindingMode.OneWayToSource);

        public static BindableProperty CustomCanGoBackProperty =
            BindableProperty.Create(
                nameof(CustomCanGoBack),
                typeof(bool),
                typeof(CustomWebView),
                false,
                BindingMode.OneWayToSource);

        public bool CustomCanGoForward
        {
            get => (bool)GetValue(CustomCanGoForwardProperty);
            set => SetValue(CustomCanGoForwardProperty, value);
        }

        public bool CustomCanGoBack
        {
            get => (bool)GetValue(CustomCanGoBackProperty);
            set => SetValue(CustomCanGoBackProperty, value);
        }
    }
}
