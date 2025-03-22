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

namespace inventory_system
{
    public partial class CustomersAddUserControl : UserControl
    {
        public CustomersAddUserControl()
        {
            InitializeComponent();
        }

        public event Action CustomerAdded;


        private void add_product_close_btn_Click(object sender, EventArgs e)
        {
            CustomerAdded?.Invoke();
           Function.HideParentPanel(this);

        }

        private void add_product_btn_Click(object sender, EventArgs e)
        {
            var fields = new Dictionary<string, string>
            {
                { "First Name", firstname_txtbox.Text },
                { "Last Name", lastname_txtbox.Text },
                { "Company Name", companyname_txtbox.Text },
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

            string first_name = firstname_txtbox.Text;
            string last_name = lastname_txtbox.Text;
            string company_name = companyname_txtbox.Text;
            string email = email_txtbox.Text;
            string phone = phonenumber_txtbox.Text;
            string address = address_txtbox.Text;
            DateTime created_at = DateTime.Now;

            Function.CreateCustomer(first_name, last_name, company_name, email, phone, address, created_at);
            MessageBox.Show("Customer created successfully", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void CustomersAddUserControl_Load(object sender, EventArgs e)
        {
          
        }
    }
}
