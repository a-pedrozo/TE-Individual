using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class DepartmentSqlDao : IDepartmentDao
    {
        private readonly string connectionString;

        public DepartmentSqlDao(string connString)
        {
            connectionString = connString;
        }

        public Department GetDepartment(int departmentId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql_query = "SELECT d.department_id, d.name FROM department d WHERE d.department_id = @id"; 
                SqlCommand command = new SqlCommand(sql_query, conn);
                command.Parameters.AddWithValue("id", departmentId);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {
                    string name = Convert.ToString(reader["name"]);
                    int id = Convert.ToInt32(reader["department_id"]);


                    Department department = new Department();
                    department.DepartmentId = id;
                    department.Name = name;


                    return department;

                }
                else
                {
                    return null;
                }

            }

        }

        public IList<Department> GetAllDepartments()
        {
            List<Department> results = new List<Department>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = "SELECT d.department_id, d.name FROM department d ORDER BY d.name";
                SqlCommand command = new SqlCommand(query, conn);


                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())

                {
                    string name = Convert.ToString(reader["name"]);
                    int id = Convert.ToInt32(reader["department_id"]);

                    Department department = new Department();
                    department.DepartmentId = id;
                    department.Name = name;


                    results.Add(department);

                }
                return results;

            }
        }

        public void UpdateDepartment(Department updatedDepartment)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "UPDATE department SET name = @name WHERE department_id = @id ";
                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("name", updatedDepartment.Name);
                command.Parameters.AddWithValue("id", updatedDepartment.DepartmentId);


                command.ExecuteNonQuery();

            }





        }
    }
}
