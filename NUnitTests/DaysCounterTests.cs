using NUnit.Framework;
using System;
using WebService_Task11;

namespace NUnitTests
{
    [TestFixture]
    public class DaysADCounterTests
    {
        [TestCase(13,1,1,12)]
        [TestCase(1, 2, 1, 31)]
        [TestCase(1, 1, 2, 365)]
        [TestCase(1, 1, 1, 0)]
        public void CalculateDaysFromADTest_ValidDate(int day, int month, int year, int expected)
        {
            DaysADCounter webService = new DaysADCounter();
            int result = webService.CalculateDaysFromAD(day, month, year);
            Assert.AreEqual(expected, result);
        }

        [TestCase(0, 0, 0)]
        [TestCase(-1, 1, 3)]
        [TestCase(34, 1, 1)]
        [TestCase(1, 16, 2)]
        [TestCase(1, 1, -3)]
        public void CalculateDaysFromADTest_WrongDate(int day, int month, int year)
        {
            DaysADCounter webService = new DaysADCounter();
            Assert.Throws<FormatException>(() => webService.CalculateDaysFromAD(day, month, year));
        }
    }
}
