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

namespace inventory_system
{
    public partial class productListUserControl : UserControl
    {
        public productListUserControl()
        {
            InitializeComponent();
            products_add_pnl.Visible = false;

        }

        private void productListUserControl_Load(object sender, EventArgs e)
        {
            
            productlist_datagd.RowHeadersVisible = false;
            productlist_datagd.EnableHeadersVisualStyles = false;
            productlist_datagd.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productlist_datagd.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            productlist_datagd.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            string columnInfo = ""; // Store column names

     
            

            try
            {


                string query = "SELECT product_id, item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, item_price, created_at " +
                    "FROM products";


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
                            productlist_datagd.Columns["created_at"].DataPropertyName = "created_at";

                            if(db_products_table.Rows.Count > 0) 
                            {
                                productlist_datagd.DataSource = db_products_table;
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
                MessageBox.Show("Error: ", ex.Message);
            }

            

        }

        private void Order_search_Click(object sender, EventArgs e)
        {

        }

        private void products_add_Click(object sender, EventArgs e)
        {
            Function.HighlightButtonTemporary((Button)sender, 1500);
            productsAddUserControl productsAddUC = new productsAddUserControl();
            productsAddUC.Dock = DockStyle.Fill;
            products_add_pnl.Controls.Add(productsAddUC);
            products_add_pnl.Visible = true;
        }

        private void products_searchbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
