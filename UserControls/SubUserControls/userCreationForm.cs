using inventory_system.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{


    public partial class userCreationForm : UserControl
    {
        private int selectedUserTypeId = -1;

        public class ComboBoxItem
        {
            public string Text { get; set; }
            public int Value { get; set; }


            public ComboBoxItem(string text, int value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        public userCreationForm()
        {
            InitializeComponent();

           


            crownComboBoxUserType.Items.Clear();

            ComboBoxItem item1 = new ComboBoxItem("Super Admin", 1);
            ComboBoxItem item2 = new ComboBoxItem("Admin", 2);
            ComboBoxItem item3 = new ComboBoxItem("User", 3);

            crownComboBoxUserType.Items.Add(item1);
            crownComboBoxUserType.Items.Add(item2);
            crownComboBoxUserType.Items.Add(item3);

            crownComboBoxUserType.SelectedIndex = 0;
        }

      



        public event Action UserAdded;

        private void Close_btn_Click_1(object sender, EventArgs e)
        {
            UserAdded?.Invoke();
            Function.HideParentPanel(this);

        }

        private void crownComboBoxUserType_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (crownComboBoxUserType.SelectedItem is ComboBoxItem selectedItem)
            {
                selectedUserTypeId = selectedItem.Value;
            }
        }



        private void Create_btnUser_Click(object sender, EventArgs e)
        {
            if (crownTextBoxFrstNme.Text == "" || crownTextBoxFrstNme.Text == null)
            {
                MessageBox.Show("Please enter the first name of the user.");
            }
            if (crownTextBoxLstNme.Text == "" || crownTextBoxFrstNme.Text == null)
            {
                MessageBox.Show("Please enter the last name name of the user.");
            }



            if (selectedUserTypeId == -1)
            {
                MessageBox.Show("Please select a user type first.");
                return;
            }

            Function.CreateUser(crownTextBoxFrstNme.Text, crownTextBoxLstNme.Text, selectedUserTypeId);
        }

     
    }
}
