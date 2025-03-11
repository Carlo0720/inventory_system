using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace inventory_system.Globals
{
    class Function
    {
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
    }
}
