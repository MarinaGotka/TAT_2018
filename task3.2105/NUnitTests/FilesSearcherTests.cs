using NUnit.Framework;
using System;
using task3._2105;

namespace NUnitTests
{
    [TestFixture]
    public class SquareCalculatorTests
    {
        [Test]
        public void GetFilesWithExtensionWithInvalidPath()
        {
            string path = @"C:\masm32\bin\gffg\dd";
            string extension = "exe";

            FilesSearcher filesSearcher = new FilesSearcher(path, extension);

            Assert.Throws<ArgumentException>(() => filesSearcher.GetFilesWithExtension());
        }
    }
}
