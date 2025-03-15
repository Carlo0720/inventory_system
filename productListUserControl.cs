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
    public partial class productListUserControl : UserControl
    {
        public productListUserControl()
        {
            InitializeComponent();
        }

        private void productListUserControl_Load(object sender, EventArgs e)
        {
            productsDataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in productsDataGrid.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.Gray;
                column.HeaderCell.Style.ForeColor = Color.White;
            }
        }
    }
}
