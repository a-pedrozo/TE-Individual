using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;


namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {
        [TestMethod]

        public void ReturnFalseIfMutipleOf20()
        {
            //Arrange
            Less20 ops = new Less20();

            //Act
            bool result = ops.IsLessThanMultipleOf20(400);

            //Assert
            Assert.IsTrue(result, "cannot be mutiple of 20");

        }
        [TestMethod]

        public void ShouldReturnFalseifGiven0()
        {
            //Arrange
            Less20 ops = new Less20();
            
            //Act
            bool result = ops.IsLessThanMultipleOf20(0);

            //Assert
            Assert.IsTrue(result, "0 is not a multiple of 20");

        }

        [TestMethod]

        public void ReturnTrueIf1LessThanMultipleOf20()
        {
            //Arrange
            Less20 ops = new Less20();

            //Act
            bool result = ops.IsLessThanMultipleOf20(599);

            //Assert
            Assert.IsTrue(result, "number is mutiple of 20");

        }




    }
}
