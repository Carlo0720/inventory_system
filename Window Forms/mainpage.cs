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
        }

        private void Dashbrd_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
        }

        private void Productlst_Btn_Click(object sender, EventArgs e)
        {
            HighlightSideButton((Button)sender);
        }
    }
}
