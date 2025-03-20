using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.UserControls.Order.Model
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ItemName { get; set; }
        public string ItemCode { get; set; }
        public string ItemDescription { get; set; }
        public string ItemColor { get; set; }
        public string ItemCategory { get; set; }
        public string Supplier { get; set; }
        public int Stock { get; set; }
        public int Quantity { get; set; }
        public string Length { get; set; }
        public string Unit { get; set; }
        public decimal ItemPrice { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
