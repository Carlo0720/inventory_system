using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Drawing;

namespace inventory_system.Globals
{
    class Function
    {
         private System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();
        public static bool ValidateLogin(string user_name, string password)
        {
            using MySqlConnection conn = new MySqlConnection(Variables.connString);
            conn.Open();
            {
                string query = "SELECT COUNT(*) FROM users WHERE user_name = @user_name AND password = @password;";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user_name", user_name);
                    cmd.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    return count > 0;
                }
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
