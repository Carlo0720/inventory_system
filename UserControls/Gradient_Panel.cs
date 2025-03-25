using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestDesigns
{
    public class Gradient_SidebarPanel : Panel
    {
        public Color gradientTop { get; set; }
        public Color gradientBottom { get; set; }
        public Gradient_SidebarPanel()
        {
            this.Resize += Gradient_SidebarPanel_Resize;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            LinearGradientBrush linear = new LinearGradientBrush(this.ClientRectangle, this.gradientTop, this.gradientBottom, 90f);
            Graphics g = e.Graphics;
            g.FillRectangle(linear, this.ClientRectangle);
            base.OnPaint(e);

        }
        private void Gradient_SidebarPanel_Resize(object sender, EventArgs e)
        {
            this.Invalidate(); // Redraw the panel when resized
        }
    }
}
