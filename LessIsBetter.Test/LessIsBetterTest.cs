using Line.Handler;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LessIsBetters.Test
{
    [TestClass]
    public class LessIsBetterTest
    {
        [TestMethod]
        [DataRow("45 34 24 108 76 58 64 130 80", "130 24 34 80 108 45 64 58 76")]
        [DataRow("1", "1")]
        [DataRow("1 12", "1 12")]
        public void OnlyNumbers(string testString, string expectedValue)
        {
            // Arrange
            LessIsBetter lessIsBetter = new LessIsBetter();
            string strResult = lessIsBetter.Order(testString);
            // Act

            // Assert
            Assert.AreEqual(expectedValue, strResult);
        }

        [TestMethod]
        [DataRow("    2022 70 123    3344 13 ", "13 123 2022 70 3344")]
        public void NumbersAndSpace(string testString, string expectedValue)
        {
            // Arrange
            LessIsBetter lessIsBetter = new LessIsBetter();
            string strResult = lessIsBetter.Order(testString);
            // Act

            // Assert
            Assert.AreEqual(expectedValue, strResult);
        }

        [TestMethod]
        [DataRow ("3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697", "3 16 9 38 95 1131268 49455 347464 59544965313 496636983114762 85246814996697")]
        public void NumberTypeLong(string testString, string expectedValue)
        {
            // Arrange
            LessIsBetter lessIsBetter = new LessIsBetter();
            string strResult = lessIsBetter.Order(testString);
            // Act

            // Assert
            Assert.AreEqual(expectedValue, strResult);
        }
    }
}
