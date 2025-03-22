using inventory_system.common.Interfaces;
using inventory_system.common.Utility;
using Org.BouncyCastle.Tls;
using System;
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
