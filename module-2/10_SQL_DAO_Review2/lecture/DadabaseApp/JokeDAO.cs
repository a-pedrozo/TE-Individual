using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

 namespace DadabaseApp
{
    public class JokeDAO
    {
        private const string GetAllJokesSQL = "SELECT j.date_added, j.id, j.punchline, j.setup FROM Jokes j Order by date_added";
        private const string InsertJokeSQL = "INSERT INTO Jokes (setup, punchline) Values (@setup, @punchline); SELECT @@IDENTITY"; // SELECT @@IDENTITY uses for executeScaler methods
        private string connectionString;
        public JokeDAO(string connStr)
        {
            this.connectionString = connStr;
        }

        public int AddJoke(Joke newJoke)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                SqlCommand command = new SqlCommand(InsertJokeSQL, conn);
                command.Parameters.AddWithValue("@setup", newJoke.SetUp);
                command.Parameters.AddWithValue("@punchline", newJoke.PunchLine);


                int id = Convert.ToInt32(command.ExecuteScalar()); // converts object to int 

            }
            return newJoke.Id;
        }
        public List<Joke> GetAllDadJokes()
        {
            List<Joke> jokes = new List<Joke>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand(GetAllJokesSQL, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    string punchline = Convert.ToString(reader["punchline"]);
                    string setup = Convert.ToString(reader["setup"]);
                    int id = Convert.ToInt32(reader["id"]);
                    DateTime created = Convert.ToDateTime(reader["date_added"]);
                    string dadName;
                    int dadId;

                    Joke unfunnyJoke = new Joke();
                    unfunnyJoke.DateAdded = created;
                    unfunnyJoke.Id = id;
                    unfunnyJoke.SetUp = setup;
                    unfunnyJoke.PunchLine = punchline;
                    
                    jokes.Add(unfunnyJoke);
                }
            }

            return jokes;
        }
    }
}
