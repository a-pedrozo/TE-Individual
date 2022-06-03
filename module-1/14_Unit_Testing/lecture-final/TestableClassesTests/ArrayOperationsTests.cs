using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class ArrayOperationsTests
    {
        [TestMethod]
        public void GetLowestShouldReturnLowestPositiveNumber()
        {
            // Arrange
            ArrayOperations ops = new ArrayOperations();
            int[] input = new int[] { 1, 4, 8, 32, 24 };

            // Act
            int lowest = ops.GetLowestNumber(input);

            // Assert
            Assert.AreEqual(1, lowest);
        }

        [TestMethod]
        public void GetLowestShouldReturnZeroForEmptyArray()
        {
            // Arrange
            ArrayOperations ops = new ArrayOperations();
            int[] input = new int[] { };

            // Act
            int lowest = ops.GetLowestNumber(input);

            // Assert
            Assert.AreEqual(0, lowest);
        }

        [TestMethod]
        public void ReverseShouldReverseANormalArray()
        {
            // Arrange
            ArrayOperations ops = new ArrayOperations();
            int[] input = new int[] { 1, 2, 3 };
            int[] expected = new int[] { 3, 2, 1 };

            // Act
            int[] result = ops.ReverseArray(input);

            // Assert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(2, result[1]);
            CollectionAssert.AreEquivalent(expected, result);
            //Assert.AreEqual(expected, result);
        }
    }
}
