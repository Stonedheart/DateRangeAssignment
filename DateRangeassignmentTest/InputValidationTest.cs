using DateRangeAssignment;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DateRangeassignmentTest
{
    [TestClass]
    public class InputValidationTest
    {
        [TestMethod]
        public void IncorrectArgumentsNumber_ExpectedTwo_SetProperStatus()
        {
            var testArray = new string[0];
            var testInputValidation = new InputValidation();

            testInputValidation.Check(testArray);
            Assert.AreEqual(testInputValidation.Status, InputStatus.IncorrectArgumentsNumber);
        }

        [TestMethod]
        public void InvalidArguments_SetProperStatuses()
        {
            var testArray = new string[] { "", "1.02.03" };
            var testInputValidation = new InputValidation();

            testInputValidation.Check(testArray);
            Assert.AreEqual(testInputValidation.Status, InputStatus.FirstArgumentInvalid);
        }

        [TestMethod]
        public void InvalidSecondArgument_SetProperStatus()
        {
            var testArray = new string[] { "1.02.03", "" };
            var testInputValidation = new InputValidation();

            testInputValidation.Check(testArray);
            Assert.AreEqual(testInputValidation.Status, InputStatus.SecondArgumentInvalid);
        }

        [TestMethod]
        public void FirstDateLaterThanSecond_ExpectedFirstEarlier_SetProperStatus()
        {
            var testArray = new string[] { "1.02.03", "10.01.01" };
            var testInputValidation = new InputValidation();

            testInputValidation.Check(testArray);
            Assert.AreEqual(testInputValidation.Status, InputStatus.InvalidArgumentsOrder);
        }
    }
}
