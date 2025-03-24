using inventory_system.Model;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace inventory_system.common.Utility
{
    class DatabaseManager : IDisposable
    {
        private MySqlConnection connection;
        public DatabaseManager()
        {
            Connect();
        }
        private void Connect() 
        {
            if (connection == null)
            {
                DatabaseConnection.Instance().IsConnect();
            }
        }
        //Used to get data from database and returns the data in a datatable format
        public async Task<DataTable> ExecuteQueryToDataTable(string query)
        {
            var databaseConnection = DatabaseConnection.Instance();
            DataTable dataTable = new DataTable();

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        dataTable.Load(reader);
                    }
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }
            return dataTable;
        }
        //Used to run an sql query like create, update, or delete
        public async Task<int> ExecuteNonQuery(string query)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }
            return rowsAffected;
        }
        //Used to run an sql query like create, update, or delete
        public async Task<int> ExecuteCreateOrders(string query, Order order)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@customer_id", order.CustomerId);
                    command.Parameters.AddWithValue("@po_number", order.PurchaseOrderId);
                    command.Parameters.AddWithValue("@dr_number", order.DeliveryReceipt);
                    command.Parameters.AddWithValue("@order_date", DateTime.Now); 
                    command.Parameters.AddWithValue("@total_price", order.TotalPrice);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);  // Same for created_at

                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }
            return rowsAffected;
        }
        //Used to run an sql query like create, update, or delete
        public async Task<int> ExecuteCreateOrderItems(string query, Product product)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@item_name", product.ItemName);
                    command.Parameters.AddWithValue("@item_code", product.ItemCode);
                    command.Parameters.AddWithValue("@item_description", product.ItemDescription);
                    command.Parameters.AddWithValue("@item_color", product.ItemColor);
                    command.Parameters.AddWithValue("@item_category", product.ItemCategory);
                    command.Parameters.AddWithValue("@supplier", product.Supplier);  
                    command.Parameters.AddWithValue("@unit", product.Unit);  
                    command.Parameters.AddWithValue("@stock", product.Stock); 
                    command.Parameters.AddWithValue("@item_price", product.ItemPrice);  
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);  

                    rowsAffected = await command.ExecuteNonQueryAsync();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }
            return rowsAffected;
        }
        //Used to run an sql query that needs to return something, like count or a record

        public object ExecuteScalar(string query)
        {
            var databaseConnection = DatabaseConnection.Instance();
            object ret = null;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    ret = command.ExecuteScalar();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }

            return ret;
        }
        public async Task<object> ExecuteScalarScalar(string query)
        {
            var databaseConnection = DatabaseConnection.Instance();
            object ret = null;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    ret = await command.ExecuteScalarAsync();
                }
                catch (MySqlException e)
                {
                    MessageBox.Show($"MySql error {e.Message}");
                }
                catch (Exception e)
                {
                    MessageBox.Show($"An error has occured {e.Message}");
                }
            }

            return ret;
        }
        public void Dispose()
        {
            if (connection != null)
            {
                try
                {
                    connection.CloseAsync();
                    connection.DisposeAsync();
                    connection = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Connection close error: {ex.Message}");
                }
            }
        }
    }
}
