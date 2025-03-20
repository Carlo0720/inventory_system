using inventory_system.UserControls.Order.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.UserControls.Order
{
    public class ProductSelectedEventArgs : EventArgs
    {
        public Product product { get; set; }
    }
}
