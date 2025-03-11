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
        }

        //login
        private void Login_Click(object sender, EventArgs e)
        {
                

            string connString = Variables.connString;
            using MySqlConnection con = new MySqlConnection(connString);
            string user_name = Usertxtbox.Text;
            string password = Passwordtxtbox.Text;

            if (Function.ValidateLogin(user_name, password))    
            {
                MessageBox.Show("Login Successful!");

                mainpage();
            }


            else 
            {
                MessageBox.Show("Login Failed");
            }     
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
