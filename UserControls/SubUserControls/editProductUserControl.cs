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
using inventory_system.Model;

namespace inventory_system.UserControls.SubUserControls
{
    public partial class editProductUserControl : UserControl
    {

        private string productId;
        public editProductUserControl(string productId)
        {
            InitializeComponent();
            this.productId = productId;
        }

        private void edit_product_btn_Click(object sender, EventArgs e)
        {
            // Store the text fields in a dictionary
            var fields = new Dictionary<string, string>
            {
                { "Item Name", edit_itemname_txtbox.Text },
                { "Item Code", edit_itemcode_txtbox.Text },
                { "Item Description", edit_itemdesc_txtbox.Text },
                { "Item Color", edit_item_color_txtbox.Text },
                { "Item Category", edit_itemcategory_combobox.Text },
                { "Supplier", edit_supplier_txtbox1.Text },
                { "Unit", edit_unit_txtbox.Text }
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

            string item_name = edit_itemname_txtbox.Text;
            string item_code = edit_itemcode_txtbox.Text;
            string item_description = edit_itemdesc_txtbox.Text;
            string item_color = edit_item_color_txtbox.Text;
            string item_category = edit_itemcategory_combobox.Text;
            string supplier = edit_supplier_txtbox1.Text;
            string unit = edit_unit_txtbox.Text;
            DateTime updated_at = DateTime.Now;

            if (!int.TryParse(edit_stock_txtbox.Text, out int stock))
            {
                MessageBox.Show("Error: Invalid stock value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(edit_item_price_txtbox.Text, out decimal price))
            {
                MessageBox.Show("Error: Invalid price value.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Function.EditProduct(productId, item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, price, updated_at);
            MessageBox.Show("Product updated successfully.", "Information" ,MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void add_product_close_btn_Click(object sender, EventArgs e)
        {
            Function.HideParentPanel(this);
        }
    }
}
