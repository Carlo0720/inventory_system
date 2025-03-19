using inventory_system.UserControls.Order;
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
            if (this.Parent is Panel parentPanel)
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

            // Re-enable the parent form after modal interaction
            this.Enabled = true;

            Customer_nme.Text = firstName + " "  + lastName;
            customerDetailsTbox.Text = companyName;
        }
    }


}

