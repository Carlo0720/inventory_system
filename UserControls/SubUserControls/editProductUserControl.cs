using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Globals;

namespace inventory_system.UserControls.SubUserControls
{
    public partial class editProductUserControl : UserControl
    {
        public editProductUserControl(string productId)
        {
            InitializeComponent();
        }

        private void edit_product_btn_Click(object sender, EventArgs e)
        {

        }

        private void add_product_close_btn_Click(object sender, EventArgs e)
        {
            Function.HideParentPanel(this);
        }
    }
}
