using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using TechElevator.DataAccess.DAO;
using TechElevator.DataAccess.Models;
using System.Collections.Generic;

namespace TechElevator.DataAccess
{
    public class Program
    {
        public static void Main()
        {
            // Load the database connection string from appsettings.json
            string connectionString = GetDatabaseConnectionString("ArtGallery"); // method that takes string called connectionstring

            Console.WriteLine("The database connection string is " + connectionString);

            // Part 1: Paintings
            IPaintingDao paintingDao = new PaintingSqlDao(connectionString); // paramater to contructor 
            Painting painting = paintingDao.GetPaintingById(1);
            IList<Painting> allPaintings = paintingDao.GetAll();
            paintingDao.DeletePaintingById(2);

            Painting myPainting = new Painting();
            myPainting.Title = "C# Keystrokes in Flight";
            myPainting.ArtistId = 3;
            paintingDao.AddPainting(myPainting);

            Console.WriteLine("The new painting's ID is " + myPainting.Id);

            myPainting.Title = "staring at a wall of code";
            paintingDao.UpdatePainting(myPainting);

            // Part 2: Purchases
            IPurchaseDao purchaseDao = new PurchaseSqlDao(connectionString);

            // Part 3: People
            IPersonDao personDao = new PersonSqlDao(connectionString);
        }

        private static string GetDatabaseConnectionString(string settingName)
        {
            // Get the connection string from the appsettings.json file
            IConfigurationBuilder builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: false);

            IConfigurationRoot configuration = builder.Build();

            return configuration.GetConnectionString(settingName);
        }
    }
}
