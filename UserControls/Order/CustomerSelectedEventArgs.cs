using inventory_system.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.UserControls.Order
{
    public class CustomerSelectedEventArgs : EventArgs
    {
        public Customer customer { get; set; }
    }
}
