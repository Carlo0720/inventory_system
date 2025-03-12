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

        private void mainpage_Load(object sender, EventArgs e)
        {

            


        }

        private void HighlightSideButton(Button clickedButton)
        {
            List<Button> sideButtons = new List<Button> { userModule_Btn, Dashbrd_Btn, Productlst_Btn, Orders_btn };
            Function.HighlightButton(clickedButton, sideButtons);
        }


        private void userModule_Btn_Click(object sender, EventArgs e)
        {

            HighlightSideButton((Button)sender);






            // Load the UserForm into the panel
            contentPanel.Controls.Clear();
            UserForm userForm = new UserForm();
            userForm.Dock = DockStyle.Fill; 
            contentPanel.Controls.Add(userForm);
            contentPanel.Visible = true;

            Orders_pnl.Visible = false;



        }

        private void Dashbrd_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
            contentPanel.Controls.Clear();
        }

        private void Productlst_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
            contentPanel.Controls.Clear();
        }

        private void Orders_btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
            Orders_pnl.Controls.Clear();

            Orders_Form ordersForm = new Orders_Form();
            ordersForm.Dock = DockStyle.Fill;
            Orders_pnl.Controls.Add(ordersForm);

            Orders_pnl.Parent = this; // Order Forms child
            Orders_pnl.Visible = true;
            Orders_pnl.BringToFront();

            contentPanel.Visible = false;

           




        }
    }
}
