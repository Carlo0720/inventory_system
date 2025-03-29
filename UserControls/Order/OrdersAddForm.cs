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
        private OrderRepository orderRepository;
        public BindingList<ProductDTO> products = new BindingList<ProductDTO>();
        private Customer customer;

        public OrdersAddForm(int? Id = null)
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            //productTable = CreateProductTable(dataGridView_Order);
            if (Id is not null)
            {
                //dataGridView_Order.Columns.Clear();
                CreateProductTable(dataGridView_Order);
                int id = (int)Id;
                DataTable dt = orderRepository.GetSpecificOrderItems(id);
                //DataGridViewStyler.ApplyStyles(dataGridView_Order);
                products = ConvertDataTableToBindingList(dt);
                dataGridView_Order.DataSource = products;
                Order order = orderRepository.GetOrderInfo(id);

                // Use LINQ to calculate the sum of the 'quantity' column
                int totalQuantity = dt.AsEnumerable().Sum(row => row.Field<int>("quantity"));
                //totalQuantityLbl.Text = $"Quantity: {totalQuantity.ToString()}";
                totalAmountTbox.Text = $"Price: {order.TotalPrice.ToString()}";
                purchaseOrderTbox.Text = $"Purchase Order No. {order.PurchaseOrderId.ToString()}";
                deliveryReceiptTbox.Text = $"Delivery Receipt No. {order.DeliveryReceipt.ToString()}";
                
                customerNameTbox.Text = order.CustomerName;
                customerDetailsTbox.Text = order.Company;

                addOrderBtn.Text = "Update Order";
            }
            else
            {
                CreateProductTable(dataGridView_Order);
                purchaseOrderTbox.Text = orderRepository.NextPurchaseOrderNumber().ToString();
                deliveryReceiptTbox.Text = orderRepository.NextDeliveryReceiptNumber().ToString();
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

            var existingProduct = products.FirstOrDefault(u => u.product_id == e.product.ProductId);

            if (e.product.Quantity > e.product.Stock)
            {
                MessageBox.Show($"{e.product.ItemName} quantity exceed stock, set quantity to total stock: {e.product.Stock}");
                e.product.Quantity = e.product.Stock;
            }


            if (existingProduct != null)
            {
                // If product exists, update the quantity
                existingProduct.quantity += e.product.Quantity;

                if (existingProduct.quantity > e.product.Stock)
                {
                    MessageBox.Show($"{existingProduct.description} quantity exceed stock, set quantity to total stock: {e.product.Stock}");
                    existingProduct.quantity = e.product.Stock;
                }
            }
            else
            {
                // If product doesn't exist, add the new product
                ProductDTO productDto = new ProductDTO 
                {
                    product_id = e.product.ProductId,
                    description = $"{e.product.ItemName} {e.product.ItemDescription}",
                    price = e.product.ItemPrice,
                    quantity = e.product.Quantity,
                    color = e.product.ItemColor,
                    item_code = e.product.ItemCode
                };
                products.Add(productDto);
            }

            dataGridView_Order.DataSource = products;
            totalAmountTbox.Text = CalculateTotalAmount(products).ToString();
        }

        // Method to create a DataTable with the required columns for Product
        public static DataTable CreateProductTable(DataGridView dataGridView_Order)
        {
            DataTable dt = new DataTable();
            //dt.Columns.Add("Item Code", typeof(string));
            //dt.Columns.Add("Description", typeof(string));
            //dt.Columns.Add("Length", typeof(string));
            //dt.Columns.Add("Quantity", typeof(int));
            //dt.Columns.Add("Color", typeof(string));
            //dt.Columns.Add("Selling Price", typeof(string));

            dataGridView_Order.Columns["product_id"].DataPropertyName = "product_id";
            dataGridView_Order.Columns["item_code"].DataPropertyName = "item_code";
            dataGridView_Order.Columns["description"].DataPropertyName = "description";
            dataGridView_Order.Columns["quantity"].DataPropertyName = "quantity";
            dataGridView_Order.Columns["color"].DataPropertyName = "color";
            dataGridView_Order.Columns["price"].DataPropertyName = "price";

            // Hide the "ID" column from the DataGridView
            dataGridView_Order.Columns["product_id"].Visible = false;

            return dt;
        }
        // Method to create a DataTable with the required columns for Product
        public static DataTable CreateUpdateProductTable(DataGridView dataGridView_Order)
        {
            DataTable dt = new DataTable();


            dataGridView_Order.Columns.Add("item_name", "item_name");
            dataGridView_Order.Columns["product_id"].DataPropertyName = "product_id";
            dataGridView_Order.Columns["item_name"].DataPropertyName = "item_name";
            dataGridView_Order.Columns["item_code"].DataPropertyName = "item_code";
            dataGridView_Order.Columns["description"].DataPropertyName = "item_description";
            dataGridView_Order.Columns["quantity"].DataPropertyName = "quantity";
            dataGridView_Order.Columns["color"].DataPropertyName = "item_color";
            dataGridView_Order.Columns["price"].DataPropertyName = "item_price";

            // Hide the "ID" column from the DataGridView
            dataGridView_Order.Columns["product_id"].Visible = false;
            dataGridView_Order.Columns["item_name"].Visible = false;

            return dt;
        }
        // Method to add or update products from a List<Product> in the DataTable
        public static double CalculateTotalAmount(BindingList<ProductDTO> products)
        {
            double totalPrice = 0;

            // Process each unique product in the grouped list
            foreach (var product in products)
            {
                totalPrice += Convert.ToDouble(product.quantity * product.price);
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
            foreach (ProductDTO product in products)
            {
                // Create a new OrderItems object for each row
                OrderItems item = new OrderItems()
                {
                    // Assuming columns are in order: ProductId, Quantity, Price (adjust column indices as needed)
                    ProductId = product.product_id,  // Replace with actual column name or index
                    Quantity = product.quantity,    // Replace with actual column name or index
                    Price = (float)product.price         // Replace with actual column name or index
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
                TotalPrice = total_price,
                Items = orderItemsList,
            };

            OrderRepository orderRepository = new OrderRepository();

            orderRepository.InsertOrderToDb(order, orderItemsList);

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
                ProductDTO productToDelete = products.FirstOrDefault(p => p.product_id == productIdToDelete);

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

        private BindingList<ProductDTO> ConvertDataTableToBindingList(DataTable dataTable)
        {
            BindingList<ProductDTO> productList = new BindingList<ProductDTO>();

            // Iterate through each row in the DataTable
            foreach (DataRow row in dataTable.Rows)
            {
                // Create a new ProductDTO object for each row
                ProductDTO product = new ProductDTO
                {
                    product_id = Convert.ToInt32(row["product_id"]),
                    item_code = row["item_code"].ToString(),
                    description = $"{row["item_name"].ToString()} {row["item_description"].ToString()}",
                    price = Convert.ToDecimal(row["item_price"]),
                    color = row["item_color"].ToString(),
                    quantity = Convert.ToInt32(row["quantity"])
                };

                // Add the ProductDTO to the BindingList
                productList.Add(product);
            }

            return productList;
        }
    }
}

