using System;
using System.Windows.Controls;
using System.Windows.Data;
using WPF.Controls.Enums;

namespace WPF.Controls.Converters
{
    public class LabelPositionConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            LabelPosition orientation = (LabelPosition)value;

            if (orientation == LabelPosition.Left)
                return Orientation.Horizontal;
            else
                return Orientation.Vertical;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
