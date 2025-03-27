using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Globals;

namespace inventory_system.UserControls.SubUserControls
{
    public partial class editCustomerUserControl : UserControl
    {
        private string customerId;

        public editCustomerUserControl(string customerId)
        {
            InitializeComponent();
            this.customerId = customerId;
        }

        private void Label_add_Click(object sender, EventArgs e)
        {

        }

        private void edit_costumer_btn_Click(object sender, EventArgs e)
        {
            var fields = new Dictionary<string, string>
            {
                { "First Name", edit_firstname_txtbox.Text },
                { "Last Name", edit_lastname_txtbox.Text },
                { "Company Name", edit_companyname_txtbox.Text },
            };

            // Check if any field is empty
            foreach (var field in fields)
            {
                if (string.IsNullOrWhiteSpace(field.Value))  // Checks for null, empty, or whitespace
                {
                    MessageBox.Show($"Error: {field.Key} cannot be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Stop execution if any field is empty
                }
            }

            string first_name = edit_firstname_txtbox.Text;
            string last_name = edit_lastname_txtbox.Text;
            string company_name = edit_companyname_txtbox.Text;
            string email = edit_email_txtbox.Text;
            string phone_number = edit_phonenumber_txtbox.Text;
            string address = edit_address_txtbox.Text;
            DateTime updated_at = DateTime.Now;



            Function.EditCustomer(customerId, first_name, last_name, company_name, email, phone_number, address, updated_at);
            MessageBox.Show("Customer updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void edit_email_txtbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_customers_close_btn_Click(object sender, EventArgs e)
        {
            Function.HideParentPanel(this);
        }
    }
}
