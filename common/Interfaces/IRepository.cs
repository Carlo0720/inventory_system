using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Interfaces
{
    public interface IRepository
    {
        public DataTable Get(string query);
        public DataTable Select(string query, string search, string search2);
        public void Create(string query);
        public void Update(string query);
        public void Delete(string query);
    }
}
