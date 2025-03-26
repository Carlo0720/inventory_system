using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public int PurchaseOrderId { get; set; }
        public int DeliveryReceipt { get; set; }
        public double TotalPrice { get; set; }
        public List<OrderItems>? Items { get; set; }
    }
}
