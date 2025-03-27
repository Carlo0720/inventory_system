using inventory_system.common.Utility;
using inventory_system.Globals;
using inventory_system.Model;
using inventory_system.Repository;
using inventory_system.style;
using inventory_system.UserControls.Order;
using inventory_system.Window_Forms;
using MySql.Data.MySqlClient;
using ReaLTaiizor.Controls;
using ReaLTaiizor.Forms;
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
        private OrderRepository orderRepository;
        public Orders_Form()
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            ordersAddPanel.Visible = false;
            DataGridViewStyler.ApplyStyles(dataGridView_Orders);
        }


        private void Orders_Form_Load(object sender, EventArgs e)
        {
            dataGridView_Orders.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);

            Function.StyleDataGridView(dataGridView_Orders);

            dataGridView_Orders.Columns["orders_id"].DataPropertyName = "order_id";
            dataGridView_Orders.Columns["Date"].DataPropertyName = "created_at";
            dataGridView_Orders.Columns["Customername"].DataPropertyName = "customer_name";
            dataGridView_Orders.Columns["Customerdetail"].DataPropertyName = "company_name";
            dataGridView_Orders.Columns["Po"].DataPropertyName = "po_number";
            dataGridView_Orders.Columns["Dr"].DataPropertyName = "dr_number";
            dataGridView_Orders.Columns["Total"].DataPropertyName = "total_price";

            // Hide the "ID" column from the DataGridView
            dataGridView_Orders.Columns["orders_id"].Visible = false;

            LoadData();


            //string query = "SELECT o.order_id, o.created_at, CONCAT(c.first_name, ' ', c.last_name) AS customer_name, c.company_name, o.po_number, o.dr_number, o.total_price\r\nFROM orders o\r\nJOIN customers c ON o.customers_id = c.customers_id;";

            //using (MySqlConnection conn = new MySqlConnection(Variables.connString))
            //{
            //    conn.Open();
            //    try
            //    {
            //        using (MySqlCommand cmd = new MySqlCommand(query, conn))
            //        {
            //            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
            //            {
            //                DataTable db_customers_table = new DataTable();
            //                sda.Fill(db_customers_table);

            //                dataGridView_Orders.Columns["orders_id"].DataPropertyName = "order_id";
            //                dataGridView_Orders.Columns["Date"].DataPropertyName = "created_at";
            //                dataGridView_Orders.Columns["Customername"].DataPropertyName = "customer_name";
            //                dataGridView_Orders.Columns["Customerdetail"].DataPropertyName = "company_name";
            //                dataGridView_Orders.Columns["Po"].DataPropertyName = "po_number";
            //                dataGridView_Orders.Columns["Dr"].DataPropertyName = "dr_number";
            //                dataGridView_Orders.Columns["Total"].DataPropertyName = "total_price";

            //                if (db_customers_table.Rows.Count > 0)
            //                {
            //                    dataGridView_Orders.DataSource = db_customers_table;
            //                }

            //                else
            //                {
            //                    MessageBox.Show("No data found in the users table.");
            //                }

            //            }
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //    }
            //}
        }

        private void Order_search_Click(object sender, EventArgs e)
        {

        }

        private void Orders_add_Click(object sender, EventArgs e)
        {
            // Create a new form for the popup window
            Form popupForm = new Form();
            popupForm.Text = "Add Order";  // Title of the popup window
            popupForm.StartPosition = FormStartPosition.CenterScreen;  // Center it on the screen
            popupForm.Size = new Size(732, 502);  // Set the size of the popup window

            //popupForm.ShowInTaskbar = false;  // This hides the modal from the taskbar
            //popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;  // Optional: Make the form look like a dialog

            // Add your OrdersAddForm to the popup window
            OrdersAddForm ordersAF = new OrdersAddForm();
            ordersAF.Dock = DockStyle.Fill;
            popupForm.Controls.Add(ordersAF);




            // Optionally, subscribe to the modal's event or just handle after closing
            popupForm.FormClosed += (s, args) =>
            {
                // Reload the data when the modal is closed
                LoadData();
            };

            // Optionally, make the popup modal (blocking interaction with the main form)
            popupForm.ShowDialog();

            //OrdersAddForm ordersAF = new OrdersAddForm();
            //ordersAF.Dock = DockStyle.Fill;
            //ordersAddPanel.Controls.Add(ordersAF);
            //ordersAddPanel.Visible = true;

        }

        private void Orders_refresh_Click(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView_Orders.DataSource = orderRepository.Get(SD.SelectAllOrders);
        }

        private void dataGridView_Orders_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is double-clicked (not the header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = dataGridView_Orders.Rows[e.RowIndex];
                int Id = Convert.ToInt32(selectedRow.Cells["orders_id"].Value);
                DataTable orderDataTable = new DataTable();

                orderDataTable = orderRepository.GetSpecificOrderItems(Id);


                // Create a new form for the popup window
                Form popupForm = new Form();
                popupForm.Text = "Add Order";  // Title of the popup window
                popupForm.StartPosition = FormStartPosition.CenterScreen;  // Center it on the screen
                popupForm.Size = new Size(450, 555);  // Set the size of the popup window

                //popupForm.ShowInTaskbar = false;  // This hides the modal from the taskbar
                //popupForm.FormBorderStyle = FormBorderStyle.FixedDialog;  // Optional: Make the form look like a dialog

                // Add your OrdersAddForm to the popup window
                OrderInfo orderInfo = new OrderInfo(Id);
                orderInfo.Dock = DockStyle.Fill;
                popupForm.Controls.Add(orderInfo);




                // Optionally, subscribe to the modal's event or just handle after closing
                popupForm.FormClosed += (s, args) =>
                {
                    // Reload the data when the modal is closed
                    LoadData();
                };

                // Optionally, make the popup modal (blocking interaction with the main form)
                popupForm.ShowDialog();

            }
        }
    }
}
