using inventory_system.Globals;
using inventory_system.UserControls.Order;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Window_Forms
{
    public partial class OrdersAddForm : UserControl
    {
        public OrdersAddForm()
        {
            InitializeComponent();
        }

        private void bigTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Exit_ordrs_Click(object sender, EventArgs e)
        {
            if (this.Parent is System.Windows.Forms.Panel parentPanel)
            {
                parentPanel.Visible = false;
            }
        }

        private void selectCustomerBtn_Click(object sender, EventArgs e)
        {
            // Create a new form for the popup window
            Form popupForm = new Form();
            popupForm.Text = "Select Customer";  // Title of the popup window
            popupForm.StartPosition = FormStartPosition.CenterScreen;  // Center it on the screen
            popupForm.Size = new Size(640, 540);  // Set the size of the popup window
            // Add your OrdersAddForm to the popup window
            OrderAddForm_Customer orderAddForm_Customer = new OrderAddForm_Customer();
            orderAddForm_Customer.Dock = DockStyle.Fill;
            popupForm.Controls.Add(orderAddForm_Customer);

            // Subscribe to the event to receive the selected customer data
            orderAddForm_Customer.CustomerSelected += ModalControl_CustomerSelected;
            // Optionally, make the popup modal (blocking interaction with the main form)
            popupForm.ShowDialog();
        }
        private void ModalControl_CustomerSelected(object sender, CustomerSelectedEventArgs e)
        {
            // Use the selected customer data
            string firstName = e.FirstName;
            string lastName = e.LastName;
            string companyName = e.CompanyName;
            string email = e.Email;
            string phoneNumber = e.PhoneNumber;
            string address = e.Address;

            // Use these values as needed
            MessageBox.Show($"Selected Customer: {firstName} {lastName}");

            Customer_nme.Text = firstName + " " + lastName;
            customerDetailsTbox.Text = companyName;
        }

        private void Add_btn1_Click(object sender, EventArgs e)
        {
            // Create a new form for the popup window
            Form popupForm = new Form();
            popupForm.Text = "Select Item";  // Title of the popup window
            popupForm.StartPosition = FormStartPosition.CenterScreen;  // Center it on the screen
            popupForm.Size = new Size(640, 540);  // Set the size of the popup window
            // Add your OrdersAddForm to the popup window
            OrderAddForm_Item orderAddForm_Item = new OrderAddForm_Item();
            orderAddForm_Item.Dock = DockStyle.Fill;
            popupForm.Controls.Add(orderAddForm_Item);

            // Subscribe to the ProductSelected event to get the selected product
            orderAddForm_Item.ProductSelected += ProductModal_ProductSelected;
            // Optionally, make the popup modal (blocking interaction with the main form)
            popupForm.ShowDialog();
        }
        private void ProductModal_ProductSelected(object sender, ProductSelectedEventArgs e)
        {
            // Handle the product selection here
            MessageBox.Show($"Selected Product: {e.ItemName} ({e.ItemCode})");

            // You can also assign the selected values to parent controls like textboxes
            int productId = e.ProductId;
            string itemName = e.ItemName;
            int itemCode = e.ItemCode;
            string itemDescription = e.ItemDescription;
            string itemColor = e.ItemColor;
            string itemCategory = e.ItemCategory;
            string supplier = e.Supplier;
            int stock = e.Stock;
            string unit = e.Unit;
            double itemPrice = e.ItemPrice;

            //newly added data goes to datagridview
            dataGridView_Order.Rows.Add(itemCode, itemDescription, 1, 1, itemColor, itemPrice);

        }

        private void Add_order_Click(object sender, EventArgs e)
        {
            // Initialize the list to hold the order items
            List<OrderItems> orderItemsList = new List<OrderItems>();

            // Loop through each row in the DataGridView (assuming you have a DataGridView named 'dataGridView')
            foreach (DataGridViewRow row in dataGridView_Order.Rows)
            {
                // Skip the row if it's a new row (usually the last row in the DataGridView for data entry)
                if (!row.IsNewRow)
                {
                    // Create a new OrderItems object for each row
                    OrderItems item = new OrderItems()
                    {
                        // Assuming columns are in order: ProductId, Quantity, Price (adjust column indices as needed)
                        ProductId = Convert.ToInt32(row.Cells["ProductId"].Value),  // Replace with actual column name or index
                        Quantity = Convert.ToInt32(row.Cells["Quantity"].Value),    // Replace with actual column name or index
                        Price = (float)(row.Cells["Price"].Value)         // Replace with actual column name or index
                    };

                    // Add the new item to the list
                    orderItemsList.Add(item);
                }
            }

            int order_id = 1;
            int customer_id = 1;
            int po_number = Convert.ToInt32(Purchase_ordr.Text);
            int dr_number = Convert.ToInt32(Delivery_rcpt.Text);
            double total_price = Convert.ToDouble(textBox8.Text);
            Function.CreateOrder(order_id, customer_id, po_number, dr_number, total_price, orderItemsList);
        }
    }


}

