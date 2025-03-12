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
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
            this.Resize += UserForm_Resize;
        }


        private void UserForm_Load_1(object sender, EventArgs e)
        {


            userDataGd.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);



            try
            {
                string connectionString = Variables.connString;
                string query = "SELECT id, user_type_id, first_name, last_name, user_name, password FROM users";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable db_users_table = new DataTable();
                            sda.Fill(db_users_table);

                            userDataGd.AutoGenerateColumns = false;



                            // Ensure columns exist and set DataPropertyName correctly
                            userDataGd.Columns["ID"].DataPropertyName = "id";
                            userDataGd.Columns["User_Type"].DataPropertyName = "user_type_id";
                            userDataGd.Columns["First_Name"].DataPropertyName = "first_name";
                            userDataGd.Columns["Last_Name"].DataPropertyName = "last_name";
                            userDataGd.Columns["Username"].DataPropertyName = "user_name";
                            userDataGd.Columns["temp_password"].DataPropertyName = "password";

                            // Bind data only if rows exist
                            if (db_users_table.Rows.Count > 0)
                            {
                                userDataGd.DataSource = db_users_table;
                            }
                            else
                            {
                                MessageBox.Show("No data found in the users table.");
                            }
                        }
                    }
                }
            }

            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void UserForm_Resize(object sender, EventArgs e)
        {
            userDataGd.Width = this.ClientSize.Width - 20;
            userDataGd.Height = this.ClientSize.Height - 50;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {

        }

        private void userDataGd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
