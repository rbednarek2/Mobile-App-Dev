
using System;
using System.Globalization;
using Xamarin.Forms;

namespace FinalProject.Converter
{
    public class DecimalToMoney : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var valor = (decimal)value;
            return $"$ {valor}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string valor = (string)value;
            return valor.Remove(0);
        }
    }
}