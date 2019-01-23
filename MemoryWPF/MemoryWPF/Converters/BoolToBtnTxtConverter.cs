using System;
using System.Globalization;
using System.Windows.Data;

using MemoryWPF.DataHelpers;

namespace MemoryWPF.Converters
{
    public class BoolToBtnTxtConverter : IMultiValueConverter
    {
        public object Convert(object[] values, Type targetType, object parameter, CultureInfo culture)
        {
            Language language = (Language)values[0];
            bool showScores = (bool)values[1];

            if (language == Language.English)
                return showScores ? "Hide scores!" : "Show scores!";
            else
                return showScores ? "Sakrij rezultate!" : "Pokaži rezultate!";
        }

        public object[] ConvertBack(object value, Type[] targetTypes, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
