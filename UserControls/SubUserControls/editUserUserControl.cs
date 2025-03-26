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
using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace inventory_system.UserControls.SubUserControls
{
    public partial class editUserUserControl : UserControl
    {

        private string userId;
        public editUserUserControl(string userId)
        {
            InitializeComponent();
            this.userId = userId;
            LoadUserData();
        }

        private void LoadUserData()
        {
            try
            {
                string connectionString = Variables.connString;
                string query = "SELECT first_name, last_name FROM users WHERE id = @userId";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", userId);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // If user exists
                            {
                                edituserfirstname_txtbox.Text = reader["first_name"].ToString();
                                edituserlastname_txtbox.Text = reader["last_name"].ToString();
                            }
                            else
                            {
                                MessageBox.Show("User not found.");
                            }
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error loading user data: " + ex.Message);
            }
        }

        private void edituser_btn_Click(object sender, EventArgs e)
        {
            inventory_system.Globals.Function.EditUser(userId, edituserfirstname_txtbox.Text, edituserlastname_txtbox.Text, edituserpassword_txtbox.Text);
            MessageBox.Show("User updated successfully.");
        }

        private void Close_btn_Click(object sender, EventArgs e)
        {
            inventory_system.Globals.Function.HideParentPanel(this);
        }
    }
}
