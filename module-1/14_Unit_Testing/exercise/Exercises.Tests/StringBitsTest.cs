using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]

        public void ResultShouldStartWithFirstLetter()
        {
            //Arrange
            StringBits ops = new StringBits();

            //Act
            string result = ops.GetBits("Hi");

            //Assert
            Assert.AreEqual("H", result);
        }

        [TestMethod]

        public void ResultShouldReturnEvenNumberLetters()
        {
            //Arrange
            StringBits ops = new StringBits();

            //Act
            string result = ops.GetBits("Four");

            //Assert
            Assert.AreEqual("Fu", result);
        }

        [TestMethod]

        public void ResultShouldReturnEmptyString()
        {
            //Arrange
            StringBits ops = new StringBits();

            //Act
            string result = ops.GetBits("");

            //Assert
            Assert.AreEqual("", result);
        }
    }
}
