using inventory_system.Globals;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Utility
{
    class DatabaseConnection
    {
        private DatabaseConnection() { }

        public MySqlConnection connection { get; private set; }

        private static DatabaseConnection _instance = null;

        public static DatabaseConnection Instance()
        {
            if (_instance == null)
                _instance = new DatabaseConnection();
            return _instance;
        }

        public bool IsConnect()
        {
            if (connection == null)
            {
                if (Variables.connString == null)
                    return false;

                const string connectionString = Variables.connString;
                try
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection error has occured: {ex.Message}");
                }
            }
            return true;
        }
    }
}
