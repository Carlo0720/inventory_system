using inventory_system.Globals;
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

namespace inventory_system
{
    public partial class Customers_Form : UserControl
    {
        public Customers_Form()
        {
            InitializeComponent();

        }

        private void Customers_Form_Load(object sender, EventArgs e)
        {
            Function.StyleDataGridView(customers_datagd);
            customers_add_pnl.Visible = false;

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


        
        private void customers_add_btn_Click(object sender, EventArgs e)
        {



            Function.HighlightButtonTemporary((Button)sender, 1500);
            CustomersAddUserControl customersAddUC = new CustomersAddUserControl();
            customersAddUC.Dock = DockStyle.Fill;
            customers_add_pnl.Controls.Add(customersAddUC);
            customers_add_pnl.Visible = true;
        }
        

        

    }
}
