using System;

namespace DateRangeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var validation = new InputValidation();
            validation.Check(args);

            if (Equals(validation.Status, InputStatus.Ok)) {
                DateTime.TryParse(args[0], out var from);
                DateTime.TryParse(args[1], out var to);
                var dateRange = new DateRange(from, to);

                Console.WriteLine(dateRange);
            }
            else
            {
                Console.WriteLine(validation.Message);
            }

        }
    }
}
