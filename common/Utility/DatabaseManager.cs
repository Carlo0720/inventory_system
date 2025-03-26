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
        public DataTable ExecuteQueryToDataTable(string query)
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
        //Used to get data from database and returns the data in a datatable format
        public DataTable ExecuteQueryGetProducts(int order_id)
        {
            var databaseConnection = DatabaseConnection.Instance();
            DataTable dataTable = new DataTable();

            using (MySqlCommand command = new MySqlCommand(SD.SelectSpecificOrderProducts, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@oi.order_id", order_id);

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
        public int ExecuteNonQuery(string query)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    rowsAffected = command.ExecuteNonQuery();
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
        public int ExecuteCreateOrders(Model.Order order)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(SD.InsertToOrders, databaseConnection.connection))
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

                    rowsAffected = command.ExecuteNonQuery();
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
        public int ExecuteCreateOrderItems(int order_id, OrderItems orderItem)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(SD.InsertToOrderItems, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@order_id", order_id);
                    command.Parameters.AddWithValue("@product_id", orderItem.ProductId);
                    command.Parameters.AddWithValue("@quantity", orderItem.Quantity);
                    command.Parameters.AddWithValue("@price", orderItem.Price);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);  

                    rowsAffected = command.ExecuteNonQuery();
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

/* Async
 * 
 * public async Task<object> ExecuteScalarScalar(string query)
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
 * 
 * 
 */