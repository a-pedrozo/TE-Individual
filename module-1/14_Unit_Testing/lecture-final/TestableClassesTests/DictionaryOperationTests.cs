using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class DictionaryOperationsTests
    {
        [TestMethod]
        public void GetWordLengthsShouldReturnCorrectDictionary()
        {
            // Arrange
            DictionaryOperations ops = new DictionaryOperations();
            string[] input = new string[] { "Potato", "Tomato", "Tired" };

            // Act
            Dictionary<string, int> result = ops.GetWordLengths(input);

            // Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.ContainsKey("Potato"));
            Assert.AreEqual(6, result["Potato"]);
            Assert.AreEqual(input.Length, result.Count);
        }
    }
}
