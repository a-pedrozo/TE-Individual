using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
   public  class StringOperationsTests
    {
        [TestMethod]

        public void CapitalizeShouldOnlyCapitalizeFirstLetter()
        {
            // Arrange 
            StringOperations sus = new StringOperations();

            //Act
            string result = sus.MakeStandardCapitalizationString("SuSibAkA");

            //Assert
            Assert.AreEqual("Susibaka", result);
        }

        [TestMethod]

        public void ShouldReturnBlankString()
        {
            // Arrange 
            StringOperations sus = new StringOperations();

            //Act
            string result = sus.MakeStandardCapitalizationString(null);

            //Assert
            Assert.AreEqual("", result);
            Assert.AreEqual(0, result.Length);
        }


        [TestMethod]
        public void PatioShouldHaveThreeVowels()
        {
            //Arrange
            StringOperations sut = new StringOperations();

            //Act
            int result = sut.CalculateNumberOfVowels("PaTIO");

            //Assert
            Assert.AreEqual(3,result);
        }   
    }
}
