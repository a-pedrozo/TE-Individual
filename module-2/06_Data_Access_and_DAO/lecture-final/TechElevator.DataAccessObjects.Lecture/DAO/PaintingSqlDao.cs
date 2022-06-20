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

                string sql = "INSERT INTO painting (painting_title, artist_id) VALUES (@title, @artistId); SELECT @@IDENTITY;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("title", newPainting.Title);
                command.Parameters.AddWithValue("artistId", newPainting.ArtistId);

                // Run the query, insert the data, and return the ID of the inserted row
                int id = Convert.ToInt32(command.ExecuteScalar());

                // We now know the ID of the painting in the database.
                // Store it in the object so people calling our code know the ID of that row (the painting ID)
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

                int rowsAffected = command.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    return true;
                }
            }
            return false;
        }

        public IList<Painting> GetAll()
        {
            List<Painting> results = new List<Painting>();

            // Connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Select data from the database for this painting
                string query = "SELECT p.artist_id, p.painting_id, p.painting_title FROM painting p ORDER BY p.painting_title";
                SqlCommand command = new SqlCommand(query, conn);

                // Read the painting from the database
                SqlDataReader reader = command.ExecuteReader(); // Runs the query and returns a reader

                while (reader.Read()) // Move to the first row, if one is present. Will only be true if a row was returned
                {
                    // Reading the columns from the current row
                    string title = Convert.ToString(reader["painting_title"]);
                    int id = Convert.ToInt32(reader["painting_id"]);
                    int artistId = Convert.ToInt32(reader["artist_id"]);

                    // Populate a painting from this row of data
                    Painting painting = new Painting();
                    painting.ArtistId = artistId;
                    painting.Id = id;
                    painting.Title = title;

                    results.Add(painting);
                }
            }

            return results;
        }

        public Painting GetPaintingById(int paintingId)
        {
            // Connect to the database
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Select data from the database for this painting
                string query = "SELECT p.artist_id, p.painting_id, p.painting_title FROM painting p WHERE p.painting_id = @id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("id", paintingId);

                // Read the painting from the database
                SqlDataReader reader = command.ExecuteReader(); // Runs the query and returns a reader

                if (reader.Read()) // Move to the first row, if one is present. Will only be true if a row was returned
                {
                    // Reading the columns from the current row
                    string title = Convert.ToString(reader["painting_title"]);
                    int id = Convert.ToInt32(reader["painting_id"]);
                    int artistId = Convert.ToInt32(reader["artist_id"]);

                    // Populate a painting from this row of data
                    Painting painting = new Painting();
                    painting.ArtistId = artistId;
                    painting.Id = id;
                    painting.Title = title;

                    // Return the painting
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
