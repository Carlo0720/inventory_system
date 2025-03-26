using inventory_system.common.Interfaces;
using inventory_system.common.Utility;
using inventory_system.Globals;
using inventory_system.Model;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Repository
{
    public class OrderRepository : Repository, IOrderRepository
    {
        private DatabaseManager databaseManager;

        public int GetItemCount()
        {
            throw new NotImplementedException();
        }

        public async Task CreateOrder(int order_id,
            int customer_id,
            int po_number,
            int dr_number,
            double total_price,
            List<OrderItems> orderItems)
        {
            databaseManager = new DatabaseManager();
            int rowsAffected;
            using (databaseManager)
            {
                //rowsAffected = databaseManager.ExecuteQueryToDataTable(query);
            }
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

                //return "Order has been created successfully.";
            }
            catch (Exception ex)
            {
                // Rollback the transaction if an error occurs
                transaction?.Rollback();
                MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //return "Error: " + ex.Message;
            }
        }

        public async Task<DataTable> GetSpecificOrderItems(int order_id)
        {
            databaseManager = new DatabaseManager();
            using (databaseManager)
            {
                return databaseManager.ExecuteQueryGetProducts(order_id);
            }
        }

        public void InsertOrderToDb(Order order, List<OrderItems> orderItems)
        {
            databaseManager = new DatabaseManager();
            int order_id = order.PurchaseOrderId;
            using (databaseManager)
            {
                databaseManager.ExecuteCreateOrders(order);
                //foreach (var orderItem in orderItems)
                //{
                //    databaseManager.ExecuteCreateOrderItems(order_id, orderItem);
                //}
            }
        }

        public int NextPurchaseOrderNumber()
        {
            databaseManager = new DatabaseManager();
            using (databaseManager)
            {
                return databaseManager.GetNextPurchaseOrderId();
            }
        }




            //public void AddColumnsToDataGridView(DataGridView myDataGridView)
            //{
            //    myDataGridView.Columns.Clear();

            //    myDataGridView.Resize += OnResize;

            //    // Define column names and their corresponding width percentage
            //    string[] columnNames = { "purchase_order", "delivery_receipt", "customer_name", "customer_details", "total_amount", "date"};
            //    string[] headerTexts = { "P.O. #", "D.R. #", "Customer Name", "Customer Details", "Total Amount(PHP)", "Date"};
            //    string[] dataPropertyName = { "po_number", "dr_number", "customer_name", "company_name", "total_price", "created_at"};
            //    double[] columnWidthsPercentage = { 10, 10, 30, 25, 15, 10 }; // Percentages for each column

            //    //// Add columns to DataGridView
            //    //foreach (var columnName in columnNames)
            //    //{
            //    //    myDataGridView.Columns.Add(columnName);
            //    //}
            //    //// Add columns to DataGridView
            //    //foreach (var head in headerTexts)
            //    //{
            //    //    myDataGridView.Columns.Add(head);
            //    //}
            //    //// Add columns to DataGridView
            //    //foreach (var columnName in columnNames)
            //    //{
            //    //    myDataGridView.Columns.Add(columnName, headerTexts);
            //    //}

            //    for (int i = 0; i < columnWidthsPercentage.Length; i++)
            //    {
            //        myDataGridView.Columns.Add(columnNames[i], headerTexts[i]);
            //        myDataGridView.Columns[columnNames[i]].DataPropertyName = dataPropertyName[i];
            //    }

            //    // Set column widths based on the percentage of the DataGridView width
            //    SetColumnWidthsByPercentage(columnWidthsPercentage, myDataGridView);
            //}

            //private void SetColumnWidthsByPercentage(double[] columnWidthsPercentage, DataGridView myDataGridView)
            //{
            //    // Ensure the number of column widths matches the number of columns
            //    if (columnWidthsPercentage.Length != myDataGridView.Columns.Count)
            //    {
            //        MessageBox.Show("Number of width percentages must match number of columns.");
            //        return;
            //    }

            //    // Calculate the total width of the DataGridView
            //    int totalWidth = myDataGridView.Width;

            //    // Loop through each column and set its width as a percentage of the total width
            //    for (int i = 0; i < myDataGridView.Columns.Count; i++)
            //    {
            //        double percentage = columnWidthsPercentage[i];
            //        int newWidth = (int)((percentage / 100) * totalWidth);
            //        myDataGridView.Columns[i].Width = newWidth;
            //    }
            //}

            ////private EventHandler OnResize(EventArgs e)
            ////{
            ////    base.OnResize(e);
            ////    // Adjust column widths if the form is resized
            ////    SetColumnWidthsByPercentage(new double[] { 10, 30, 40, 20 });
            ////}

            //private void OnResize(object sender, EventArgs e)
            //{
            //    MessageBox.Show($"This is {sender} sending and {e}");

            //    if (sender is DataGridView DGV)
            //    {
            //        // Adjust column widths if the form is resized
            //        SetColumnWidthsByPercentage(new double[] { 10, 10, 30, 25, 15, 10 }, DGV);
            //        //base.OnResize(e);
            //    }
            //}

        }
    }
