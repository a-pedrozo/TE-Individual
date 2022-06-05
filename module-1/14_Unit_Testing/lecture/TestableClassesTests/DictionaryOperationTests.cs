using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestableClasses;

namespace TestableClassesTests
{
    [TestClass]
    public class DictionaryOperationTests
    {
        [TestMethod]

        public void GetWordLengthShouldReturnCorrectDictionary()
        {
            //Arrange
            DictionaryOperations ops = new DictionaryOperations();
            string[] input = new string[] { "potato", "tomato", "tired" };

            //Act
            Dictionary<string, int> result = ops.GetWordLengths(input);

            //Assert
            Assert.IsNotNull(result);
            Assert.IsTrue(result.ContainsKey("potato"));
            Assert.AreEqual(6, result["potato"]);
            Assert.AreEqual(input.Length, result.Count);
        }



    }
}
