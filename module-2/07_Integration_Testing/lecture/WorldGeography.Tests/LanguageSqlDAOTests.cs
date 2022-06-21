using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class LanguageSqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("XYZ", 0)]
        public void GetLanguagesTest(string countryCode, int expectedCount)
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);

            // Act
            List<Language> languages = dao.GetLanguages(countryCode);
            // Assert
            Assert.AreEqual(expectedCount, languages.Count);
        }

        [TestMethod]
        public void AddLanguage()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language();
            language.Name = "java";
            language.IsOfficial = false;
            language.Percentage = 10;
            language.CountryCode = "USA"; // there is an FK relationship to country, only way for test to run properly 
            // Act
           bool added = dao.AddNewLanguage(language);
            // Assert
            Assert.IsTrue(added);
            int languages = GetRowCount("countryLanguage");
            Assert.AreEqual(2, languages); // checks if language was added
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            //Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language();
            language.Name = "C#";
            language.IsOfficial = false;
            language.Percentage = 10;
            language.CountryCode = "USA"; // there is an FK relationship to country, only way for test to run properly 
            //Act                             
            dao.AddNewLanguage(language);
            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }

        [TestMethod]
        public void RemoveLanguage()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language();
            language.CountryCode = "USA";
            language.IsOfficial = true;
            language.Name = "C#";
            language.Percentage = 100;


            // Act
           bool removed = dao.RemoveLanguage(language);

            // Assert
            Assert.IsTrue(removed);
        }
    }
}
