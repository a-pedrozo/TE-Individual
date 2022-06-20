using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace TechElevator.DataAccess.DAO
{
    public class PurchaseSqlDao : IPurchaseDao
    {
        private string connectionString;

        public PurchaseSqlDao(string connectionString)
        {
            this.connectionString = connectionString;
        }
    }
}
