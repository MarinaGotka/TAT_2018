using NUnit.Framework;
using System;

namespace task2._2105
{
    [TestFixture]
    public class SquareCalculatorTests
    {
        [Test]
        public void GetSquareTestValidArguments()
        {
            int length = 3;
            int weight = 5;
            int expected = 15;
            
            SquareCalculator squareCalculator = new SquareCalculator(length, weight);
            int square = squareCalculator.GetSquare();

            Assert.AreEqual(expected, square);
        }

        [Test]
        public void GetSquareTestNullArguments()
        {
            int length = 0;
            int weight = 5;
            SquareCalculator squareCalculator = new SquareCalculator(length, weight);

            Assert.Throws<ArgumentNullException>(() => squareCalculator.GetSquare());
        }

        [Test]
        public void GetSquareTestNegativeArguments()
        {
            int length = 5;
            int weight = -5;
            SquareCalculator squareCalculator = new SquareCalculator(length, weight);

            Assert.Throws<ArgumentException>(() => squareCalculator.GetSquare());
        }
    }
}
