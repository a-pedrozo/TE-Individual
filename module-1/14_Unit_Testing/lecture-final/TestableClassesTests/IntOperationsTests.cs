using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class IntOperationsTests
    {
        [TestMethod]
        public void IsOdd_OddNumbersShouldReturnTrue()
        {
            // Arrange - setting up the things to test
            IntOperations ops = new IntOperations();

            // Act - calling the method we're testing
            bool result = ops.IsOdd(7);

            // Assert - verify the method did what we wanted
            Assert.IsTrue(result, "IsOdd should return true for odd numbers");
        }

        [TestMethod]
        public void IsOdd_EvenNumbersShouldReturnFalse()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            bool result = ops.IsOdd(42);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void DivisibleNumbersShouldReturnTrue()
        {
            // Arrange
            IntOperations ops = new IntOperations();
            int numerator = 10;
            int divisor = 5;

            // Act
            bool result = ops.AreNumbersDivisible(divisor, numerator);

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void NonDivisibleNumbersShouldReturnFalse()
        {
            // Arrange
            IntOperations ops = new IntOperations();
            int numerator = 41;
            int divisor = 309;

            // Act
            bool result = ops.AreNumbersDivisible(divisor, numerator);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void ZeroDivisorsShouldReturnFalse()
        {
            // Arrange
            IntOperations ops = new IntOperations();
            int numerator = 41;
            int divisor = 0;

            // Act
            bool result = ops.AreNumbersDivisible(divisor, numerator);

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void MultiplyingNegativeAndPositiveShouldBePositive()
        {
            // Arrange
            IntOperations ops = new IntOperations();

            // Act
            int result = ops.MultiplyAbsolute(-6, 12);

            // Assert
            Assert.AreEqual(72, result);
        }

    }
}
