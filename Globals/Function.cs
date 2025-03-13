using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;
using BC = BCrypt.Net.BCrypt;

namespace inventory_system.Globals
{
  
    class Function
    {
         private System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();

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
        public static bool ValidateLogin(string user_name, string password)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            conn.Open();
            {
                string query = "SELECT id, user_name FROM users WHERE user_name = @user_name AND password = @password;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_name", user_name);
                    cmd.Parameters.AddWithValue("@password", password);

                    using (MySqlDataReader reader = cmd.ExecuteReader()) 
                    {
                        if (reader.Read()) 
                        {
                            int id = reader.GetInt32(reader.GetOrdinal("id"));
                            string username = reader.GetString(reader.GetOrdinal("user_name")).Trim();

                            UserSession.UserId = id;
                            UserSession.Username = username;

                            

                            return true;
                        }

                       
                    }
                }
                return false;
            }
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
