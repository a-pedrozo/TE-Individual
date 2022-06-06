using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
   public class Lucky13Test
    {
        [TestMethod]

        public void ReturnFalseIfHas1()
        {
            //Arrange
            Lucky13 aops = new Lucky13(); 
            int[] input = new int[] { 1, 2, 5, 5 };

            //Act
            bool result = aops.GetLucky(input);

            //Assert
            Assert.IsTrue(result, "contains 1");
        }

        [TestMethod]

        public void ReturnFalseIFHas3()
        {
            //Arrange
            Lucky13 aops = new Lucky13();
            int[] input = new int[] { 0, 2, 3, 5 };

            //Act
            bool result = aops.GetLucky(input);

            //Assert
            Assert.IsTrue(result, "contains 3");
        }

        [TestMethod]

        public void ReturnTrueIfNo1Or3()
        {
            //Arrange
            Lucky13 aops = new Lucky13();
            int[] input = new int[] { 0, 2, 4};

            //Act
            bool result = aops.GetLucky(input);

            //Assert
            Assert.IsTrue(result, "should not contain 1 or 3");
        }

    }
}
