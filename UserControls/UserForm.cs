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
using inventory_system.Globals;
using inventory_system.UserControls.SubUserControls;

namespace inventory_system
{
    public partial class UserForm : UserControl
    {
        public UserForm()
        {
            InitializeComponent();
            this.Resize += UserForm_Resize;
            
        }

        private void LoadUsers()
        {
            string query = "SELECT id, user_type_id, first_name, last_name, user_name, temp_password FROM users";
            DataTable dt = Function.DatabaseHelper.ExecuteQuery(query);
            if (dt != null && dt.Rows.Count > 0)
            {
                user_datagd.DataSource = dt;
            }
            else
            {
                MessageBox.Show("No data found in the customers table.");
            }
        }
        private void HighlightSideButton(Button clickedButton)
        {
            List<Button> sideButtons = new List<Button> { Create_Btn, Refresh_Btn };
            Function.HighlightButton(clickedButton, sideButtons);
        }

        private void UserForm_Load_1(object sender, EventArgs e)
        {
            user_datagd.CellContentClick += user_datagd_CellContentClick;


            userCreationPanel.Visible = false;

            user_datagd.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            foreach (DataGridViewColumn column in user_datagd.Columns)
            {
                column.HeaderCell.Style.BackColor = Color.Gray;
                column.HeaderCell.Style.ForeColor = Color.White;
            }

            user_datagd.EnableHeadersVisualStyles = false;
            user_datagd.Refresh();

            try
            {
                string connectionString = Variables.connString;
                string query = "SELECT id, user_type_id, first_name, last_name, user_name, temp_password FROM users WHERE deleted_at IS NULL";

                using (MySqlConnection conn = new MySqlConnection(connectionString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                        {
                            DataTable db_users_table = new DataTable();
                            sda.Fill(db_users_table);

                            user_datagd.AutoGenerateColumns = false;

                            // Ensure columns exist and set DataPropertyName correctly
                            user_datagd.Columns["ID"].DataPropertyName = "id";
                            user_datagd.Columns["User_Type"].DataPropertyName = "user_type_id";
                            user_datagd.Columns["First_Name"].DataPropertyName = "first_name";
                            user_datagd.Columns["Last_Name"].DataPropertyName = "last_name";
                            user_datagd.Columns["Username"].DataPropertyName = "user_name";
                            user_datagd.Columns["temp_password"].DataPropertyName = "temp_password";

                            // Add Edit and Delete buttons if not already added
                            if (user_datagd.Columns["Edit"] == null)
                            {
                                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                                editButton.Name = "Edit";
                                editButton.HeaderText = "Edit";
                                editButton.Text = "Edit";
                                editButton.UseColumnTextForButtonValue = true;
                                user_datagd.Columns.Add(editButton);
                            }

                            if (user_datagd.Columns["Delete"] == null)
                            {
                                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                                deleteButton.Name = "Delete";
                                deleteButton.HeaderText = "Delete";
                                deleteButton.Text = "Delete";
                                deleteButton.UseColumnTextForButtonValue = true;
                                user_datagd.Columns.Add(deleteButton);
                            }

                            // Bind data only if rows exist
                            if (db_users_table.Rows.Count > 0)
                            {
                                user_datagd.DataSource = db_users_table;
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

        private void user_datagd_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

            if (e.RowIndex >= 0)
            {
                string selectedUserId = user_datagd.Rows[e.RowIndex].Cells["ID"].Value.ToString();

                if (user_datagd.Columns[e.ColumnIndex].Name == "Edit")
                {
                   
                    
                    EditUser(selectedUserId);
                }
                else if (user_datagd.Columns[e.ColumnIndex].Name == "Delete")
                {
                    DialogResult confirm = MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        DeleteUser(selectedUserId);
                    }
                }
            }
        }

        private void EditUser(string userId)
        {
            

            userCreationPanel.Controls.Clear(); // Clear previous controls
            editUserUserControl editUserUC = new editUserUserControl(userId);
            editUserUC.Dock = DockStyle.Fill;
            userCreationPanel.Controls.Add(editUserUC);

            userCreationPanel.Parent = this;
            userCreationPanel.Visible = true;
            userCreationPanel.BringToFront();
        }

        private void DeleteUser(string userId)
        {
            try
            {
                string query = "UPDATE users SET deleted_at = NOW() WHERE id = @id";
                using (MySqlConnection conn = new MySqlConnection(Variables.connString))
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@id", userId);
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("User archived successfully.");
                            UserForm_Load_1(null, null); // Refresh DataGridView
                        }
                        else
                        {
                            MessageBox.Show("Failed to archive user.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void UserForm_Resize(object sender, EventArgs e)
        {
            user_datagd.Width = this.ClientSize.Width - 20;
            user_datagd.Height = this.ClientSize.Height - 50;
        }

        private void Refresh_button_Click(object sender, EventArgs e)
        {
            Function.HighlightButtonTemporary((Button)sender, 1500);
        }

        private void Create_Btn_Click(object sender, EventArgs e)
        {
            Function.HighlightButtonTemporary((Button)sender, 1500);
            userCreationPanel.Controls.Clear(); // Clear previous controls
            userCreationForm userCF = new userCreationForm();
            userCF.Dock = DockStyle.Fill;
            userCreationPanel.Controls.Add(userCF);

            userCF.UserAdded += RefreshCustomerGrid;

            userCreationPanel.Parent = this;
            userCreationPanel.Visible = true;
            userCreationPanel.BringToFront();
        }

        private void RefreshCustomerGrid()
        {
            LoadUsers();
        }


    }
}
