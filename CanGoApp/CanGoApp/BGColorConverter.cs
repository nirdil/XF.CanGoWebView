using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CanGoApp
{
    public class BGColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if ((bool)value)
            {
                return Color.Green;
            }

            return Color.Red;
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return true;
        }
    }
}
