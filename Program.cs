using inventory_system.UserControls.Order;
using inventory_system;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        using (Landing_Page landingPage = new Landing_Page())
        {
            if (landingPage.ShowDialog() == DialogResult.OK) // Wait for login
            {
                Application.Run(new mainpage()); // Open MainPage after login
            }
        }
    }
}
