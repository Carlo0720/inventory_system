using MySql.Data.MySqlClient;
using inventory_system.Globals;




namespace inventory_system
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Passwordtxtbox.Text = "";
            Passwordtxtbox.PasswordChar = '*';
            Passwordtxtbox.MaxLength = 12;

            Usertxtbox.Cursor = Cursors.IBeam;
            Passwordtxtbox.Cursor = Cursors.IBeam;
        }

        private void Passwordtxtbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                Login.PerformClick();
            }
        }

        private System.Windows.Forms.Timer highlightTimer = new System.Windows.Forms.Timer();

        //login
        private void Login_Click(object sender, EventArgs e)
        {
            mainpage();
            Function.HighlightButtonTemporary((Button)sender, 1500);

            // string connString = Variables.connString;
            //using MySqlConnection con = new MySqlConnection(connString);
            //string user_name = Usertxtbox.Text;
            // string password = Passwordtxtbox.Text;





            // if (Function.ValidateLogin(user_name, password))
          //  {
           //     MessageBox.Show("Login Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

               
           // }

            //if (string.IsNullOrWhiteSpace(Usertxtbox.Text) && string.IsNullOrWhiteSpace(Passwordtxtbox.Text)) 
         //   {
           //     MessageBox.Show("Please enter your username and password" , "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          //  }

           // else
          //  {
           //     MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
         //   }
        }



        private void mainpage()
        {
            this.Hide();
            mainpage frm = new mainpage();
            frm.ShowDialog();
            this.Close();
        }

       
    }
}
