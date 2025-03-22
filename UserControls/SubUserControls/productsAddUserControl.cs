using inventory_system.Globals;
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
    public partial class productsAddUserControl : UserControl
    {
        public productsAddUserControl()
        {
            InitializeComponent();
        }

        public event Action AcessoryAdded;

        private void add_product_close_btn_Click(object sender, EventArgs e)
        {
            AcessoryAdded?.Invoke();
            Function.HideParentPanel(this);
        }



        private void add_product_btn_Click(object sender, EventArgs e)
        {

            // Store the text fields in a dictionary
            var fields = new Dictionary<string, string>
            {
                { "Item Name", itemname_txtbox.Text },
                { "Item Code", itemcode_txtbox.Text },
                { "Item Description", itemdesc_txtbox.Text },
                { "Item Color", item_color_txtbox.Text },
                { "Item Category", itemcategory_combobox.Text },
                { "Supplier", supplier_txtbox1.Text },
                { "Unit", unit_txtbox.Text }
            };

            // Check if any field is empty
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Value))  // Checks for null, empty, or whitespace
                {
                    MessageBox.Show($"Error: {field.Key} cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop execution if any field is empty
                }
            }


            string item_name = itemname_txtbox.Text;
            string item_code = itemcode_txtbox.Text;
            string item_description = itemdesc_txtbox.Text;
            string item_color = item_color_txtbox.Text;
            string item_category = itemcategory_combobox.Text;
            string supplier = supplier_txtbox1.Text;
            string unit = unit_txtbox.Text;
            DateTime createdAt = DateTime.Now;

            if (!int.TryParse(stock_txtbox.Text, out int stock))
            {
                MessageBox.Show("Error: Invalid stock value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(item_price_txtbox.Text, out decimal price))
            {
                MessageBox.Show("Error: Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Function.CreateProduct(item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, price, createdAt);
            MessageBox.Show("Product created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
