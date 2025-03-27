namespace inventory_system.UserControls.Order
{
    partial class Landing_Page
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Landing_Page));
            pictureBox1 = new PictureBox();
            gradient_SidebarPanel1 = new TestDesigns.Gradient_SidebarPanel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(521, 491);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // gradient_SidebarPanel1
            // 
            gradient_SidebarPanel1.gradientBottom = Color.Empty;
            gradient_SidebarPanel1.gradientTop = Color.Empty;
            gradient_SidebarPanel1.Location = new Point(566, 57);
            gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            gradient_SidebarPanel1.Size = new Size(360, 430);
            gradient_SidebarPanel1.TabIndex = 12;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(975, 28);
            panel1.TabIndex = 13;
            // 
            // Landing_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(974, 513);
            Controls.Add(panel1);
            Controls.Add(gradient_SidebarPanel1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Landing_Page";
            Text = "Landing_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private PictureBox pictureBox1;
        private TestDesigns.Gradient_SidebarPanel gradient_SidebarPanel1;
        private Panel panel1;
    }
}