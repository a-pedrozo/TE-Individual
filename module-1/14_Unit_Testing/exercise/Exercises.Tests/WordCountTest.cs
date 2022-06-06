using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercises;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]

        public void ShouldReturnCorrectDictionary()
        {
            //Arrange
            WordCount ops = new WordCount();
            string[] input = new string[] {"ja", "ja", "bool", "rule" };

            //Act
            Dictionary<string, int> result = ops.GetCount(input);

            //Assert
            Assert.IsNotNull(result);
            Assert.AreEqual("ja 2", result["ja"]);
                
            

        }

        [TestMethod]

        public void TestMethod2()
        {
            //Arrange
            WordCount ops = new WordCount();

            //Act

            //Assert

        }

        [TestMethod]

        public void TestMethod3()
        {
            //Arrange
            WordCount ops = new WordCount();

            //Act

            //Assert

        }
    }
}
