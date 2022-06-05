using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class CigarPartyTest
    {
        [TestMethod]

        public void CigarPartyShouldReturnFalseIfOver60AndNotWeekend()
        {
            //Arrange
            CigarParty ops = new CigarParty();
            

            //Act
            bool result = ops.HaveParty(80, false);
            //Assert
            Assert.IsTrue(result, "Cigars should be more than 40 and less than 60 on a weekday");
        }

        [TestMethod]

        public void CigarPartyFalseIfLessThan40()
        {
            //Arrange
            CigarParty ops = new CigarParty();
            

            //Act
            bool result = ops.HaveParty(39, false);
            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]

        public void CigarPartyShouldNotHaveMaxOnWeekend()
        {
            //Arrange
            CigarParty ops = new CigarParty();
            

            //Act
            bool result = ops.HaveParty(100, true);
            //Assert
            Assert.IsTrue(result);
        }
    }
}
