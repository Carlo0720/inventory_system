﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using BC = BCrypt.Net.BCrypt;
using System.Transactions;
using System.Collections;
using Org.BouncyCastle.Asn1.X509;
using System.Data;
using inventory_system.Model;

namespace inventory_system.Globals
{
  
    class Function
    {
        public static void HideParentPanel(UserControl control)
        {
            if (control?.Parent is Panel parentPanel)
            {
                parentPanel.Visible = false;
            }
        }

        public static class DatabaseHelper
        {
            public static DataTable ExecuteQuery(string query)
            {
                using (MySqlConnection conn = new MySqlConnection(Variables.connString))
                {
                    conn.Open();
                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            using (MySqlDataAdapter sda = new MySqlDataAdapter(cmd))
                            {
                                DataTable dt = new DataTable();
                                sda.Fill(dt);
                                return dt;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return null;
                    }
                }
            }
        }



        private System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();


        public static void StyleDataGridView(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.EnableHeadersVisualStyles = false;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.Gray;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10, FontStyle.Bold);
            dgv.Anchor = (AnchorStyles.Top |AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Bottom);
        }

        public static void AddEditDeleteButtons(DataGridView dgv)
        {
            if (dgv.Columns["Edit"] == null)
            {
                DataGridViewButtonColumn editButton = new DataGridViewButtonColumn();
                editButton.Name = "Edit";
                editButton.HeaderText = "Edit";
                editButton.Text = "Edit";
                editButton.UseColumnTextForButtonValue = true;
                editButton.Width = 50; // Fixed width
                editButton.FillWeight = 1; // Keep it minimal in auto-sizing
                editButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Prevent resizing
                dgv.Columns.Add(editButton);
            }

            if (dgv.Columns["Delete"] == null)
            {
                DataGridViewButtonColumn deleteButton = new DataGridViewButtonColumn();
                deleteButton.Name = "Delete";
                deleteButton.HeaderText = "Delete";
                deleteButton.Text = "Delete";
                deleteButton.UseColumnTextForButtonValue = true;
                deleteButton.Width = 50; // Fixed width
                deleteButton.FillWeight = 1; // Keep it minimal in auto-sizing
                deleteButton.AutoSizeMode = DataGridViewAutoSizeColumnMode.None; // Prevent resizing
                dgv.Columns.Add(deleteButton);
            }

            // Make sure Edit and Delete columns are always the last ones
            dgv.Columns["Edit"].DisplayIndex = dgv.Columns.Count - 2;
            dgv.Columns["Delete"].DisplayIndex = dgv.Columns.Count - 1;

            // Set AutoSizeColumnsMode to Fill for the entire DataGridView
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Adjust FillWeight for all other columns so they take up remaining space
            foreach (DataGridViewColumn col in dgv.Columns)
            {
                if (col.Name != "Edit" && col.Name != "Delete")
                {
                    col.FillWeight = 100; // Make these columns take the remaining space
                }
            }

            // Apply styles
            dgv.Columns["Edit"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Delete"].HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["Edit"].HeaderCell.Style.BackColor = Color.Gray;
            dgv.Columns["Delete"].HeaderCell.Style.BackColor = Color.Gray;
            dgv.EnableHeadersVisualStyles = false;

            dgv.CellFormatting += (sender, e) =>
            {
                if (e.RowIndex >= 0)
                {
                    if (dgv.Columns[e.ColumnIndex].Name == "Edit")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(30, 144, 255);
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.SelectionBackColor = Color.FromArgb(30, 144, 255);
                        e.CellStyle.SelectionForeColor = Color.White;
                    }
                    else if (dgv.Columns[e.ColumnIndex].Name == "Delete")
                    {
                        e.CellStyle.BackColor = Color.FromArgb(220, 20, 60);
                        e.CellStyle.ForeColor = Color.White;
                        e.CellStyle.SelectionBackColor = Color.FromArgb(220, 20, 60);
                        e.CellStyle.SelectionForeColor = Color.White;
                    }
                }
            };

            dgv.CellPainting += (sender, e) =>
            {
                if (e.RowIndex >= 0 && (dgv.Columns[e.ColumnIndex].Name == "Edit" || dgv.Columns[e.ColumnIndex].Name == "Delete"))
                {
                    e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                    Color buttonColor = dgv.Columns[e.ColumnIndex].Name == "Edit" ?
                        Color.FromArgb(30, 144, 255) : Color.FromArgb(220, 20, 60);

                    using (SolidBrush brush = new SolidBrush(buttonColor))
                    {
                        e.Graphics.FillRectangle(brush, e.CellBounds);
                    }

                    string buttonText = dgv.Columns[e.ColumnIndex].Name;
                    TextRenderer.DrawText(e.Graphics, buttonText, dgv.Font, e.CellBounds,
                        Color.White, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

                    e.Handled = true;
                }
            };
        }

        public static string EditCustomer(string customers_id, string first_name, string last_name, string company_name, string email,
            string phone_number, string address, DateTime updated_att)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            {
                try 
                { 
                    conn.Open();
                    string query = @"
                                    UPDATE customers 
                                    SET first_name = @first_name, 
                                        last_name = @last_name, 
                                        company_name = @company_name, 
                                        email = @email, 
                                        phone_number = @phone_number, 
                                        address = @address, 
                                        updated_at = @updated_at  
                                    WHERE customers_id = @customers_id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@company_name", company_name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone_number", phone_number);
                        cmd.Parameters.AddWithValue("@address", address);
                        cmd.Parameters.AddWithValue("@updated_at", updated_att);
                        cmd.Parameters.AddWithValue("@customers_id", customers_id);
                        cmd.ExecuteNonQuery();
                        return "Customer has been updated successfully.";
                    }   
                }

                catch(Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Error: " + ex.Message;
                }
            }

        }

        public static string EditProduct(string product_id, string item_name, string item_code, string item_description, string item_color, string item_category,
                       string supplier, string unit, int stock, decimal price, decimal cost_price, DateTime updated_at)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            {
                try
                {
                    conn.Open();
                    string query = @"
                                UPDATE products 
                                SET item_name = @item_name, 
                                    item_code = @item_code, 
                                    item_description = @item_description, 
                                    item_color = @item_color, 
                                    item_category = @item_category, 
                                    supplier = @supplier, 
                                    unit = @unit, 
                                    stock = @stock, 
                                    item_price = @item_price,
                                    cost_price = @cost_price,
                                    updated_at = @updated_at  
                                WHERE product_id = @product_id";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@item_name", item_name);
                        cmd.Parameters.AddWithValue("@item_code", item_code);
                        cmd.Parameters.AddWithValue("@item_description", item_description);
                        cmd.Parameters.AddWithValue("@item_color", item_color);
                        cmd.Parameters.AddWithValue("@item_category", item_category);
                        cmd.Parameters.AddWithValue("@supplier", supplier);
                        cmd.Parameters.AddWithValue("@unit", unit);
                        cmd.Parameters.AddWithValue("@stock", stock);
                        cmd.Parameters.AddWithValue("@cost_price", cost_price);
                        cmd.Parameters.AddWithValue("@item_price", price);
                        cmd.Parameters.AddWithValue("@product_id", product_id);
                        cmd.Parameters.AddWithValue("@updated_at", updated_at);  // Corrected from @created_at
                        cmd.ExecuteNonQuery();

                        return "Product has been updated successfully.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Error: " + ex.Message;
                }
            }
        }



        public static string EditUser(string userId, string first_name, string last_name, string password)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            {
                try
                {
                    conn.Open();

                    // Generate new username format (same logic as in CreateUser)
                    string[] fname_arr = first_name.Split(' ');
                    string user_name_temp = string.Concat(fname_arr.Select(name => name[0]));

                    string[] lname_arr = last_name.Split(' ');
                    string user_name_temp2 = string.Concat(lname_arr);

                    string new_username = user_name_temp + "_" + user_name_temp2 + userId; // Ensure uniqueness

                    // Check if password is empty
                    string hashedPassword = string.IsNullOrWhiteSpace(password) ? null : BC.HashPassword(password);

                    // Update query including temp_password
                    string query = @"
                                        UPDATE users 
                                        SET first_name = @first_name, 
                                            last_name = @last_name, 
                                            password = @password,
                                            temp_password = @temp_password, 
                                            user_name = @user_name
                                        WHERE id = @id";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@user_name", new_username);
                        cmd.Parameters.AddWithValue("@id", userId);

                        // Update password fields only if the user provided a new password
                        if (hashedPassword != null)
                        {
                            cmd.Parameters.AddWithValue("@password", hashedPassword);
                            cmd.Parameters.AddWithValue("@temp_password", password); // Store plain password
                        }
                        else
                        {
                            cmd.Parameters.AddWithValue("@password", DBNull.Value);
                            cmd.Parameters.AddWithValue("@temp_password", DBNull.Value);
                        }

                        cmd.ExecuteNonQuery();
                        return "User has been updated successfully.";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Error: " + ex.Message;
                }
            }
        }


        public static string CreateCustomer(string first_name, string last_name, string company_name, string email, string phone_number, string addreses, DateTime created_at) 
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            {
                try
                {
                    conn.Open();
                    string query = "INSERT INTO customers (first_name, last_name, company_name, email, phone_number, address, created_at) " +
                                   "VALUES (@first_name, @last_name, @company_name, @email, @phone_number, @address, @created_at)";

                    using MySqlCommand cmd = new MySqlCommand(query, conn);
                    {
                        cmd.Parameters.AddWithValue("@first_name", first_name);
                        cmd.Parameters.AddWithValue("@last_name", last_name);
                        cmd.Parameters.AddWithValue("@company_name", company_name);
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@phone_number", phone_number);
                        cmd.Parameters.AddWithValue("@address", addreses);
                        cmd.Parameters.AddWithValue("@created_at", created_at);

                        cmd.ExecuteNonQuery();

                        return "Customer has been created successfully.";
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return "Error: " + ex.Message;
                }
            }

        }


        public static string CreateProduct(string item_name, string item_code, string item_description, string item_color, string item_category,
                               string supplier, string unit, int stock, decimal price, decimal cost_price, DateTime created_at)
        {
           
              

            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            try
            {
                conn.Open();
                string query = "INSERT INTO products (item_name, item_code, item_description, item_color, item_category, supplier, unit, stock, item_price, cost_price, created_at) " +
                               "VALUES (@item_name, @item_code, @item_description, @item_color, @item_category, @supplier, @unit, @stock, @item_price, @cost_price, @created_at)";

                using MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@item_name", item_name);
                cmd.Parameters.AddWithValue("@item_code", item_code);
                cmd.Parameters.AddWithValue("@item_description", item_description);
                cmd.Parameters.AddWithValue("@item_color", item_color);
                cmd.Parameters.AddWithValue("@item_category", item_category);
                cmd.Parameters.AddWithValue("@supplier", supplier);
                cmd.Parameters.AddWithValue("@unit", unit);
                cmd.Parameters.AddWithValue("@stock", stock);
                cmd.Parameters.AddWithValue("@item_price", price);
                cmd.Parameters.AddWithValue("@cost_price", cost_price);
                cmd.Parameters.AddWithValue("@created_at", created_at);

                cmd.ExecuteNonQuery();

                
                return "Product has been created successfully.";

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error: " + ex.Message;
            }
        }




     
        public static string CreateUser(string fname, string lname,  int user_type_id) 
        {
            MySqlConnection conn = new MySqlConnection(Variables.connString);
            string message ="";


            try 
            {
                string first_name = (fname == "" || fname == "First Name") ? null : fname;
                string last_name = (lname == "" || lname == "Last Name") ? null : lname;
               
                

                if (first_name == null && last_name == null) 
                {
                    message = "Error: Please fill the required field";
                }

                else 
                {
                    conn.Open();

                    string query = "INSERT INTO users (user_type_id, first_name, last_name, user_name, password, temp_password)" +
                        "VALUES (@user_type_id, @first_name, @last_name, @user_name, @password, @temp_password)";

                    MySqlCommand cmd = new MySqlCommand(query, conn);

                    // FUNCTION FOR GETTING FIRST LETTER OF FIRST NAME EVEN FOR USERS THAT HAVE MULTIPLE FIRST NAMES
                    string[] fname_arr = first_name.Split(' ');
                    string user_name_temp = "";

                    for (int i = 0; i < fname_arr.Count(); i++) 
                    {
                        user_name_temp += (fname_arr[i])[0];
                    }

                    // FUNCTION FOR MERGING MULTIPLE SURNAMES INTO ONE 
                    string[] lname_arr = last_name.Split(' ');

                    string mergedSurname = string.Concat(lname_arr);

                    string user_name_temp2 = mergedSurname.Replace(" ", "");


                    string alphanumerics = "abcdefghijklmnopqrstuvwxyz1234567890";

                    StringBuilder password_temp = new StringBuilder();

                    Random rnd = new Random();

                    for (int i = 1; i <= 10; i++)
                    {
                        if (i == 1)
                        {
                            int place_value = rnd.Next(0, 25); //A-Z
                            password_temp.Append(alphanumerics[place_value].ToString());
                        }

                        else 
                        {
                            int place_value = rnd.Next(0, alphanumerics.Count() - 1); //A-Z 1-3
                            password_temp.Append(alphanumerics[place_value].ToString());
                        }
                    }



                    cmd.Parameters.AddWithValue("@user_type_id", user_type_id);
                    cmd.Parameters.AddWithValue("@first_name", first_name);
                    cmd.Parameters.AddWithValue("@last_name", last_name);
                    cmd.Parameters.AddWithValue("@user_name", user_name_temp + "_" + user_name_temp2);
                    cmd.Parameters.AddWithValue("@password", BC.HashPassword(password_temp.ToString()));
                    cmd.Parameters.AddWithValue("@temp_password", password_temp.ToString());
                    cmd.ExecuteNonQuery();
                    long id = cmd.LastInsertedId;

                    string usernameWithUserId = user_name_temp + "_" + user_name_temp2 + id.ToString();

                    string UpdateQuery = "UPDATE users SET user_name = @new_username WHERE id = @user_id";
                    MySqlCommand updateCmd = new MySqlCommand(UpdateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@new_username", usernameWithUserId);
                    updateCmd.Parameters.AddWithValue("@user_id", id);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("User has been created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }

            catch (Exception ex)
            {
                 message = "Error: CreateUser: " + ex.Message;
            }
            finally 
            {
                conn.Close();
            }

            return message;
        }


        public static string CreateOrder(int order_id,
            int customer_id,
            int po_number,
            int dr_number,
            double total_price,
            List<OrderItems> orderItems)
        {

            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            MySqlTransaction transaction = null;  // Declare transaction outside try block
            try
            {
                conn.Open();

                // Start a transaction to ensure both queries succeed or fail together
                transaction = conn.BeginTransaction();

                string insertToOrdersQuery =
                    "INSERT INTO orders (order_id, customers_id, po_number, dr_number, order_date, total_price, created_at) " +
                    "VALUES (@order_id, @customer_id, @po_number, @dr_number, @order_date, @total_price, @created_at)";

                using MySqlCommand cmd = new MySqlCommand(insertToOrdersQuery, conn);

                // Add parameters to avoid SQL injection
                cmd.Parameters.AddWithValue("@order_id", order_id);
                cmd.Parameters.AddWithValue("@customer_id", customer_id);
                cmd.Parameters.AddWithValue("@po_number", po_number);
                cmd.Parameters.AddWithValue("@dr_number", dr_number);
                cmd.Parameters.AddWithValue("@order_date", DateTime.Now);  // Ensure the date is correctly passed
                cmd.Parameters.AddWithValue("@total_price", total_price);
                cmd.Parameters.AddWithValue("@created_at", DateTime.Now);  // Same for created_at

                cmd.ExecuteNonQuery();

                foreach (OrderItems item in orderItems)
                {
                    string insertToOrderItemsQuery =
                        "INSERT INTO order_items (order_id, product_id, quantity, price, created_at) " +
                        "VALUES (@order_id, @product_id, @quantity, @price, @created_at)";

                    using MySqlCommand cmd2 = new MySqlCommand(insertToOrderItemsQuery, conn);

                    // Add parameters to avoid SQL injection
                    cmd2.Parameters.AddWithValue("@order_id", order_id);
                    cmd2.Parameters.AddWithValue("@product_id", item.ProductId);
                    cmd2.Parameters.AddWithValue("@quantity", item.Quantity);
                    cmd2.Parameters.AddWithValue("@price", item.Price);
                    //cmd2.Parameters.AddWithValue("@subtotal", 1);
                    cmd2.Parameters.AddWithValue("@created_at", DateTime.Now);

                    cmd2.ExecuteNonQuery();
                }
                // Commit the transaction if both queries succeed
                transaction.Commit();

                return "Order has been created successfully.";
            }
            catch (Exception ex)
            {
                // Rollback the transaction if an error occurs
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "Error: " + ex.Message;
            }
        }
        public static int GetCustomerId(
            string company_name)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            MySqlTransaction transaction = null;  // Declare transaction outside try block
            try
            {
                conn.Open();

                //string insertToOrdersQuery =
                //    "INSERT INTO orders (order_id, customers_id, po_number, dr_number, order_date, total_price, created_at) " +
                //    "VALUES (@order_id, @customer_id, @po_number, @dr_number, @order_date, @total_price, @created_at)";
                // Query to get the id based on firstname and companyname
                string query = "SELECT customers_id FROM customers WHERE company_name = @company_name";

                using MySqlCommand cmd = new MySqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                cmd.Parameters.AddWithValue("@company_name", company_name);

                // Execute the query and get the result
                var result = cmd.ExecuteScalar();  // Executes the query and returns the first column of the first row

                if (result != null)
                {
                    // If result is not null, convert it to an integer (the id)
                    int customerId = Convert.ToInt32(result);
                    return customerId;
                }
                else
                {
                    Console.WriteLine("No customer found with the given firstname and companyname.");
                }
                return 1;
            }
            catch (Exception ex)
            {
                // Rollback the transaction if an error occurs
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 1;
            }
        }
        public static bool ValidateLogin(string user_name, string password)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            conn.Open();

            string query = "SELECT id, user_name, password FROM users WHERE user_name = @user_name;";

            using (MySqlCommand cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@user_name", user_name);

                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        int id = reader.GetInt32(reader.GetOrdinal("id"));
                        string username = reader.GetString(reader.GetOrdinal("user_name")).Trim();
                        string hashedPassword = reader.GetString(reader.GetOrdinal("password")).Trim();

                        // Verify the hashed password
                        if (BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        {
                            UserSession.UserId = id;
                            UserSession.Username = username;

                            return true;
                        }
                    }
                }
            }
            return false;
        }




        public static void HighlightButton(Button clickedButton, List<Button> buttons)
        {
            foreach (Button btn in buttons)
            {
                btn.BackColor = Color.LightGray; // Default color
                btn.ForeColor = Color.Black;
            }

            clickedButton.BackColor = Color.DarkBlue; // Highlight color
            clickedButton.ForeColor = Color.White;
        }

        public static void HighlightButtonTemporary(Button clickedButton, int duration)
        {
            clickedButton.BackColor = Color.Green;
            clickedButton.ForeColor = Color.White;

            System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer(); 
            timer.Interval = duration;
            timer.Tick += (s, e) =>
            {
                clickedButton.BackColor = Color.LightGray; // Reset color
                clickedButton.ForeColor = Color.Black;
                timer.Stop();
                timer.Dispose();
            };
            timer.Start();
        }
    }
}
