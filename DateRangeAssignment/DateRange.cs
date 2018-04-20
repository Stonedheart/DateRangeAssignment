using System;
using System.Globalization;


namespace DateRangeAssignment
{
    public class DateRange
    {
        public DateTime From { get; }
        public DateTime To { get; }

        public DateRange(DateTime from, DateTime to)
        {
            From = from;
            To = to;         
        }

        public override string ToString()
        {
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern; 
            var from = From.ToString(datePattern);
            var to = To.ToString(datePattern);

            if (From.Year == To.Year && From.Month == To.Month)
            {
                from = From.Day.ToString();
            }

            if (From.Year == To.Year)
            {
                var separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
                var year = From.Year.ToString();
                from = from.Replace($"{year}", "").Trim(char.Parse($"{separator}"));
            }

            return $"{from} - {to}";
        }
    }
}
