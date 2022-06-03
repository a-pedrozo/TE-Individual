using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class StringOperationsTests
    {
        [TestMethod]
        public void CapitalizeShouldOnlyCaptializeFirstLetter()
        {
            // Arrange
            StringOperations sut = new StringOperations();

            // Act
            string result = sut.MakeStandardCapitalizationString("JiMoTHy");

            // Assert
            Assert.AreEqual("Jimothy", result);
        }

        [TestMethod]
        public void CapitalizeShouldReturnEmptyStringForNull()
        {
            // Arrange
            StringOperations sut = new StringOperations();

            // Act
            string result = sut.MakeStandardCapitalizationString(null);

            // Assert
            Assert.AreEqual("", result);
            Assert.AreEqual(0, result.Length);
        }

        [TestMethod]
        public void WordShouldHaveCorrectVowelCount()
        {
            // Arrange
            StringOperations ops = new StringOperations();

            // Act
            int result = ops.CalculateNumberOfVowels("PaTIO");

            // Assert
            Assert.AreEqual(3, result, "Patio should have correct #");
        }
    }
}
