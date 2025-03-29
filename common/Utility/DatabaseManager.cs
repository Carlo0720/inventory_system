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
        #region Common
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
        #endregion
        //Used to run an sql query like create, update, or delete
        #region Orders
        public int ExecuteCreateOrders(Model.Order order, int order_id = 0)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            MySqlTransaction myTrans;
            myTrans = databaseConnection.connection.BeginTransaction();

            using (MySqlCommand command = new MySqlCommand(SD.InsertToOrders, databaseConnection.connection))
            {
                try
                {
                    command.Transaction = myTrans;
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@customer_id", order.CustomerId);
                    command.Parameters.AddWithValue("@po_number", order.PurchaseOrderId);
                    command.Parameters.AddWithValue("@dr_number", order.DeliveryReceipt);
                    command.Parameters.AddWithValue("@order_date", DateTime.Now); 
                    command.Parameters.AddWithValue("@total_price", order.TotalPrice);
                    command.Parameters.AddWithValue("@created_at", DateTime.Now);  // Same for created_at

                    rowsAffected = command.ExecuteNonQuery();

                    // Now get the last inserted order ID
                    using (MySqlCommand getLastIdCommand = new MySqlCommand("SELECT LAST_INSERT_ID();", databaseConnection.connection))
                    {
                        // Execute the query to get the last inserted ID
                        order_id = Convert.ToInt32(getLastIdCommand.ExecuteScalar());
                    }
                    foreach (OrderItems item in order.Items)
                    {
                        ExecuteCreateOrderItems(order_id, item, myTrans);
                    }

                    myTrans.Commit();
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
            return order_id;
        }
        //Used to run an sql query like create, update, or delete
        public int ExecuteCreateOrderItems(int order_id, OrderItems orderItem, MySqlTransaction myTrans)
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

                    ExecuteRemoveFromStock(orderItem, myTrans);

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
        public void ExecuteRemoveFromStock(OrderItems orderItem, MySqlTransaction myTrans)
        {
            var databaseConnection = DatabaseConnection.Instance();
            int rowsAffected = 0;

            using (MySqlCommand command = new MySqlCommand(SD.UpdateProductStock, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@product_id", orderItem.ProductId);
                    command.Parameters.AddWithValue("@quantity", orderItem.Quantity);

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
        }
        public int GetNextPurchaseOrderId()
        {
            var databaseConnection = DatabaseConnection.Instance();
            int nextPurchaseOrderId = 0;

            // Query to get the latest purchase_order_id
            string query = "SELECT MAX(po_number) FROM orders";

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    // Execute the query and get the result
                    var result = command.ExecuteScalar();

                    // If the result is not null (meaning there are rows in the table), increment the value
                    if (result != DBNull.Value)
                    {
                        nextPurchaseOrderId = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        // If there is no record in the table yet, start with 1
                        nextPurchaseOrderId = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    // Handle exception (e.g., logging)
                }
            }

            return nextPurchaseOrderId;
        }
        public int GetNextDeliverReceiptId()
        {
            var databaseConnection = DatabaseConnection.Instance();
            int nextPurchaseOrderId = 0;

            // Query to get the latest purchase_order_id
            string query = "SELECT MAX(dr_number) FROM orders";

            using (MySqlCommand command = new MySqlCommand(query, databaseConnection.connection))
            {
                try
                {
                    // Execute the query and get the result
                    var result = command.ExecuteScalar();

                    // If the result is not null (meaning there are rows in the table), increment the value
                    if (result != DBNull.Value)
                    {
                        nextPurchaseOrderId = Convert.ToInt32(result) + 1;
                    }
                    else
                    {
                        // If there is no record in the table yet, start with 1
                        nextPurchaseOrderId = 1;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                    // Handle exception (e.g., logging)
                }
            }

            return nextPurchaseOrderId;
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
                    command.Parameters.AddWithValue("@order_id", order_id);

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

        public Model.Order ExecuteQueryGetOrder(int order_id)
        {
            var databaseConnection = DatabaseConnection.Instance();
            Model.Order ret = null;

            using (MySqlCommand command = new MySqlCommand(SD.SelectOrder, databaseConnection.connection))
            {
                try
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@order_id", order_id);

                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            ret = new Model.Order()
                            {
                                Id = order_id,
                                CreatedDate = reader.GetDateTime(1), // Second column: created_at
                                CustomerName = reader.GetString(2), // Third column: customer_name
                                Company = reader.GetString(3), // Fourth column: company_name
                                PurchaseOrderId = reader.GetInt32(4), // Fifth column: po_number
                                DeliveryReceipt = reader.GetInt32(5), // Sixth column: dr_number
                                TotalPrice = reader.GetDouble(6), // Seventh column: total_price
                            };
                        }
                        else
                        {
                            MessageBox.Show($"No record found for the order id {order_id}.");
                        }
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
            return ret;
        }

        #endregion
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