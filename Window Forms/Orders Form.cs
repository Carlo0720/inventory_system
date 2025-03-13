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
            this.BackColor = Color.Red;
        }

     

        private void Orders_Form_Load(object sender, EventArgs e)
        {
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
        }
    }
}
