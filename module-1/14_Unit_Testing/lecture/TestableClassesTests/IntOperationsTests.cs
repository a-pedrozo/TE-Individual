using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses; // put inside namespace to corrispond to intOperations 
namespace TestableClassesTests
{
    [TestClass]
    public class IntOperationsTests
    {
        [TestMethod] // this is an atribute, must be put above every method for testing 
        public void IsOdd_OddNumbersShouldReturnTrue() // method of the testing class
        {
            // Arrange - setting up things to test
            IntOperations ops = new IntOperations();

            // Act - calling methond we're testing 
            bool result = ops.IsOdd(7);

            // Assert - verify method did what we wanted it to 
            Assert.IsTrue(result, "IsOdd should return true for odd numbers");
        }


        [TestMethod] // must put above every testing methdod 
        public void IsOdd_EvenNumberShouldReturnFalse()
        {
            //Arrange
            IntOperations ops = new IntOperations();

            //Act
            bool result = ops.IsOdd(42);

            //Assert
            Assert.IsFalse(result, "IsOdd should return false for odd numbers");

        }

        [TestMethod]

        public void DivisibleNumbersShouldReturnTrue()
        {
            //Arrange

            IntOperations ops = new IntOperations();
            int numerator = 420;
            int divisor = 69;

            //Act

            bool result = ops.AreNumbersDivisible(divisor, numerator);

            //Assert

            Assert.IsFalse(result, "AreNumbersDivisible should return false for divisor going into numerator");
        }

        [TestMethod]

        public void ZeroDivisorShouldReturnFalse()
        {
            //Arrange

            IntOperations ops = new IntOperations();
            int numerator = 420;
            int divisor = 0;
            //Act

            bool result = ops.AreNumbersDivisible(divisor, numerator);

            //Assert

            Assert.IsFalse(result, " method should return false since dividing by 0");
        }

        [TestMethod]

        public void NegativeNumberShouldReturnPositive()
        {
            //Arrange

            IntOperations ops = new IntOperations();
            
            //Act

            int result = ops.MultiplyAbsolute(-5, 10);

            //Assert

            Assert.AreEqual(50, result);
        }

    }
}
