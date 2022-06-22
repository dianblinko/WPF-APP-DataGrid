using System;
using System.Globalization;
using System.Windows.Data;

namespace BashNIPI1
{
    public class NaNConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == Double.NaN.ToString() ? "-" : value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() == "-" ? double.NaN : System.Convert.ToDouble(value);
        }
    }
}
