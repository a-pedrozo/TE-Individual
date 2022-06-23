using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class ProjectSqlDao : IProjectDao
    {
        private readonly string connectionString;

        public ProjectSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Project GetProject(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql_query = "SELECT p.project_id, p.name, p.from_date, p.to_date FROM project p WHERE project_id = @id";   
                SqlCommand command = new SqlCommand(sql_query, conn);
                command.Parameters.AddWithValue("id", projectId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {
                    string name = Convert.ToString(reader["name"]);
                    int id = Convert.ToInt32(reader["project_id"]);
                    DateTime start = Convert.ToDateTime(reader["from_date"]);
                    DateTime end = Convert.ToDateTime(reader["to_date"]);


                    Project project = new Project();
                    project.ProjectId = id;
                    project.Name = name;
                    project.FromDate = start;
                    project.ToDate = end;


                    return project;

                }
                else
                {
                    return null;
                }

            }
        }

        public IList<Project> GetAllProjects()
        {
            List<Project> results = new List<Project>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = "SELECT p.project_id, p.name, p.from_date, p.to_date FROM project p ORDER BY p.name";
                SqlCommand command = new SqlCommand(query, conn);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {
                    string name = Convert.ToString(reader["name"]);
                    int id = Convert.ToInt32(reader["project_id"]);
                    DateTime start = Convert.ToDateTime(reader["from_date"]);
                    DateTime end = Convert.ToDateTime(reader["to_date"]);


                    Project project = new Project();
                    project.ProjectId = id;
                    project.Name = name;
                    project.FromDate = start;
                    project.ToDate = end;


                    results.Add(project);

                }
                return results;

            }
        }

        public Project CreateProject(Project newProject)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO project (name, from_date, to_date) VALUES (@name, @fromDate, @toDate); SELECT @@IDENTITY;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("name", newProject.Name);
                command.Parameters.AddWithValue("fromDate", newProject.FromDate);
                command.Parameters.AddWithValue("toDate", newProject.ToDate);

                int id = Convert.ToInt32(command.ExecuteScalar());

                
                newProject.ProjectId = id;

            }
            return newProject;
        }

        public void DeleteProject(int projectId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM project_employee WHERE project_id = @project_id; DELETE FROM project WHERE project_id = @project_id;";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("project_id", projectId);

                int rowsAffected = command.ExecuteNonQuery();

               
            }

        }

    }
}
