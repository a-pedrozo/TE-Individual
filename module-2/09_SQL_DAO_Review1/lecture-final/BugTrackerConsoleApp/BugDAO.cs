using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace BugTrackerConsoleApp
{
    public class BugDAO : IBugManager
    {
        private string connectionString;

        public BugDAO(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public Bug AddBug(Bug newBug)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO Bugs (summary, assignedTo, isOpen) " +
                    "VALUES (@summary, @assignedTo, @isOpen); " +
                    "SELECT @@IDENTITY;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@summary", newBug.Summary);
                command.Parameters.AddWithValue("@assignedTo", newBug.ResponsibleDev);
                command.Parameters.AddWithValue("@isOpen", newBug.IsOpen);

                int id = Convert.ToInt32(command.ExecuteScalar());

                newBug.Id = id;
                return newBug;
            }
        }

        public bool CloseBug(int bugId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "UPDATE Bugs SET isOpen = 0 WHERE id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", bugId);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public bool DeleteBug(int bugId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM Bugs WHERE id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", bugId);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        public List<Bug> GetAllBugs()
        {
            List<Bug> bugs = new List<Bug>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "SELECT id, summary, assignedTo, isOpen FROM Bugs;";

                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Bug bug = new Bug();
                    bug.Id = Convert.ToInt32(reader["id"]);
                    bug.IsOpen = Convert.ToBoolean(reader["isOpen"]);
                    bug.ResponsibleDev = Convert.ToString(reader["assignedTo"]);
                    bug.Summary = Convert.ToString(reader["summary"]);

                    bugs.Add(bug);
                }
            }

            return bugs;
        }
    }
}
