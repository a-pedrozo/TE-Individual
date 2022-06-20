using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TechElevator.DataAccess.DAO
{
    public class PaintingSqlDao : IPaintingDao
    {
        private string connectionString;

        public PaintingSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
