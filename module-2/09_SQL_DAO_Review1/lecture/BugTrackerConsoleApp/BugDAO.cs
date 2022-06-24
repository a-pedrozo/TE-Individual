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
            throw new NotImplementedException();
        }

        public bool CloseBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public bool DeleteBug(int bugId)
        {
            throw new NotImplementedException();
        }

        public List<Bug> GetAllBugs()
        {
            throw new NotImplementedException();
        }
    }
}
