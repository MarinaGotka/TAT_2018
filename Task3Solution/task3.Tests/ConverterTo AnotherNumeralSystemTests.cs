using System;
using System.Numerics;
using NUnit.Framework;
using task_DEV3;

namespace task3.Tests
{
    [TestFixture]
    public class ConverterToAnotherNumeralSystemTests
    {
        [Test]
        public void ConvertToAnotherNumeralSystem_ArgumentIsNegative_ExpectedException()
        {
            int number = -31;
            int radix = 16;
            ConverterToAnotherNumeralSystem numb = new ConverterToAnotherNumeralSystem(number, radix);
            Assert.Throws<ArgumentException>(() => numb.ConvertToAnotherNumeralSystem());
        }

        [Test]
        public void ConvertToAnotherNumeralSystem_ArgumentIsLessMinValidValue_ExpectedException()
        {
            BigInteger number = 19;
            int radix = 1;
            ConverterToAnotherNumeralSystem numb = new ConverterToAnotherNumeralSystem(number, radix);
            Assert.Throws<FormatException>(() => numb.ConvertToAnotherNumeralSystem());
        }

        [Test]
        public void ConvertToAnotherNumeralSystem_ArgumentIsMoreMaxValidValue_ExpectedException()
        {
            BigInteger number = 19;
            int radix = 21;
            ConverterToAnotherNumeralSystem numb = new ConverterToAnotherNumeralSystem(number, radix);
            Assert.Throws<FormatException>(() => numb.ConvertToAnotherNumeralSystem());
        }

        [Test]
        public void ConvertToAnotherNumeralSystem_ArgumentIsMinValidValue()
        {
            BigInteger number = 10;
            int radix = 2;
            string expected = "1010";
            ConverterToAnotherNumeralSystem numb = new ConverterToAnotherNumeralSystem(number, radix);
            Assert.AreEqual(expected, numb.ConvertToAnotherNumeralSystem());

        }

        [Test]
        public void ConvertToAnotherNumeralSystem_ArgumentIsMaxValidValue()
        {
            BigInteger number = 19;
            int radix = 20;
            string expected = "J";
            ConverterToAnotherNumeralSystem numb = new ConverterToAnotherNumeralSystem(number, radix);
            Assert.AreEqual(expected, numb.ConvertToAnotherNumeralSystem());
        }
    }
}
