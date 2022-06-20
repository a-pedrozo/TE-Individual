using System;
using System.IO;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using TechElevator.DataAccess.DAO;
using TechElevator.DataAccess.Models;

namespace TechElevator.DataAccess
{
    public class Program
    {
        public static void Main()
        {
            // Load the database connection string from appsettings.json
            string connectionString = GetDatabaseConnectionString("ArtGallery");

            Console.WriteLine("The database connection string is " + connectionString);

            // Part 1: Paintings
            IPaintingDao paintingDao = new PaintingSqlDao(connectionString);
            Painting painting = paintingDao.GetPaintingById(300);
            IList<Painting> allPaintings = paintingDao.GetAll();
            paintingDao.DeletePaintingById(2);

            Painting myPainting = new Painting();
            myPainting.Title = "C# Keystrokes in Flight";
            myPainting.ArtistId = 3;
            paintingDao.AddPainting(myPainting);

            Console.WriteLine("The new painting's ID is " + myPainting.Id);

            myPainting.Title = "A man staring at a group of students";

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
