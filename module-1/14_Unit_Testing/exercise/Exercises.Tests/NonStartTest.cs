using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]

        public void ReturnsStringOf1IsEmpty()
        {
            //Arrange
            NonStart ops = new NonStart();
            string a = "x";
            string b = "B";

            //Act
            string result = ops.GetPartialString(a, b);

            //Assert
            Assert.AreEqual("",result, "string must have length of 2");


        }

        [TestMethod]

        public void ReturnwithOneisEmptyString()
        {
            //Arrange
            NonStart ops = new NonStart();
            string a = "xab";
            string b = "";

            //Act
            string result = ops.GetPartialString(a, b);

            //Assert
            Assert.AreEqual("ab", result);


        }

        [TestMethod]

        public void ReturnStringsMinusFirstLetter()
        {
            //Arrange
            NonStart ops = new NonStart();
            string a = "xaby";
            string b = "string";

            //Act
            string result = ops.GetPartialString(a, b);

            //Assert
            Assert.AreEqual("abytring", result);


        }
    }
}
