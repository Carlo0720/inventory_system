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
using MySql.Data.MySqlClient;
using inventory_system.Repository;
using inventory_system.common.Utility;

namespace inventory_system.UserControls.Order
{
    public partial class OrderAddForm_Item : UserControl
    {
        private ProductsRepository productsRepository;
        // Define an event to pass data back to the parent form
        public event EventHandler<ProductSelectedEventArgs> ProductSelected;
        public OrderAddForm_Item()
        {
            InitializeComponent();
            productsRepository = new ProductsRepository();
        }

        private void products_add_Click(object sender, EventArgs e)
        {

        }

        private void productlist_datagd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void OrderAddForm_Item_Load(object sender, EventArgs e)
        {

            this.BringToFront();
            Function.StyleDataGridView(productlist_datagd);

            productlist_datagd.Columns["product_id"].DataPropertyName = "product_id";
            productlist_datagd.Columns["item_code"].DataPropertyName = "item_code";
            productlist_datagd.Columns["item_name"].DataPropertyName = "item_name";
            productlist_datagd.Columns["item_description"].DataPropertyName = "item_description";
            productlist_datagd.Columns["item_color"].DataPropertyName = "item_color";
            productlist_datagd.Columns["item_category"].DataPropertyName = "item_category";
            productlist_datagd.Columns["supplier"].DataPropertyName = "supplier";
            productlist_datagd.Columns["stock"].DataPropertyName = "stock";
            productlist_datagd.Columns["unit"].DataPropertyName = "unit";
            productlist_datagd.Columns["item_price"].DataPropertyName = "item_price";
            productlist_datagd.DataSource = productsRepository.Get(SD.SelectProducts);


            // Hide the "ID" column from the DataGridView
            productlist_datagd.Columns["product_id"].Visible = false;
            //try
            //{


            //    string query = "SELECT product_id, item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, item_price, created_at " +
            //        "FROM products";


            //    using (MySqlConnection conn = new MySqlConnection(Variables.connString))
            //    {
            //        conn.Open();
            //        using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //        {
            //            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
            //            {
            //                DataTable db_products_table = new DataTable();
            //                sda.Fill(db_products_table);



            //                productlist_datagd.Columns["product_id"].DataPropertyName = "product_id";
            //                productlist_datagd.Columns["item_name"].DataPropertyName = "item_name";
            //                productlist_datagd.Columns["item_code"].DataPropertyName = "item_code";
            //                productlist_datagd.Columns["item_description"].DataPropertyName = "item_description";
            //                productlist_datagd.Columns["item_color"].DataPropertyName = "item_color";
            //                productlist_datagd.Columns["item_category"].DataPropertyName = "item_category";
            //                productlist_datagd.Columns["supplier"].DataPropertyName = "supplier";
            //                productlist_datagd.Columns["stock"].DataPropertyName = "stock";
            //                productlist_datagd.Columns["unit"].DataPropertyName = "unit";
            //                productlist_datagd.Columns["item_price"].DataPropertyName = "item_price";
            //                productlist_datagd.Columns["created_at"].DataPropertyName = "created_at";

            //                if (db_products_table.Rows.Count > 0)
            //                {
            //                    productlist_datagd.DataSource = db_products_table;
            //                }

            //                else
            //                {
            //                    MessageBox.Show("No data found in the users table.");
            //                }

            //            }
            //        }
            //    }
            //}

            //catch (Exception ex)
            //{
            //    MessageBox.Show("Error: " + ex.Message);
            //}
        }

        private void productlist_datagd_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the user has clicked a valid row (not the header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = productlist_datagd.Rows[e.RowIndex];

                // Get values from the selected row
                int productId = Convert.ToInt32(selectedRow.Cells["product_id"].Value);
                string itemName = selectedRow.Cells["item_name"].Value.ToString();
                string itemCode = selectedRow.Cells["item_code"].Value.ToString();
                string itemDescription = selectedRow.Cells["item_description"].Value.ToString();
                string itemColor = selectedRow.Cells["item_color"].Value.ToString();
                string itemCategory = selectedRow.Cells["item_category"].Value.ToString();
                string supplier = selectedRow.Cells["supplier"].Value.ToString();
                int stock = Convert.ToInt32(selectedRow.Cells["stock"].Value);
                int quantity = Convert.ToInt32(quantityTbox.Text);
                string unit = selectedRow.Cells["unit"].Value.ToString();
                //string length = string.IsNullOrEmpty(lengthTbox.Text) ? "1" : lengthTbox.Text;
                decimal itemPrice = Convert.ToDecimal(selectedRow.Cells["item_price"].Value);

                // Create the EventArgs object with the product details
                var eventArgs = new ProductSelectedEventArgs
                {
                    product = new()
                    {
                        ProductId = productId,
                        ItemName = itemName,
                        ItemCode = itemCode,
                        ItemDescription = itemDescription,
                        ItemColor = itemColor,
                        ItemCategory = itemCategory,
                        Supplier = supplier,
                        Stock = stock,
                        Quantity = quantity,
                        Unit = unit,
                        //Length = length,
                        ItemPrice = itemPrice
                    }
                };

                // Trigger the ProductSelected event
                ProductSelected?.Invoke(this, eventArgs);

                // Optionally, enable the parent form again if you disabled it for modal-like behavior
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }
        }

        private void quantityTbox_Leave(object sender, EventArgs e)
        {
            // Get the value from the textbox
            if (int.TryParse(quantityTbox.Text, out int value))
            {
                // If the value is less than 0, set it to 0
                if (value <= 0)
                {
                    quantityTbox.Text = "1";
                }
                // If the value is greater than 50, set it to 50
                else if (value > 50)
                {
                    quantityTbox.Text = "50";
                }
            }
            else
            {
                // If the input is not a valid integer, set the value to 0
                quantityTbox.Text = "1";
            }
        }

        private void quantityTbox_TextChanged(object sender, EventArgs e)
        {
            // Ensure the value is a valid integer and not less than 0
            if (int.TryParse(quantityTbox.Text, out int value))
            {
                if (value <= 0)
                {
                    quantityTbox.Text = "1";
                }
                // If the value is greater than 50, set it to 50
                else if (value > 50)
                {
                    quantityTbox.Text = "50";
                }
            }
        }
    }
}
