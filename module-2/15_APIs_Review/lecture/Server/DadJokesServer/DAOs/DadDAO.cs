using DadJokesServer.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DadJokesServer.DAOs
{
    public class DadDAO : IDadDAO
    {
        private readonly string connStr;

        public DadDAO(string connStr)
        {
            this.connStr = connStr;
        }

        public List<Dad> GetDads()
        {
            List<Dad> dads = new List<Dad>();

            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "SELECT d.id, d.name FROM Dads d ORDER BY d.name";

                SqlCommand command = new SqlCommand(sql, conn);

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Dad dad = GetDadFromDataReader(reader);

                    dads.Add(dad);
                }
            }

            return dads;
        }

        public Dad GetDadById(int dadId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "SELECT TOP 1 d.id, d.name FROM Dads d WHERE d.id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", dadId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return GetDadFromDataReader(reader);
                }
            }

            return null;
        }

        public Dad GetDadByName(string name)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "SELECT TOP 1 d.id, d.name FROM Dads d WHERE d.name = @name";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@name", name);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    return GetDadFromDataReader(reader);
                }
            }

            return null;
        }

        public Dad InsertDad(string dadName)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "INSERT INTO dads (name) VALUES (@name); SELECT @@IDENTITY;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@name", dadName);

                int id = Convert.ToInt32(command.ExecuteScalar());

                return new Dad(id, dadName);
            }
        }

        public Dad UpdateDad(Dad dad)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                const string sql = "UPDATE dads SET name = @name WHERE id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@name", dad.Name);
                command.Parameters.AddWithValue("@id", dad.Id);

                command.ExecuteNonQuery();
            }

            return GetDadById(dad.Id);
        }

        public bool DeleteDad(int dadId)
        {
            using (SqlConnection conn = new SqlConnection(connStr))
            {
                conn.Open();

                // First set jokes relying on this dad to have a NULL FK value, then delete the dad.
                const string sql = "UPDATE jokes SET dad_id = NULL WHERE dad_id = @id; " +
                    "DELETE FROM dads WHERE id = @id";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("@id", dadId);

                int rowsAffected = command.ExecuteNonQuery();

                return rowsAffected > 0;
            }
        }

        private Dad GetDadFromDataReader(SqlDataReader reader)
        {
            int id = Convert.ToInt32(reader["id"]);
            string name = Convert.ToString(reader["name"]);

            return new Dad(id, name);
        }
    }
}
