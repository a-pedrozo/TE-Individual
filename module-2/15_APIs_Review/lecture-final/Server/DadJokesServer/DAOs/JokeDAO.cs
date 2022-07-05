using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using DadJokesServer.Models;

namespace DadJokesServer.DAOs
{
    public class JokeDAO : IJokeDAO
    {
        private readonly string connectionString;

        public JokeDAO(string connStr)
        {
            this.connectionString = connStr;
        }

        public Joke AddJoke(Joke newJoke)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                const string sql = "INSERT INTO Jokes (setup, punchline) " +
                    "VALUES (@setup, @punchline); SELECT @@IDENTITY";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@setup", newJoke.Setup);
                command.Parameters.AddWithValue("@punchline", newJoke.Punchline);

                int id = Convert.ToInt32(command.ExecuteScalar());

                newJoke.Id = id;

                return newJoke;
            }
        }

        public Joke GetJokeById(int id)
        {
            const string sql = "SELECT TOP 1 j.date_added, j.id, j.punchline, j.setup, d.name AS 'DadName' " +
                "FROM Jokes j LEFT OUTER JOIN Dads d ON d.id = j.dad_id WHERE j.id = @id";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return GetJokeFromDataReader(reader);
                }
            }

            return null;
        }

        public bool DeleteJoke(int id)
        {
            const string sql = "DELETE FROM Jokes WHERE id = @id;";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", id);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public Joke UpdateJoke(Joke joke)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                const string sql = "UPDATE Jokes SET setup = @setup, punchline = @punchline WHERE id = @id;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@setup", joke.Setup);
                command.Parameters.AddWithValue("@punchline", joke.Punchline);
                command.Parameters.AddWithValue("@id", joke.Id);

                command.ExecuteNonQuery();
            }

            return GetJokeById(joke.Id);
        }

        public List<Joke> GetAllDadJokes()
        {
            List<Joke> jokes = new List<Joke>();

            const string sql = "SELECT j.date_added, j.id, j.punchline, j.setup, d.name AS 'DadName' " +
                "FROM Jokes j LEFT OUTER JOIN Dads d ON d.id = j.dad_id ORDER BY date_added";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Joke joke = GetJokeFromDataReader(reader);

                    jokes.Add(joke);
                }
            }

            return jokes;
        }

        private Joke GetJokeFromDataReader(SqlDataReader reader)
        {
            string punchline = Convert.ToString(reader["punchline"]);
            string setup = Convert.ToString(reader["setup"]);
            int id = Convert.ToInt32(reader["id"]);
            DateTime created = Convert.ToDateTime(reader["date_added"]);
            string dadName = Convert.ToString(reader["DadName"]);

            Joke joke = new Joke();
            joke.DateAdded = created;
            joke.Id = id;
            joke.Setup = setup;
            joke.Punchline = punchline;
            joke.DadName = dadName;

            return joke;
        }
    }
}
