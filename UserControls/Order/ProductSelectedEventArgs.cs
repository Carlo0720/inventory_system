using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.UserControls.Order
{
    public class ProductSelectedEventArgs : EventArgs
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public int ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemColor { get; set; }
        public string ItemCategory { get; set; }
        public string Supplier { get; set; }
        public int Stock { get; set; }
        public string Unit { get; set; }
        public double ItemPrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
