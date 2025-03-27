using inventory_system.Globals;
using inventory_system.Model;
using inventory_system.Repository;
using inventory_system.style;
using inventory_system.UserControls.Order;
using ReaLTaiizor.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system.Window_Forms
{
    public partial class OrdersAddForm : UserControl
    {
        public BindingList<Product> products = new BindingList<Product>();
        private Customer customer;

        // Create a DataTable to hold the products
        DataTable productTable = new DataTable();
        public OrdersAddForm()
        {
            InitializeComponent();

           

            dataGridView_Order.Columns.Clear();
            productTable = CreateProductTable();
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
            customer = new Customer()
            {
                Id = e.customer.Id,
                Name = e.customer.Name,
            };
            int id = e.customer.Id;
            string name = e.customer.Name;
            string companyName = e.customer.CompanyName;
            string email = e.customer.Email;

            // Use these values as needed
            MessageBox.Show($"Selected Customer: {name}");

            customerNameTbox.Text = name;
            customerDetailsTbox.Text = companyName;
        }

        private void Add_btn1_Click(object sender, EventArgs e)
        {
            // Create a new form for the popup window
            Form popupForm = new Form();
            popupForm.Text = "Select Item";  // Title of the popup window
            popupForm.StartPosition = FormStartPosition.CenterScreen;  // Center it on the screen
            popupForm.Size = new Size(1371, 619);  // Set the size of the popup window
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
            MessageBox.Show($"Selected Product: {e.product.ItemName} ({e.product.ItemCode})");

            var existingProduct = products.FirstOrDefault(u => u.ProductId == e.product.ProductId);

            if (e.product.Quantity > e.product.Stock)
            {
                MessageBox.Show($"{e.product.ItemName} quantity exceed stock, set quantity to total stock: {e.product.Stock}");
                e.product.Quantity = e.product.Stock;
            }


            if (existingProduct != null)
            {
                // If product exists, update the quantity
                existingProduct.Quantity += e.product.Quantity;

                if (existingProduct.Quantity > existingProduct.Stock)
                {
                    MessageBox.Show($"{existingProduct.ItemName} quantity exceed stock, set quantity to total stock: {existingProduct.Stock}");
                    existingProduct.Quantity = existingProduct.Stock;
                }
            }
            else
            {
                // If product doesn't exist, add the new product
                products.Add(e.product);
            }

            // You can also assign the selected values to parent controls like textboxes

            //if (dataGridView_Order.Rows.Count > 0)
            //    // Assuming your DataGridView is bound to a DataTable
            //    (dataGridView_Order.DataSource as DataTable).Clear();
            //if(products.Any(u => u.))
            //products.Add(e.product);
            // Add or update the products in the DataTable
            //AddOrUpdateProducts(productTable, products);

            //int productId = e.ProductId;
            //string itemName = e.ItemName;
            //string itemCode = e.ItemCode;
            //string itemDescription = e.ItemDescription;
            //string itemColor = e.ItemColor;
            //string itemCategory = e.ItemCategory;
            //string supplier = e.Supplier;
            //int quantity = e.Quantity;
            //string unit = e.Unit;
            //decimal itemPrice = e.ItemPrice;

            //if (dataGridView_Order.Rows.Count > 0)
            //    dataGridView_Order.Rows.Clear();
            dataGridView_Order.DataSource = products;
            totalAmountTbox.Text = CalculateTotalAmount(products).ToString();

            //newly added data goes to datagridview
            //dataGridView_Order.Rows.Add(itemCode, itemDescription, 1, 1, itemColor, itemPrice);

        }

        // Method to create a DataTable with the required columns for Product
        public static DataTable CreateProductTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Item Code", typeof(string));
            dt.Columns.Add("Description", typeof(string));
            dt.Columns.Add("Length", typeof(string));
            dt.Columns.Add("Quantity", typeof(int));
            dt.Columns.Add("Color", typeof(string));
            dt.Columns.Add("Selling Price", typeof(string));

            //// Set the primary key
            //dt.PrimaryKey = new DataColumn[] { dt.Columns["ProductID"] };

            return dt;
        }
        // Method to add or update products from a List<Product> in the DataTable
        public static void AddOrUpdateProducts(DataTable dt, List<Product> products)
        {
            foreach (var product in products)
            {
                DataRow newRow = dt.NewRow();
                newRow["Item Code"] = product.ItemCode;
                newRow["Description"] = product.ItemDescription;
                newRow["Length"] = product.Length;
                newRow["Quantity"] = product.Quantity;
                newRow["Color"] = product.ItemColor;
                newRow["Selling Price"] = product.ItemPrice;
                dt.Rows.Add(newRow);
            }
        }
        // Method to add or update products from a List<Product> in the DataTable
        public static double CalculateTotalAmount(BindingList<Product> products)
        {
            double totalPrice = 0;

            // Process each unique product in the grouped list
            foreach (var product in products)
            {
                totalPrice += Convert.ToDouble(product.Quantity * product.ItemPrice);
            }
            return totalPrice;
        }

        private void Add_order_Click(object sender, EventArgs e)
        {
            #region Validation
            if (string.IsNullOrEmpty(customerNameTbox.Text) && string.IsNullOrEmpty(customerDetailsTbox.Text))
            {

                MessageBox.Show($"Missing input fields: Customer Name and Customer Details");
                return;
            }
            if (string.IsNullOrEmpty(purchaseOrderTbox.Text))
            {
                MessageBox.Show($"Missing input fields: Purchase Order");
                return;
            }
            if (string.IsNullOrEmpty(deliveryReceiptTbox.Text))
            {
                MessageBox.Show($"Missing input fields: Delivery Receipt");
                return;
            }
            if (dataGridView_Order.Rows.Count == 0)
            {
                MessageBox.Show($"No items");
                return;
            }
            #endregion
            // Initialize the list to hold the order items
            List<OrderItems> orderItemsList = new List<OrderItems>();

            // Loop through each row in the DataGridView (assuming you have a DataGridView named 'dataGridView')
            foreach (Product product in products)
            {
                // Create a new OrderItems object for each row
                OrderItems item = new OrderItems()
                {
                    // Assuming columns are in order: ProductId, Quantity, Price (adjust column indices as needed)
                    ProductId = product.ProductId,  // Replace with actual column name or index
                    Quantity = product.Quantity,    // Replace with actual column name or index
                    Price = (float)product.ItemPrice         // Replace with actual column name or index
                };

                // Add the new item to the list
                orderItemsList.Add(item);
            }

            int order_id = Convert.ToInt32(purchaseOrderTbox.Text);
            int customer_id = Function.GetCustomerId(customerDetailsTbox.Text);
            int po_number = Convert.ToInt32(purchaseOrderTbox.Text);
            int dr_number = Convert.ToInt32(deliveryReceiptTbox.Text);
            double total_price = Convert.ToDouble(totalAmountTbox.Text);

            Order order = new()
            {
                CustomerId = customer_id,
                PurchaseOrderId = po_number,
                DeliveryReceipt = dr_number,
                TotalPrice = total_price
            };

            OrderRepository orderRepository = new OrderRepository();



            Function.CreateOrder(order_id, customer.Id, po_number, dr_number, total_price, orderItemsList);

            Form parentForm = this.FindForm();
            if (parentForm != null)
            {
                parentForm.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            // Ensure that a row is selected
            if (dataGridView_Order.SelectedRows.Count > 0)
            {
                // Get the selected row index
                int selectedIndex = dataGridView_Order.SelectedRows[0].Index;

                // Get the ProductId of the selected product (assuming ProductId is in the first column)
                int productIdToDelete = Convert.ToInt32(dataGridView_Order.SelectedRows[0].Cells[0].Value);

                // Find the product in the BindingList that matches the selected ProductId
                Product productToDelete = products.FirstOrDefault(p => p.ProductId == productIdToDelete);

                // If the product is found in the list
                if (productToDelete != null)
                {
                    // Remove the product from the BindingList
                    products.Remove(productToDelete);
                    totalAmountTbox.Text = CalculateTotalAmount(products).ToString();
                }
                else
                {
                    MessageBox.Show("Product not found.");
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete.");
            }
        }

        private void itemShockTbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView_Order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Check if the clicked row is valid
            if (e.RowIndex >= 0)
            {
                // Get the selected row (using e.RowIndex)
                DataGridViewRow selectedRow = dataGridView_Order.Rows[e.RowIndex];

            }
        }

        private void Order_dtle_Click(object sender, EventArgs e)
        {

        }
    }


}

