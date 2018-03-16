using System;
using Xunit;
using task_DEV2;

namespace task2.Tests
{
    public class EvenIndexesStringCreatorTest
    {
        [Fact]
        public void BuildSubstringOnlyOfEvenIndexes_StringIsNull_ExpectedException()
        {
            // Arrange
            string inputString = null;
            EvenIndexesStringCreator str = new EvenIndexesStringCreator(inputString);

            //Assert
            Assert.Throws<Exception>(() => str.BuildSubstringOnlyOfEvenIndexes());
        }

        [Fact]
        public void BuildSubstringOnlyOfEvenIndexes_StringContainsSpace()
        {
            // Arrange
            string inputString = "12 as  t";
            string expectedString = "1 s ";
            EvenIndexesStringCreator str = new EvenIndexesStringCreator(inputString);

            // Act
            string res = str.BuildSubstringOnlyOfEvenIndexes();

            // Assert
            Assert.Equal(expectedString,res);
        }

        [Fact]
        public void BuildSubstringOnlyOfEvenIndexes_StringContainsSpecialSymbols()
        {
            // Arrange
            string inputString = "@6%g*jj#";
            string expectedString = "@%*j";
            EvenIndexesStringCreator str = new EvenIndexesStringCreator(inputString);

            // Act
            string res = str.BuildSubstringOnlyOfEvenIndexes();

            // Assert
            Assert.Equal(expectedString, res);
        }
    }
}
