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

namespace inventory_system.UserControls.Order
{
    public partial class OrderAddForm_Customer : UserControl
    {
        // Define an event to pass data back to the parent form
        public event EventHandler<CustomerSelectedEventArgs> CustomerSelected;
        public OrderAddForm_Customer()
        {
            InitializeComponent();
        }

        private void OrderAddForm_Customer_Load(object sender, EventArgs e)
        {
            Function.StyleDataGridView(customers_datagd);

            string query = "SELECT first_name, last_name, company_name, email, phone_number, address FROM customers";

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

                            customers_datagd.Columns["first_name"].DataPropertyName = "first_name";
                            customers_datagd.Columns["last_name"].DataPropertyName = "last_name";
                            customers_datagd.Columns["company_name"].DataPropertyName = "company_name";
                            customers_datagd.Columns["email"].DataPropertyName = "email";
                            customers_datagd.Columns["phone_number"].DataPropertyName = "phone_number";
                            customers_datagd.Columns["address"].DataPropertyName = "address";

                            if (db_customers_table.Rows.Count > 0)
                            {
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

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            // Optionally, enable the parent form again if you disabled it for modal-like behavior
            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void customers_datagd_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if a valid row is double-clicked (not the header row)
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = customers_datagd.Rows[e.RowIndex];

                // Create a custom EventArgs to store the selected values
                var eventArgs = new CustomerSelectedEventArgs
                {
                    FirstName = selectedRow.Cells["first_name"].Value.ToString(),
                    LastName = selectedRow.Cells["last_name"].Value.ToString(),
                    CompanyName = selectedRow.Cells["company_name"].Value.ToString(),
                    Email = selectedRow.Cells["email"].Value.ToString(),
                    PhoneNumber = selectedRow.Cells["phone_number"].Value.ToString(),
                    Address = selectedRow.Cells["address"].Value.ToString()
                };

                // Trigger the event
                CustomerSelected?.Invoke(this, eventArgs);

                // Optionally, enable the parent form again if you disabled it for modal-like behavior
                Form parentForm = this.FindForm();
                if (parentForm != null)
                {
                    parentForm.Close();
                }
            }
        }
    }
}
