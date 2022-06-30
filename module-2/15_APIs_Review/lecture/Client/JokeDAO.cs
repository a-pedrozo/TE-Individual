using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace DadabaseApp
{
    public class JokeDAO
    {
        private const string GetAllJokesSQL = "SELECT j.date_added, j.id, j.punchline, j.setup, j.dad_id, d.name AS 'DadName' " +
            "FROM Jokes j LEFT OUTER JOIN Dads d ON d.id = j.dad_id ORDER BY date_added";
        private const string InsertJokeSQL = "INSERT INTO Jokes (setup, punchline) " +
            "VALUES (@setup, @punchline); SELECT @@IDENTITY";

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
                command.Parameters.AddWithValue("@setup", newJoke.Setup);
                command.Parameters.AddWithValue("@punchline", newJoke.Punchline);

                int id = Convert.ToInt32(command.ExecuteScalar());
                return id;
            }
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
                    string dadName = Convert.ToString(reader["DadName"]);
                    
                    object dad_id_obj = reader["dad_id"];

                    int dadId;
                    if (dad_id_obj == DBNull.Value)
                    {
                        dadId = -1;
                    }
                    else
                    {
                        dadId = Convert.ToInt32(dad_id_obj);
                    }

                    Joke unfunnyJoke = new Joke();
                    unfunnyJoke.DateAdded = created;
                    unfunnyJoke.Id = id;
                    unfunnyJoke.Setup = setup;
                    unfunnyJoke.Punchline = punchline;
                    unfunnyJoke.DadId = dadId;
                    unfunnyJoke.DadName = dadName;

                    jokes.Add(unfunnyJoke);
                }
            }

            /*
            Joke myJoke = new Joke();
            myJoke.Setup = "Why did the chicken cross the road?";
            myJoke.Punchline = "Polymorphism";
            jokes.Add(myJoke);
            */

            return jokes;
        }
    }
}
