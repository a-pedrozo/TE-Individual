using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Data.SqlClient;
using WorldGeography.DAL;
using WorldGeography.Models;
using WorldGeography.Tests.DAL;

namespace WorldGeography.Tests
{
    [TestClass]
    public class CitySqlDAOTests : WorldDAOTestsBase
    {
        [TestMethod]
        [DataRow("USA", 1)]
        [DataRow("FRA", 0)]
        public void GetCitiesByCountryCode_Should_ReturnRightNumberOfCities(string countryCode, int expectedCityCount)
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);

            // Act
            List<City> cities = dao.GetCitiesByCountryCode(countryCode);
            // Assert
            Assert.IsNotNull(cities);
            Assert.AreEqual(expectedCityCount, cities.Count);
        }

        [TestMethod]
        public void AddCity_Should_IncreaseCountBy1()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            City city = new City();
            city.Name = "treatsure island";
            city.District = "East Blue";
            city.CountryCode = "USA";
            city.Population = 9;
            // Act
            int cityId = dao.AddCity(city);
            // Assert
            Assert.IsTrue(cityId > 0); // checking for valid id 
            int cityRows = GetRowCount("city");
            Assert.AreEqual(2, cityRows); // checking that amout of cities incrimented 
        }

        [TestMethod]
        [ExpectedException(typeof(SqlException))]
        public void AddCity_Should_Fail_IfCountryDoesNotExist()
        {
            // Arrange
            CitySqlDAO dao = new CitySqlDAO(ConnectionString);
            City city = new City();
            city.Name = "treatsure island";
            city.District = "East Blue";
            city.CountryCode = "NAR"; // NAR does not exist in thsi country, so a FK contraint should be violated
            city.Population = 18;
            // Act
            dao.AddCity(city);
            // Assert
            Assert.Fail("Expected a SQL Exception to be thrown before this line was reached");
        }
    }
}
