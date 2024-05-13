using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeMAUIApp.Models
{
    public class Base64ToImageConverter:IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (value is string base64string)
            {
                byte[] imageBytes = System.Convert.FromBase64String(base64string);
                return ImageSource.FromStream(() => new System.IO.MemoryStream(imageBytes));
            }
            return null;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
