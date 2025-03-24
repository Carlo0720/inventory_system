using inventory_system.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Interfaces
{
    public interface IOrderRepository : IRepository
    {
        public int GetItemCount();
        public Task CreateOrder(int order_id,
            int customer_id,
            int po_number,
            int dr_number,
            double total_price,
            List<OrderItems> orderItems);
    }
}
