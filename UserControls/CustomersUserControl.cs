using inventory_system.Globals;
using inventory_system.UserControls.SubUserControls;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static inventory_system.Globals.Function;

namespace inventory_system
{
    public partial class Customers_Form : UserControl
    {
        public Customers_Form()
        {
            InitializeComponent();

        }

        private void LoadCustomers()
        {
            string query = "SELECT customers_id, first_name, last_name, company_name, email, phone_number, address FROM customers WHERE deleted_at IS NULL";
            DataTable dt = Function.DatabaseHelper.ExecuteQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                customers_datagd.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found in the customers table.");
            }
        }


        private void Customers_Form_Load(object sender, EventArgs e)
        {
            Function.StyleDataGridView(customers_datagd);
            customers_datagd.CellContentClick += customers_datagd_CellContentClick;
            customers_add_pnl.Visible = false;

            string query = "SELECT customers_id, first_name, last_name, company_name, email, phone_number, address FROM customers WHERE deleted_at IS NULL";


            using (MySqlConnection conn = new MySqlConnection(Variables.connString))
            {
                conn.Open();
                try
                {
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable db_customers_table = new DataTable();
                            sda.Fill(db_customers_table);

                            customers_datagd.Columns["customers_id"].DataPropertyName = "customers_id";
                            customers_datagd.Columns["first_name"].DataPropertyName = "first_name";
                            customers_datagd.Columns["last_name"].DataPropertyName = "last_name";
                            customers_datagd.Columns["company_name"].DataPropertyName = "company_name";
                            customers_datagd.Columns["email"].DataPropertyName = "email";
                            customers_datagd.Columns["phone_number"].DataPropertyName = "phone_number";
                            customers_datagd.Columns["address"].DataPropertyName = "address";


                            if (db_customers_table.Rows.Count > 0)
                            {
                                Function.AddEditDeleteButtons(customers_datagd);
                                customers_datagd.DataSource = db_customers_table;
                            }

                            else
                            {
                                MessageBox.Show("No data found in the users table.");
                            }

                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



            }
        }

        private void customers_datagd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string selectedCustomerId = customers_datagd.Rows[e.RowIndex].Cells["customers_id"].Value.ToString(); // Ensure correct column name
                MessageBox.Show("Selected customer: " + selectedCustomerId);

                if (customers_datagd.Columns[e.ColumnIndex].Name == "Edit")
                {
                    EditCustomers(selectedCustomerId);
                }
                else if (customers_datagd.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteCustomers(selectedCustomerId);
                    }
                }
            }
        }


        private void EditCustomers(string customerId)
        {
            customers_add_pnl.Controls.Clear();
            editCustomerUserControl editCustomerUC = new editCustomerUserControl(customerId);
            editCustomerUC.Dock = DockStyle.Fill;          
            customers_add_pnl.Controls.Add(editCustomerUC);


            customers_add_pnl.Parent = this;
            customers_add_pnl.Visible = true;
            customers_add_pnl.BringToFront();
        }

        private void DeleteCustomers(string customerId) // Corrected parameter name
        {
            try
            {
                string query = "UPDATE customers SET deleted_at = NOW() WHERE customers_id = @customers_id";
                using (MySqlConnection conn = new MySqlConnection(Variables.connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@customers_id", customerId); // Corrected parameter name
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Customer archived successfully.");
                            Customers_Form_Load(null, null); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to archive customer.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }




        private void customers_add_btn_Click(object sender, EventArgs e)
        {
            
            CustomersAddUserControl customersAddUC = new CustomersAddUserControl();
            customersAddUC.Dock = DockStyle.Fill;

            
            customersAddUC.CustomerAdded += RefreshCustomerGrid;

            customers_add_pnl.Controls.Add(customersAddUC);
            customers_add_pnl.Visible = true;
        }

        
        private void RefreshCustomerGrid()
        {
            LoadCustomers(); 
        }




    }
}
