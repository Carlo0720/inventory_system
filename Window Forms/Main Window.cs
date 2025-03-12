using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using inventory_system.Globals;

namespace inventory_system
{
    public partial class mainpage : Form
    {
        public mainpage()
        {
            InitializeComponent();
        }

        private void HighlightSideButton(Button clickedButton)
        {
            List<Button> sideButtons = new List<Button> { userModule_Btn, Dashbrd_Btn, Productlst_Btn };
            Function.HighlightButton(clickedButton, sideButtons);
        }


        private void userModule_Btn_Click(object sender, EventArgs e)
        {

            HighlightSideButton((Button)sender);



            // Load the UserForm into the panel
            contentPanel.Controls.Clear();
            UserForm userForm = new UserForm();
            userForm.Dock = DockStyle.Fill; // Make it fill the panel
            contentPanel.Controls.Add(userForm);
            contentPanel.Visible = true;
            Order_pnl.Visible = false;


        }

        private void Dashbrd_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
        }

        private void Productlst_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
        }

        private void Orders_Btn_Click(object sender, EventArgs e)
        {
            Order_pnl.Controls.Clear();

            Orders_Form Oform = new Orders_Form();
            Oform.Dock = DockStyle.Fill;
            Order_pnl.Visible = true;
            Order_pnl.Controls.Add(Oform);
            contentPanel.Visible = false;
           

        }

        private void mainpage_Load(object sender, EventArgs e)
        {
            contentPanel.Visible = false;
            Order_pnl.Visible = false;

        }
    }
}
