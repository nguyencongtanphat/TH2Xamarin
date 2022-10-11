using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace TH2.Converter
{
    public class StatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isBooked = (bool)value;
            if (isBooked) return "Booked";
            return "Available";

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            bool isBooked = (bool)value;
            if (isBooked) return "Booked";
            return "Available";
        }
    }
}
