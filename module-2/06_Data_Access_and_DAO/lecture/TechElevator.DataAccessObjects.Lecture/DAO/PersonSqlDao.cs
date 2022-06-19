using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TechElevator.DataAccess.DAO
{
    public class PersonSqlDao : IPersonDao
    {
        private string connectionString;

        public PersonSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
