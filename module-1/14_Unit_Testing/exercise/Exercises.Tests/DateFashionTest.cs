using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
   public  class DateFashionTest
    {
        [TestMethod]

        public void ShoudldNotGetTableifOneIsTwoOrLess()
        {
            //Arrange
            DateFashion ops = new DateFashion();
            

            //Act
            int result = ops.GetATable(2, 8);

            //Assert
            Assert.AreEqual(2,result, "style with 2 or less will not get a table");
        }

        [TestMethod]

        public void ShouldGetTableIfOneIsVeryStylishandOtherIsStylish()
        {
            //Arrange
            DateFashion ops = new DateFashion();
            

            //Act
            int result = ops.GetATable(3, 8);

            //Assert
            Assert.AreEqual(2, result);
        }

        [TestMethod]

        public void ShouldMaybeGetTableIfBothAreStylish()
        {
            //Arrange
            DateFashion ops = new DateFashion();


            //Act
            int result = ops.GetATable(3, 3);

            //Assert
            Assert.AreEqual(1, result);
        }
    }
}
