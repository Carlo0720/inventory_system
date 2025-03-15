using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Window_Forms
{
    public partial class OrdersAddForm : UserControl
    {
        public OrdersAddForm()
        {
            InitializeComponent();
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_ordrs_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Visible = false;
            }
        }
    }


}

