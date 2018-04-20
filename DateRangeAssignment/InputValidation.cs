using System;
using System.Globalization;


namespace DateRangeAssignment
{
    public enum InputStatus
    {
        IncorrectArgumentsNumber,
        FirstArgumentInvalid,
        SecondArgumentInvalid,
        InvalidArgumentsOrder,
        Ok
    }

    public class InputValidation
    {
        public InputStatus Status { get; private set; }
        public string Message { get; set; }

        public void Check(string[] input)
        {
            var expectedArgsNumber = 2;
            var datePattern = CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern;
            Status = InputStatus.Ok;

            if (input.Length != 2)
            {
                Message = $"Incorrect number of arguments, please provide exactly {expectedArgsNumber} dates";
                Status = InputStatus.IncorrectArgumentsNumber;
                return;
            }

            if (!DateTime.TryParse(input[0], out var first))
            {
                Message = $"First argument is invalid, provide date in correct format: {datePattern}";
                Status = InputStatus.FirstArgumentInvalid;
                return;
            }

            if (!DateTime.TryParse(input[1], out var second))
            {
                Message = $"Second argument is invalid, provide date in correct format: {datePattern}";
                Status = InputStatus.SecondArgumentInvalid;
                return;
            }

            if (DateTime.Compare(first, second) >= 0)
            {
                Message = "First date should be earlier than second";
                Status = InputStatus.InvalidArgumentsOrder;
                return;
            }
        }
    }
}
