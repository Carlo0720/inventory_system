using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.UserControls.Order
{
    public class ProductDTO
    {
        public int product_id { get; set; }
        public string item_code { get; set; }
        public string description { get; set; }
        public string color { get; set; }
        public int quantity { get; set; }
        public decimal price { get; set; }
    }
}
