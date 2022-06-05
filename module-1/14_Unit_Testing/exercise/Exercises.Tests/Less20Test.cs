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

        public void ReturnFalseIfMutipleOf40()
        {
            //Arrange
            Less20 ops = new Less20();

            //Act
            bool result = ops.IsLessThanMultipleOf20(20);

            //Assert
            Assert.IsTrue(result);

        }
        

        
    }
}
