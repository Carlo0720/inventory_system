namespace inventory_system
{
    partial class mainpage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainpage));
            panel1 = new Panel();
            Orders_pnl = new Panel();
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            Order_pnl = new Panel();
            productlist_pnl = new Panel();
            customers_pnl = new Panel();
            contentPanel = new Panel();
            customers_btn = new Button();
            Orders_btn = new Button();
            Productlst_Btn = new Button();
            userModule_Btn = new Button();
            Dashbrd_Btn = new Button();
            gradient_SidebarPanel1 = new TestDesigns.Gradient_SidebarPanel();
            panel1.SuspendLayout();
            Order_pnl.SuspendLayout();
            productlist_pnl.SuspendLayout();
            contentPanel.SuspendLayout();
            gradient_SidebarPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(Orders_pnl);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = SystemColors.ControlLightLight;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 31);
            panel1.TabIndex = 0;
            // 
            // Orders_pnl
            // 
            Orders_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Orders_pnl.Location = new Point(154, 32);
            Orders_pnl.Name = "Orders_pnl";
            Orders_pnl.Size = new Size(955, 615);
            Orders_pnl.TabIndex = 0;
            // 
            // nightControlBox1
            // 
            nightControlBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            nightControlBox1.BackColor = Color.Transparent;
            nightControlBox1.CloseHoverColor = Color.FromArgb(199, 80, 80);
            nightControlBox1.CloseHoverForeColor = Color.White;
            nightControlBox1.DefaultLocation = true;
            nightControlBox1.DisableMaximizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.DisableMinimizeColor = Color.FromArgb(105, 105, 105);
            nightControlBox1.EnableCloseColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMaximizeButton = true;
            nightControlBox1.EnableMaximizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.EnableMinimizeButton = true;
            nightControlBox1.EnableMinimizeColor = Color.FromArgb(160, 160, 160);
            nightControlBox1.Location = new Point(970, 0);
            nightControlBox1.MaximizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MaximizeHoverForeColor = Color.White;
            nightControlBox1.MinimizeHoverColor = Color.FromArgb(15, 255, 255, 255);
            nightControlBox1.MinimizeHoverForeColor = Color.White;
            nightControlBox1.Name = "nightControlBox1";
            nightControlBox1.Size = new Size(139, 31);
            nightControlBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Symbol", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ImageAlign = ContentAlignment.MiddleLeft;
            label1.Location = new Point(-2, -1);
            label1.Name = "label1";
            label1.Size = new Size(329, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Order_pnl
            // 
            Order_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Order_pnl.Controls.Add(productlist_pnl);
            Order_pnl.Location = new Point(0, -1);
            Order_pnl.Name = "Order_pnl";
            Order_pnl.Size = new Size(955, 617);
            Order_pnl.TabIndex = 0;
            // 
            // productlist_pnl
            // 
            productlist_pnl.Controls.Add(customers_pnl);
            productlist_pnl.Dock = DockStyle.Fill;
            productlist_pnl.Location = new Point(0, 0);
            productlist_pnl.Name = "productlist_pnl";
            productlist_pnl.Size = new Size(955, 617);
            productlist_pnl.TabIndex = 0;
            // 
            // customers_pnl
            // 
            customers_pnl.Dock = DockStyle.Fill;
            customers_pnl.Location = new Point(0, 0);
            customers_pnl.Name = "customers_pnl";
            customers_pnl.Size = new Size(955, 617);
            customers_pnl.TabIndex = 0;
            // 
            // contentPanel
            // 
            contentPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            contentPanel.Controls.Add(Order_pnl);
            contentPanel.Location = new Point(154, 34);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(955, 616);
            contentPanel.TabIndex = 2;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.Transparent;
            customers_btn.BackgroundImageLayout = ImageLayout.Center;
            customers_btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            customers_btn.FlatAppearance.BorderSize = 0;
            customers_btn.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            customers_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            customers_btn.FlatStyle = FlatStyle.Flat;
            customers_btn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Image = (Image)resources.GetObject("customers_btn.Image");
            customers_btn.ImageAlign = ContentAlignment.MiddleLeft;
            customers_btn.Location = new Point(0, 207);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(156, 45);
            customers_btn.TabIndex = 4;
            customers_btn.Text = "Customers";
            customers_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
            // 
            // Orders_btn
            // 
            Orders_btn.BackColor = Color.Transparent;
            Orders_btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            Orders_btn.FlatAppearance.BorderSize = 0;
            Orders_btn.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Orders_btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Orders_btn.FlatStyle = FlatStyle.Flat;
            Orders_btn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_btn.ForeColor = Color.White;
            Orders_btn.Image = (Image)resources.GetObject("Orders_btn.Image");
            Orders_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_btn.Location = new Point(0, 156);
            Orders_btn.Name = "Orders_btn";
            Orders_btn.Size = new Size(156, 45);
            Orders_btn.TabIndex = 3;
            Orders_btn.Text = "Orders";
            Orders_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_btn.UseVisualStyleBackColor = false;
            Orders_btn.Click += Orders_btn_Click;
            // 
            // Productlst_Btn
            // 
            Productlst_Btn.BackColor = Color.Transparent;
            Productlst_Btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            Productlst_Btn.FlatAppearance.BorderSize = 0;
            Productlst_Btn.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Productlst_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Productlst_Btn.FlatStyle = FlatStyle.Flat;
            Productlst_Btn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Productlst_Btn.ForeColor = Color.White;
            Productlst_Btn.Image = (Image)resources.GetObject("Productlst_Btn.Image");
            Productlst_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Productlst_Btn.Location = new Point(0, 105);
            Productlst_Btn.Name = "Productlst_Btn";
            Productlst_Btn.Size = new Size(156, 45);
            Productlst_Btn.TabIndex = 2;
            Productlst_Btn.Text = "Accessories";
            Productlst_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Productlst_Btn.UseVisualStyleBackColor = false;
            Productlst_Btn.Click += Productlst_Btn_Click;
            // 
            // userModule_Btn
            // 
            userModule_Btn.BackColor = Color.Transparent;
            userModule_Btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            userModule_Btn.FlatAppearance.BorderSize = 0;
            userModule_Btn.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            userModule_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            userModule_Btn.FlatStyle = FlatStyle.Flat;
            userModule_Btn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userModule_Btn.ForeColor = Color.White;
            userModule_Btn.Image = (Image)resources.GetObject("userModule_Btn.Image");
            userModule_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            userModule_Btn.Location = new Point(0, 54);
            userModule_Btn.Name = "userModule_Btn";
            userModule_Btn.Size = new Size(156, 45);
            userModule_Btn.TabIndex = 2;
            userModule_Btn.Text = "User";
            userModule_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userModule_Btn.UseVisualStyleBackColor = false;
            userModule_Btn.Click += userModule_Btn_Click;
            // 
            // Dashbrd_Btn
            // 
            Dashbrd_Btn.BackColor = Color.Transparent;
            Dashbrd_Btn.FlatAppearance.BorderColor = Color.LightSeaGreen;
            Dashbrd_Btn.FlatAppearance.BorderSize = 0;
            Dashbrd_Btn.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Dashbrd_Btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            Dashbrd_Btn.FlatStyle = FlatStyle.Flat;
            Dashbrd_Btn.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashbrd_Btn.ForeColor = Color.White;
            Dashbrd_Btn.Image = (Image)resources.GetObject("Dashbrd_Btn.Image");
            Dashbrd_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashbrd_Btn.Location = new Point(0, 3);
            Dashbrd_Btn.Name = "Dashbrd_Btn";
            Dashbrd_Btn.Size = new Size(156, 45);
            Dashbrd_Btn.TabIndex = 2;
            Dashbrd_Btn.Text = "Dashboard";
            Dashbrd_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashbrd_Btn.UseVisualStyleBackColor = true;
            Dashbrd_Btn.Click += Dashbrd_Btn_Click;
            // 
            // gradient_SidebarPanel1
            // 
            gradient_SidebarPanel1.Controls.Add(Dashbrd_Btn);
            gradient_SidebarPanel1.Controls.Add(userModule_Btn);
            gradient_SidebarPanel1.Controls.Add(Orders_btn);
            gradient_SidebarPanel1.Controls.Add(customers_btn);
            gradient_SidebarPanel1.Controls.Add(Productlst_Btn);
            gradient_SidebarPanel1.Dock = DockStyle.Left;
            gradient_SidebarPanel1.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            gradient_SidebarPanel1.gradientBottom = Color.FromArgb(0, 192, 192);
            gradient_SidebarPanel1.gradientTop = Color.FromArgb(128, 255, 128);
            gradient_SidebarPanel1.Location = new Point(0, 31);
            gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            gradient_SidebarPanel1.Size = new Size(158, 619);
            gradient_SidebarPanel1.TabIndex = 3;
            // 
            // mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1109, 650);
            Controls.Add(gradient_SidebarPanel1);
            Controls.Add(contentPanel);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "mainpage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "mainpage";
            Load += mainpage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            Order_pnl.ResumeLayout(false);
            productlist_pnl.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            gradient_SidebarPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel contentPanel;
        private Panel Order_pnl;
        private Panel Orders_pnl;
        private Panel productlist_pnl;
        private Panel customers_pnl;
        private Button customers_btn;
        private Button Orders_btn;
        private Button Productlst_Btn;
        private Button userModule_Btn;
        private Button Dashbrd_Btn;
        private TestDesigns.Gradient_SidebarPanel gradient_SidebarPanel1;
    }
}