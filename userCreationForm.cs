using inventory_system.Globals;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventory_system
{
    public partial class userCreationForm : UserControl
    {
        public userCreationForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            if (this.Parent is Panel parentPanel)
            {
                parentPanel.Visible = false;
            }
        }

        private void user_creation_create_Btn_Click(object sender, EventArgs e)
        {
            //Function.CreateUser()
        }
    }
}
