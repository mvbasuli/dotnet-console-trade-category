using System;
using System.Globalization;
using TradeCategory.Domain.Model;

namespace TradeCategory.Domain.Extensions
{
    // Extension Methods
    public static class InputExtension
    {
        public static Trade InputToTrade(this string line)
        {
            if (string.IsNullOrEmpty(line))
                throw new Exception("Line cannot be null or empty");

            var inputs = line.Split(" ");
            if (inputs.Length != 3)
                throw new Exception("Format line invalid");

            double value;
            if (!double.TryParse(inputs[0], NumberStyles.Float, CultureInfo.InvariantCulture, out value))
                throw new Exception("Format of value of trade invalid");

            return new Trade(value,
                inputs[1],
                DateTime.ParseExact(inputs[2], "MM/dd/yyyy", CultureInfo.InvariantCulture));
        }

        public static DateTime InputToDate(this string strDate)
        {
            if (string.IsNullOrEmpty(strDate))
                throw new Exception("Line cannot be null or empty");

            return DateTime.ParseExact(strDate, "MM/dd/yyyy", CultureInfo.InvariantCulture);
        }

        public static int InputToInt(this string strInt)
        {
            int value;
            if (!int.TryParse(strInt, out value))
                throw new Exception("Format of value of trade invalid");
            return value;
        }
    }
}
