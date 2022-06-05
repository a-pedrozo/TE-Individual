using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
    
{
    [TestClass]
    public class ArrayOperationsTest
    {
        [TestMethod]

        public void GetLowestShouldReturnLowestPositiveNUmber()
        {
            //Arrange
            ArrayOperations aops = new ArrayOperations();
            int[] input = new int[] { 1, 2, 43, 69, 420, 666 };

            //Act
            int lowest = aops.GetLowestNumber(input);

            //Assert
            Assert.AreEqual(1, input);
        }

        [TestMethod]

        public void GetLowestShouldReturnZeroIfEmptyArray()
        {
            //Arrange
            ArrayOperations aops = new ArrayOperations();
            int[] input = new int[] {};

            //Act
            int lowest = aops.GetLowestNumber(input);

            //Assert
            Assert.AreEqual(0, input);
        }

        [TestMethod]

        public void ReverseShouldReverseANormalArray()
        {
            //Arrange 
            ArrayOperations apos = new ArrayOperations(); // arrays are stored on heap but different, collectionAssert is one way of fixing 
            int[] input = new int[] { 1, 2, 3 };
            int[] expected = new int[] { 3, 2, 1 };

            //Act
            int[] result = apos.ReverseArray(input);

            //Assert  alternate way isntead of using collectionAssert
            Assert.IsNotNull(result);
            Assert.AreEqual(expected.Length, result.Length);
            Assert.AreEqual(3, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(expected, result);
            CollectionAssert.AreEquivalent(expected, result);
        }

    }
}
