using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
   public  class SameFirstLastTest
    {
        [TestMethod]

        public void ShouldReturnFalseForDifferentFirstLast()
        {
            //Arrange
            SameFirstLast aops = new SameFirstLast();
            int[] input = new int[] { 2, 4, 5, 6, 9 };


            //Act
            bool result = aops.IsItTheSame(input);

            //Assert
            Assert.IsTrue(result,"First number different from Last");
        }

        [TestMethod]

        public void ShouldReturnTrueIfFirstAndLastAreSame()
        {
            //Arrange
            SameFirstLast aops = new SameFirstLast();
            int[] input = new int[] { 2, 4, 5, 6, 2 };


            //Act
            bool result = aops.IsItTheSame(input);

            //Assert
            Assert.IsTrue(result, "First number different from Last");
        }

        [TestMethod]

        public void ShouldReturnFalseForEmptyString()
        {
            //Arrange
            SameFirstLast aops = new SameFirstLast();
            int[] input = new int[] {};


            //Act
            bool result = aops.IsItTheSame(input);

            //Assert
            Assert.IsTrue(result, "Empty String");
        }
    }
}
