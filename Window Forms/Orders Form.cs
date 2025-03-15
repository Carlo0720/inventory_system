using inventory_system.Window_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class Orders_Form : UserControl
    {
        public Orders_Form()
        {
            InitializeComponent();
            ordersAddPanel.Visible = false;
        }



        private void Orders_Form_Load(object sender, EventArgs e)
        {
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }

        private void Order_search_Click(object sender, EventArgs e)
        {

        }

        private void Orders_add_Click(object sender, EventArgs e)
        {
            OrdersAddForm ordersAF = new OrdersAddForm();
            ordersAF.Dock = DockStyle.Fill;
            ordersAddPanel.Controls.Add(ordersAF);
            ordersAddPanel.Visible = true;
            
        }
    }
}
