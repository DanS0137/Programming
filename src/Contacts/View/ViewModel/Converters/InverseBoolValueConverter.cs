using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.ViewModel
{
    /// <summary>
    /// Класс для отрицания булевого значения.
    /// </summary>
    public class InverseBoolValueConverter : IValueConverter
    {
        object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return !(bool)value;
        }

        object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return DependencyProperty.UnsetValue;
        }
    }
}
