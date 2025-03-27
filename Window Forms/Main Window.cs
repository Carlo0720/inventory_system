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

   

            List<Button> sideButtons = new List<Button> { userModule_Btn, Dashbrd_Btn, Productlst_Btn, Orders_btn, customers_btn };
            Function.HighlightButton(clickedButton, sideButtons);
        }

            List<Button> sideButtons = new List<Button> { userModule_Btn, Dashbrd_Btn, Productlst_Btn, Orders_btn, customers_btn };
           

            Orders_pnl.Visible = false;
            productlist_pnl.Visible = false;
            customers_pnl.Visible = false;

            

           

            Orders_pnl.Visible = false;
            productlist_pnl.Visible = false;
            customers_pnl.Visible = false;
            Orders_pnl.Visible = false;
            productlist_pnl.Visible = false;

            contentPanel.Controls.Clear();
            UserForm userForm = new UserForm();
            userForm.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(userForm);
          

            
           
        }

           
        {
          
            contentPanel.Controls.Clear();
        }

        private void Productlst_Btn_Click(object sender, EventArgs e)
        {
           
            contentPanel.Controls.Clear();
            Orders_pnl.Controls.Clear();


            productListUserControl productlistUC = new productListUserControl();
            productlistUC.Dock = DockStyle.Fill;
            productlist_pnl.Controls.Add(productlistUC);
            
            productlist_pnl.Parent = this;
            productlist_pnl.Visible = true;
            productlist_pnl.BringToFront();
        }

        private void Orders_btn_Click(object sender, EventArgs e)
        {

            Orders_pnl.Controls.Clear();

            Orders_Form ordersForm = new Orders_Form();
            ordersForm.Dock = DockStyle.Fill;
            Orders_pnl.Controls.Add(ordersForm);

            Orders_pnl.Parent = this; // Order Forms child
            Orders_pnl.Visible = true;
            

            
            contentPanel.Visible = false;

        }

            
            customers_pnl.Controls.Clear();
            HighlightSideButton((Button)sender);

            contentPanel.Visible = false;
            Orders_pnl.Visible = false;
            productlist_pnl.Visible = false;

            customers_pnl.Visible = true;
            customers_pnl.Controls.Clear();


            Customers_Form customersForm = new Customers_Form();

            customers_pnl.Controls.Add(customersForm);

            customers_pnl.Parent = this;
            customers_pnl.Visible = true;
            customers_pnl.BringToFront();
        }


    }
}