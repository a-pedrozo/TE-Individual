using Capstone.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Capstone.DAO
{
    public class TrolleyDAO : ITrolleyDAO
    {
        private string connectionString;

        public TrolleyDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public TrolleyProblem LoadProblemById(int id)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT tp.id, tp.problem, tp.times_pulled_lever, " +
                    "tp.times_not_pulled FROM trolley_problems tp WHERE tp.id = @id";

                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    TrolleyProblem problem = new TrolleyProblem();
                    problem.Id = Convert.ToInt32(reader["id"]);
                    problem.Problem = Convert.ToString(reader["problem"]);
                    problem.TimesPulled = Convert.ToInt32(reader["times_pulled_lever"]);
                    problem.TimesNotPulled = Convert.ToInt32(reader["times_not_pulled"]);

                    return problem;
                }
            }

            return null;
        }

        public List<TrolleyProblem> LoadAllProblems()
        {
            List<TrolleyProblem> problems = new List<TrolleyProblem>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT tp.id, tp.problem, tp.times_pulled_lever, " +
                    "tp.times_not_pulled FROM trolley_problems tp ORDER BY tp.id";

                SqlCommand command = new SqlCommand(sql, connection);

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    TrolleyProblem problem = new TrolleyProblem();
                    problem.Id = Convert.ToInt32(reader["id"]);
                    problem.Problem = Convert.ToString(reader["problem"]);
                    problem.TimesPulled = Convert.ToInt32(reader["times_pulled_lever"]);
                    problem.TimesNotPulled = Convert.ToInt32(reader["times_not_pulled"]);

                    problems.Add(problem);
                }
            }

            return problems;
        }

        public bool Update(TrolleyProblem problem)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "UPDATE trolley_problems SET times_pulled_lever = @pulled, " +
                    "times_not_pulled = @notPulled WHERE id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@pulled", problem.TimesPulled);
                command.Parameters.AddWithValue("@notPulled", problem.TimesNotPulled);
                command.Parameters.AddWithValue("@id", problem.Id);

                int numRows = command.ExecuteNonQuery();

                return numRows > 0;
            }
        }
    }
}
