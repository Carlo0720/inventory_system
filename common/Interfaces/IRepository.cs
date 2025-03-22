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
        public DataTable GetOrders(string query);
        public void CreateOrder(string query);
        public void UpdateOrder(string query);
        public void DeleteOrder(string query);
    }
}
