using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]

        public void FirstElementGreaterThanLast()
        {
            //Arrange
            MaxEnd3 aops = new MaxEnd3();
            int[] input = new int[] { 12, 2, 8};

            //Act
            int[] result = aops.MakeArray(input);

            //Assert
            Assert.AreEqual(12, result[0]);
        }
        [TestMethod]

        public void LastElementGreaterThanFirst()
        {
            //Arrange
            MaxEnd3 aops = new MaxEnd3();
            int[] input = new int[] { 12, 2, 39};

            //Act
            int[] result = aops.MakeArray(input);

            //Assert
            Assert.AreEqual(39, result[0]);
        }

        [TestMethod]

        public void FirstAndLastAreEqual()
        {
            //Arrange
            MaxEnd3 aops = new MaxEnd3();
            int[] input = new int[] { 12, 2, 12 };

            //Act
            int[] result = aops.MakeArray(input);

            //Assert
            Assert.AreEqual(12, result[0]);
        }



    }
}
