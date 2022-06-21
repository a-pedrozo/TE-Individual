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
            language.Name = "Java";
            language.IsOfficial = false;
            language.Percentage = 10;
            language.CountryCode = "USA"; // This is the only country I have, and there's a FK relation to Country

            // Act
            bool added = dao.AddNewLanguage(language);

            // Assert
            Assert.IsTrue(added);
            int languages = GetRowCount("countrylanguage");
            Assert.AreEqual(2, languages); // Did it actually add the language?
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddLanguage_FailsBecauseLanguageExists()
        {
            // Arrange
            LanguageSqlDAO dao = new LanguageSqlDAO(ConnectionString);
            Language language = new Language();
            language.Name = "C#";
            language.IsOfficial = true;
            language.Percentage = 100;
            language.CountryCode = "USA"; // This is the only country I have, and there's a FK relation to Country

            // Act
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
            int languages = GetRowCount("countrylanguage");
            Assert.AreEqual(0, languages);
        }
    }
}
