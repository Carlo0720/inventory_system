using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using inventory_system.Globals;

namespace inventory_system
{
    public partial class Form1 : UserControl
    {
        public Form1()
        {
            InitializeComponent();

            // Remove form border
          

            // Apply rounded corners
            this.Region = GetRoundedRegion(120); // Adjust 30 for more/less rounding

            Passwordtxtbox.Text = "";
            Passwordtxtbox.PasswordChar = '*';
            Passwordtxtbox.MaxLength = 12;

            Usertxtbox.Cursor = Cursors.IBeam;
            Passwordtxtbox.Cursor = Cursors.IBeam;
        }

        private Region GetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 170, 85);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return new Region(path);
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            this.Region = GetRoundedRegion(30); // Reapply on resize
        }

        private void Passwordtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Login.PerformClick();
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            Function.HighlightButtonTemporary((Button)sender, 1500);
            mainpage();
            string connString = Variables.connString;
            using MySqlConnection con = new MySqlConnection(connString);
            string user_name = Usertxtbox.Text;
            string password = Passwordtxtbox.Text;

            if (Function.ValidateLogin(user_name, password))
            {
                MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (string.IsNullOrWhiteSpace(Usertxtbox.Text) || string.IsNullOrWhiteSpace(Passwordtxtbox.Text))
            {
                MessageBox.Show("Please enter your username and password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mainpage()
        {
            this.Hide();
            mainpage frm = new mainpage();
            frm.ShowDialog();
            
            Function.HideParentPanel(this);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}