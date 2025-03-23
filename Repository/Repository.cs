using inventory_system.common.Interfaces;
using inventory_system.common.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Repository
{
    public class Repository : IRepository
    {
        private DatabaseManager databaseManager;
        public void Create(string query)
        {
            throw new NotImplementedException();
        }

        public void Delete(string query)
        {
            throw new NotImplementedException();
        }

        public DataTable Get(string query)
        {
            databaseManager = new DatabaseManager();
            using (databaseManager)
            {
                return databaseManager.ExecuteQueryToDataTable(query);
            }
        }

        public void Update(string query)
        {
            throw new NotImplementedException();
        }
    }
}
