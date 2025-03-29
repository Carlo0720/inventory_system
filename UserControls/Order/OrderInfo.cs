using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Repository;
using inventory_system.style;
using inventory_system.Model;
using System.Data.Common;
using inventory_system.Globals;

namespace inventory_system.UserControls.Order
{
    public partial class OrderInfo: UserControl
    {
        OrderRepository orderRepository;
        public OrderInfo(int id)
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            DataTable dt = orderRepository.GetSpecificOrderItems(id, true);
            //DataGridViewStyler.ApplyStyles(orderItemsDatagridview);
            //Function.StyleDataGridView(orderItemsDatagridview);

            orderItemsDatagridview.Columns["item_code"].DataPropertyName = "item_code";
            orderItemsDatagridview.Columns["product_id"].DataPropertyName = "product_id";
            orderItemsDatagridview.Columns["description"].DataPropertyName = "item_description";
            orderItemsDatagridview.Columns["quantity"].DataPropertyName = "quantity";
            orderItemsDatagridview.Columns["price"].DataPropertyName = "price";

            orderItemsDatagridview.DataSource = dt;
            Model.Order order = orderRepository.GetOrderInfo(id);

            // Set all columns to align header and data to the center
            foreach (DataGridViewColumn column in orderItemsDatagridview.Columns)
            {
                column.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            }

            // Hide the "ID" column from the DataGridView
            orderItemsDatagridview.Columns["product_id"].Visible = false;

            // Use LINQ to calculate the sum of the 'quantity' column
            int totalQuantity = dt.AsEnumerable().Sum(row => row.Field<int>("quantity"));
            //totalQuantityLbl.Text = $"Quantity: {totalQuantity.ToString()}";
            //totalPriceLbl.Text = $"Price: {order.TotalPrice.ToString()}";
            puchaseOrderLbl.Text = $"Purchase Order No. {order.PurchaseOrderId.ToString()}";
            deliveryReceiptLbl.Text = $"Delivery Receipt No. {order.DeliveryReceipt.ToString()}";
            nameLbl.Text = order.CustomerName;

            //totalQuantityLbl.Visible = false; 
            //totalPriceLbl.Visible = false;
            //smallLabel1.Visible = false;

            DataRow row = dt.NewRow();
            // Manually map the data to the correct columns
            //row["product_id"] = Convert.ToInt32(reader["product_id"]);
            //row["item_code"] = reader["item_code"];
            row["item_description"] = "TOTAL";
            row["quantity"] = totalQuantity.ToString();
            row["price"] = Convert.ToDecimal(order.TotalPrice).ToString("F2");
            dt.Rows.Add(row);
        }

        private void AddColumn(string propertyName, string headerText)
        {
            // Create a new column
            DataGridViewTextBoxColumn column = new DataGridViewTextBoxColumn
            {
                DataPropertyName = propertyName, // Binds to the property of the data source
                Name = propertyName,            // The name of the column
                HeaderText = headerText         // The text shown in the column header
            };

            // Add the column to the DataGridView
            orderItemsDatagridview.Columns.Add(column);
        }
    }
}
