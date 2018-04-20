using System;
using System.Threading;
using System.Globalization;
using DateRangeAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateRangeassignmentTest
{
    

    [TestClass]
    public class DateRangeTest
    {
        DateTime FirstDate = new DateTime(2000, 2, 1);
        DateTime SecondDate = new DateTime(2011, 4, 3);
        DateTime SecondDateSameYear = new DateTime(2000, 5, 4);
        DateTime SecondDateSameYearAndMonth = new DateTime(2000, 2, 5);


        [TestMethod]
        public void DifferentDates_DayMonthYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-gb");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDate);
            var expected = $"{FirstDate.ToString(datePattern)} - {SecondDate.ToString(datePattern)}";
            
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYear_DayMonthYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-gb");
            var separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYear);
            var expected = $"{FirstDate.Day.ToString()}{separator}{FirstDate.Month.ToString("M")} - {SecondDateSameYear.ToString(datePattern)}";
            
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYearAndMonth_DayMonthYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-gb");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYearAndMonth);
            var expected = $"{FirstDate.Day.ToString("d")} - {SecondDateSameYearAndMonth.ToString(datePattern)}";
            
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DifferentDates_MonthDayYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDate);
            var expected = $"{FirstDate.ToString(datePattern)} - {SecondDate.ToString(datePattern)}";
            
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYear_MonthDayYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            var separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYear);
            var expected = $"{FirstDate.Month.ToString()}{separator}{FirstDate.Day.ToString()} - {SecondDateSameYear.ToString(datePattern)}";
            
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYearAndMonth_MonthDayYearFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("en-us");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYearAndMonth);
            var expected = $"{FirstDate.Day.ToString()} - {SecondDateSameYearAndMonth.ToString(datePattern)}";
             
            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DifferentDates_YearMonthDayFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("jp-jp");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDate);
            var expected = $"{FirstDate.ToString(datePattern)} - {SecondDate.ToString(datePattern)}";

            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYear_YearMonthDayFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("jp-jp");
            var separator = CultureInfo.CurrentCulture.DateTimeFormat.DateSeparator;
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYear);
            var expected = $"{FirstDate.Month.ToString()}{separator}{FirstDate.Day.ToString()} - {SecondDateSameYear.ToString(datePattern)}";

            Assert.AreEqual(expected, $"{testDateRange}");
        }

        [TestMethod]
        public void DatesWithSameYearAndMonth_YearMonthDayFormat_ReturnExpectedString()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.GetCultureInfo("jp-jp");
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            var testDateRange = new DateRange(FirstDate, SecondDateSameYearAndMonth);
            var expected = $"{FirstDate.Day.ToString()} - {SecondDateSameYearAndMonth.ToString(datePattern)}";

            Assert.AreEqual(expected, $"{testDateRange}");
        }
    }
}
