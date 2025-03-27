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
using inventory_system.Globals;
using MySql.Data.MySqlClient;
using inventory_system.UserControls.Order;
using Microsoft.VisualBasic.ApplicationServices;
using inventory_system.UserControls.SubUserControls;
using inventory_system.Model;

namespace inventory_system
{
    public partial class productListUserControl : UserControl
    {
        public productListUserControl()
        {
            InitializeComponent();
            products_add_pnl.Visible = false;

        }


        private void LoadAccessories()
        {
            string query = "SELECT product_id, item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, item_price FROM products " +
                "WHERE deleted_at IS NULL";
            DataTable dt = Function.DatabaseHelper.ExecuteQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                productlist_datagd.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found in the customers table.");
            }
        }

        private void productListUserControl_Load(object sender, EventArgs e)
        {
            productlist_datagd.CellContentClick += productlist_datagd_CellContentClick;
            this.BringToFront();
            Function.StyleDataGridView(productlist_datagd);
            try
            {


                string query = "SELECT product_id, item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, item_price, cost_price, created_at " +
                    "FROM products WHERE deleted_at IS NULL";


                using (MySqlConnection conn = new MySqlConnection(Variables.connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable db_products_table = new DataTable();
                            sda.Fill(db_products_table);

                            productlist_datagd.Columns["product_id"].DataPropertyName = "product_id";
                            productlist_datagd.Columns["item_name"].DataPropertyName = "item_name";
                            productlist_datagd.Columns["item_code"].DataPropertyName = "item_code";
                            productlist_datagd.Columns["item_description"].DataPropertyName = "item_description";
                            productlist_datagd.Columns["item_color"].DataPropertyName = "item_color";
                            productlist_datagd.Columns["item_category"].DataPropertyName = "item_category";
                            productlist_datagd.Columns["supplier"].DataPropertyName = "supplier";
                            productlist_datagd.Columns["stock"].DataPropertyName = "stock";
                            productlist_datagd.Columns["unit"].DataPropertyName = "unit";
                            productlist_datagd.Columns["item_price"].DataPropertyName = "item_price";
                            productlist_datagd.Columns["cost_price"].DataPropertyName = "cost_price";
                            productlist_datagd.Columns["created_at"].DataPropertyName = "created_at";

                            if (db_products_table.Rows.Count > 0)
                            {
                                productlist_datagd.Columns.Clear();  // Ensures correct header text and arrangement
                                productlist_datagd.DataSource = db_products_table;

                                // Manually define column headers
                                productlist_datagd.Columns["product_id"].HeaderText = "Product ID";
                                productlist_datagd.Columns["item_name"].HeaderText = "Item Name";
                                productlist_datagd.Columns["item_code"].HeaderText = "Item Code";
                                productlist_datagd.Columns["item_description"].HeaderText = "Description";
                                productlist_datagd.Columns["item_color"].HeaderText = "Color";
                                productlist_datagd.Columns["item_category"].HeaderText = "Category";
                                productlist_datagd.Columns["supplier"].HeaderText = "Supplier";
                                productlist_datagd.Columns["stock"].HeaderText = "Stock";
                                productlist_datagd.Columns["unit"].HeaderText = "Unit";
                                productlist_datagd.Columns["item_price"].HeaderText = "Price";
                                productlist_datagd.Columns["cost_price"].HeaderText = "Cost Price";
                                productlist_datagd.Columns["created_at"].HeaderText = "Created At";

                                // Ensure buttons are at the correct positions

                                Function.AddEditDeleteButtons(productlist_datagd);

                            }

                            else
                            {
                                MessageBox.Show("No data found in the users table.");
                            }

                        }
                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }



        }

        private void Order_search_Click(object sender, EventArgs e)
        {

        }

        private void products_add_Click(object sender, EventArgs e)
        {
            products_add_pnl.Controls.Clear();
            productsAddUserControl productsAddUC = new productsAddUserControl();
            productsAddUC.Dock = DockStyle.Fill;
            products_add_pnl.Controls.Add(productsAddUC);
            productsAddUC.AcessoryAdded += RefreshCustomerGrid;
            products_add_pnl.Visible = true;
        }

        private void products_searchbtn_Click(object sender, EventArgs e)
        {

        }

        private void productlist_datagd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                string selectedProductId = productlist_datagd.Rows[e.RowIndex].Cells["product_id"].Value.ToString();

                if (productlist_datagd.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditProduct(selectedProductId);
                }
                else if (productlist_datagd.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete,", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteProduct(selectedProductId);
                    }
                }
            }
        }

        private void EditProduct(string productId)
        {
            products_add_pnl.Controls.Clear();
            editProductUserControl editProductUC = new editProductUserControl(productId);
            editProductUC.Dock = DockStyle.Fill;
            MessageBox.Show("Editing product: " + productId);
            products_add_pnl.Controls.Add(editProductUC);


            products_add_pnl.Parent = this;
            products_add_pnl.Visible = true;
            products_add_pnl.BringToFront();
        }

        private void DeleteProduct(string productId)
        {
            try
            {
                string query = "UPDATE products SET deleted_at = NOW() WHERE product_id = @product_id";
                using (MySqlConnection conn = new MySqlConnection(Variables.connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@product_id", productId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Acessory archived successfully.");
                            productListUserControl_Load(null, null); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to archive accessory.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }



        private void RefreshCustomerGrid()
        {
            LoadAccessories();
        }

        private void productlist_datagd_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
