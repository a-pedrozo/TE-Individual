using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]

        public void ShouldReturnStringWithLessThanThree()
        {
            //Arrange
            FrontTimes ops = new FrontTimes();

            //Act
            string result = ops.GenerateString("ab",4);

            //Assert
            Assert.AreEqual("abababab", result);
        }

        [TestMethod]

        public void ShouldReturnEmptyString()
        {
            //Arrange
            FrontTimes ops = new FrontTimes();

            //Act
            string result = ops.GenerateString("", 4);

            //Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]

        public void ShouldReturSingleCharWords()
        {
            //Arrange
            FrontTimes ops = new FrontTimes();

            //Act
            string result = ops.GenerateString("1", 5);

            //Assert
            Assert.AreEqual("11111", result);
        }

    }

}

