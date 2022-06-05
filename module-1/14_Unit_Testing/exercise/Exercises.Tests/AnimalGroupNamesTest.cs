using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class AnimalGroupNamesTest
    {
        [TestMethod]

        public void NullShouldReturnUknownString()
        {
            //Arrange
            AnimalGroupName ops = new AnimalGroupName();

            //Act
            string result = ops.GetHerd(null);

            //Assert
            Assert.AreEqual("unknown", result);
        }

        [TestMethod]

        public void EmptyStringShouldReturnUnknown()
        {
            //Arrange
            AnimalGroupName ops = new AnimalGroupName();

            //Act
            string result = ops.GetHerd("");

            //Assert
            Assert.AreEqual("unknown", result);
        }

        [TestMethod]

        public void AnimalNameNotOnListShouldReturnUnknown()
        {
            //Arrange
            AnimalGroupName ops = new AnimalGroupName();

            //Act
            string result = ops.GetHerd("cheetah"); 

            //Assert
            Assert.AreEqual("unknown", result);
        }

    }
}
