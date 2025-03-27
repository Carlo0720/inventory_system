using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace inventory_system.UserControls.Order
{
    public partial class Landing_Page : Form
    {


        
   
        public Landing_Page()
        {
            InitializeComponent();

         


            // Remove default border
            this.FormBorderStyle = FormBorderStyle.None;

            // Apply rounded corners
            this.Region = GetRoundedRegion(120); // Adjust 30 for more/less rounding
        }

        private Region GetRoundedRegion(int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
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

        private void Lnd_Logn_Click(object sender, EventArgs e)
        {

        }
    }
}