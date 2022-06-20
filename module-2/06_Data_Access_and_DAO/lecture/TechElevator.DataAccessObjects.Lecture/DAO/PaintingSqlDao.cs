using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using TechElevator.DataAccess.Models;

namespace TechElevator.DataAccess.DAO
{
    public class PaintingSqlDao : IPaintingDao
    {
        private string connectionString;

        public PaintingSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Painting AddPainting(Painting newPainting)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO painting (painting_title, artist_id) VALUES (@title, @artistId); SELECT @@IDENTITY";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("title", newPainting.Title); // translating @title to readable c# code 
                command.Parameters.AddWithValue("artistId", newPainting.ArtistId); // translating database from @artistId to readable c# code

                // run the query, insert the data, and return the ID of the inserted row
                int id = Convert.ToInt32(command.ExecuteScalar());

               //we now know the ID of the painting in the database
               // store it in the object so people calling our code know the ID of that row (the painting ID)
                newPainting.Id = id;

            }
                return newPainting;
        }

        public bool DeletePaintingById(int id)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
            
                string sql = "DELETE FROM painting WHERE painting_id = @id";
               
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("id", id);

                int rowsAffected = command.ExecuteNonQuery(); // not selecting data since it's deleting data, purpose of ExcecuteNonQuery is for anything other than not returning data

                if(rowsAffected > 0)
                {
                    return true;
                }
            }

            return false;
        }

        public IList<Painting> GetAll()
        {
            List<Painting> results = new List<Painting>();

            using (SqlConnection conn = new SqlConnection(connectionString)) // establishes new connection to database
            {
                conn.Open(); // method that opens connection to database

                // select data from the database for this painting
                string query = "SELECT p.artist_id, p.painting_id, p.painting_title FROM painting p ORDER BY p.painting_title"; // query that will be ran
                SqlCommand command = new SqlCommand(query, conn); // using connectiont to execute command
               
                // read the painting from the database
                SqlDataReader reader = command.ExecuteReader(); // runs the query and returns a reader

                while (reader.Read()) // move to first row, if one is present. will only be true if a row was returned 

                {   // reading columbs form the current row
                    string title = Convert.ToString(reader["painting_title"]);  //must use Convert method to transfer data from database to c#
                    int id = Convert.ToInt32(reader["painting_id"]);
                    int artistId = Convert.ToInt32(reader["artist_id"]);

                    // Populating a paitning from this row of data
                    Painting painting = new Painting(); // instanciating instance of painting
                    painting.ArtistId = artistId;
                    painting.Id = id;
                    painting.Title = title;

                    results.Add(painting);

                }
                return null;

            }
        }

        public Painting GetPaintingById(int paintingId)
        {
            //connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString)) // establishes new connection to database
            {
                conn.Open(); // method that opens connection to database
                            
                // select data from the database for this painting
                string query = "SELECT p.artist_id, p.painting_id, p.painting_title FROM painting p WHERE p.painting_id = @id"; // query that will be ran
                SqlCommand command = new SqlCommand(query, conn); // using connectiont to execute command
                command.Parameters.AddWithValue("id", paintingId); // replacing @id with paintingId , words inside @ must match with words in AddWithValue

                // read the painting from the database
                SqlDataReader reader = command.ExecuteReader(); // runs the query and returns a reader

                if (reader.Read()) // move to first row, if one is present. will only be true if a row was returned 

                {   // reading columbs form the current row
                    string title = Convert.ToString(reader["painting_title"]);  //must use Convert method to transfer data from database to c#
                    int id = Convert.ToInt32(reader["painting_id"]);
                    int artistId = Convert.ToInt32(reader["artist_id"]);

                    // Populating a paitning from this row of data
                    Painting painting = new Painting(); // instanciating instance of painting
                    painting.ArtistId = artistId;
                    painting.Id = id;
                    painting.Title = title;

                     //return the painting
                    return painting;

                }
                else
                {
                    return null;
                }

            } 

            
        }

        public Painting UpdatePainting(Painting painting)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "UPDATE painting SET painting_title = @title, artist_id = @artistId WHERE painting_id = @paintingId";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("title", painting.Title);
                command.Parameters.AddWithValue("artistId", painting.ArtistId);
                command.Parameters.AddWithValue("paintingId", painting.Id);

                command.ExecuteNonQuery();

            }

            return painting;
        }
    }
}
