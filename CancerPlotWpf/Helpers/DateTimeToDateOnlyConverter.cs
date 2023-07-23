using System;
using System.Globalization;
using System.Windows.Data;

namespace CancerPlotWpf.Helpers
{
    internal class DateTimeToDateOnlyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateTime dateTime)
            {
                return new DateOnly(dateTime.Year, dateTime.Month, dateTime.Day);
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is DateOnly dateOnly)
            {
                return dateOnly.ToDateTime(new TimeOnly());
            }

            return null;
        }
    }
}
