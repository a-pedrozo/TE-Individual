using EmployeeProjects.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace EmployeeProjects.DAO
{
    public class EmployeeSqlDao : IEmployeeDao
    {
        private readonly string connectionString;

        public EmployeeSqlDao(string connString)
        {
            connectionString = connString;
        }

        public IList<Employee> GetAllEmployees()
        {
            List<Employee> results = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();


                string query = "SELECT e.employee_id, e.last_name, e.first_name, e.birth_date, e.department_id, e.hire_date FROM employee e  ORDER BY employee_id";
                SqlCommand command = new SqlCommand(query, conn);


                SqlDataReader reader = command.ExecuteReader();
                

                while (reader.Read())

                {
                    string firstName = Convert.ToString(reader["first_name"]);
                    string lastName = Convert.ToString(reader["last_name"]);
                    int employeeId = Convert.ToInt32(reader["employee_id"]);
                    int departmentId = Convert.ToInt32(reader["department_id"]);
                    DateTime birthday = Convert.ToDateTime(reader["birth_date"]);
                    DateTime hire = Convert.ToDateTime(reader["hire_date"]);


                    Employee employee = new Employee();
                    employee.LastName = lastName;
                    employee.FirstName = firstName;
                    employee.EmployeeId = employeeId;
                    employee.DepartmentId = departmentId;
                    employee.BirthDate = birthday;
                    employee.HireDate = hire;


                    results.Add(employee);

                }
                return results;

            }
        }

        public IList<Employee> SearchEmployeesByName(string firstNameSearch, string lastNameSearch)
        {
            List<Employee> results = new List<Employee>();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                string sql_query = "SELECT e.first_name, e.last_name FROM employee e WHERE first_name LIKE @first_name OR last_name LIKE @last_name";
                SqlCommand command = new SqlCommand(sql_query, conn);
                command.Parameters.AddWithValue("first_name", firstNameSearch);
                command.Parameters.AddWithValue("last_name", lastNameSearch);


                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())

                {
                    string firstName = Convert.ToString(reader["first_name"]);
                    string lastName = Convert.ToString(reader["last_name"]);
                   


                    Employee employee = new Employee();
                    employee.FirstName = firstName;
                    employee.LastName = lastName;
                    results.Add(employee);

                    return results;

                }
                else
                {
                    return null;
                }

            }
        }
        //"SELECT e.first_name, e.last_name FROM employee e INNER JOIN project_employee pe ON e.employee_id = pe.employee_id WHERE project_id = @project_id";
        public IList<Employee> GetEmployeesByProjectId(int projectId)
        {
            List<Employee> result = new List<Employee>();
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

              
                string query = "SELECT e.first_name, e.last_name FROM employee e INNER JOIN project_employee pe ON e.employee_id = pe.employee_id WHERE project_id = @project_id";
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("project_id", projectId);

                SqlDataReader reader = command.ExecuteReader(); 

                if (reader.Read()) 
                {
                    string lastName = Convert.ToString(reader["e.last_name"]);
                    int id = Convert.ToInt32(reader["project_id"]);
                    string firstName = Convert.ToString(reader["e.first_name"]);

                    Employee employee = new Employee();
                    employee.LastName = lastName; 
                    employee.FirstName = firstName;
                    result.Add(employee);

                
                    return result; 
                }
                else
                {
                    return null;
                }
            }
        }

        public void AddEmployeeToProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "INSERT INTO project_employee (project_id, employee_id) VALUES (@projectId, @employeeId)";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("projectId", projectId);
                command.Parameters.AddWithValue("employeeId", employeeId);

                
                int id = Convert.ToInt32(command.ExecuteScalar());

                

                
              
            }
             
            
        }

        public void RemoveEmployeeFromProject(int projectId, int employeeId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string sql = "DELETE FROM project_employee WHERE employee_id = @employeeId; DELETE FROM employee WHERE employee_id = @employeeId";

                SqlCommand command = new SqlCommand(sql, conn);
                command.Parameters.AddWithValue("employeeId", employeeId);

                int rowsAffected = command.ExecuteNonQuery();

                
            }
           
        }

        public IList<Employee> GetEmployeesWithoutProjects()
        {
            return new List<Employee>();
        }


    }
}
