using System;
using System.Collections.Generic;
using System.Text;

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
