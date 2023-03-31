using System.Globalization;
using System.Windows;
using System;
using System.Windows.Data;

namespace WpfNotepadMvvm.Converter
{
    public class BooleanTextWrapping : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo cultureInfo)
        {
            if (((bool)value) == false)
            {
                return TextWrapping.NoWrap;
            }
            return TextWrapping.Wrap;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
