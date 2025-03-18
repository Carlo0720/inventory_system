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
            flowLayoutPanel1 = new FlowLayoutPanel();
            Dashbrd_Btn = new Button();
            userModule_Btn = new Button();
            Productlst_Btn = new Button();
            Orders_btn = new Button();
            customers_btn = new Button();
            contentPanel = new Panel();
            panel1.SuspendLayout();
            Order_pnl.SuspendLayout();
            productlist_pnl.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            contentPanel.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Orders_pnl);
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 34);
            panel1.TabIndex = 0;
            // 
            // Orders_pnl
            // 
            Orders_pnl.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            Orders_pnl.Location = new Point(154, 32);
            Orders_pnl.Name = "Orders_pnl";
            Orders_pnl.Size = new Size(955, 618);
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
            label1.Location = new Point(-2, 1);
            label1.Name = "label1";
            label1.Size = new Size(329, 30);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management System";
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
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Controls.Add(Dashbrd_Btn);
            flowLayoutPanel1.Controls.Add(userModule_Btn);
            flowLayoutPanel1.Controls.Add(Productlst_Btn);
            flowLayoutPanel1.Controls.Add(Orders_btn);
            flowLayoutPanel1.Controls.Add(customers_btn);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(154, 616);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // Dashbrd_Btn
            // 
            Dashbrd_Btn.BackColor = Color.Gray;
            Dashbrd_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashbrd_Btn.ForeColor = Color.White;
            Dashbrd_Btn.Image = (Image)resources.GetObject("Dashbrd_Btn.Image");
            Dashbrd_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashbrd_Btn.Location = new Point(3, 3);
            Dashbrd_Btn.Name = "Dashbrd_Btn";
            Dashbrd_Btn.Size = new Size(148, 45);
            Dashbrd_Btn.TabIndex = 2;
            Dashbrd_Btn.Text = "Dashboard";
            Dashbrd_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashbrd_Btn.UseVisualStyleBackColor = false;
            Dashbrd_Btn.Click += Dashbrd_Btn_Click;
            // 
            // userModule_Btn
            // 
            userModule_Btn.BackColor = Color.Gray;
            userModule_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userModule_Btn.ForeColor = Color.White;
            userModule_Btn.Image = (Image)resources.GetObject("userModule_Btn.Image");
            userModule_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            userModule_Btn.Location = new Point(3, 54);
            userModule_Btn.Name = "userModule_Btn";
            userModule_Btn.Size = new Size(148, 45);
            userModule_Btn.TabIndex = 2;
            userModule_Btn.Text = "User";
            userModule_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userModule_Btn.UseVisualStyleBackColor = false;
            userModule_Btn.Click += userModule_Btn_Click;
            // 
            // Productlst_Btn
            // 
            Productlst_Btn.BackColor = Color.Gray;
            Productlst_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Productlst_Btn.ForeColor = Color.White;
            Productlst_Btn.Image = (Image)resources.GetObject("Productlst_Btn.Image");
            Productlst_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Productlst_Btn.Location = new Point(3, 105);
            Productlst_Btn.Name = "Productlst_Btn";
            Productlst_Btn.Size = new Size(148, 45);
            Productlst_Btn.TabIndex = 2;
            Productlst_Btn.Text = "Accessories";
            Productlst_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Productlst_Btn.UseVisualStyleBackColor = false;
            Productlst_Btn.Click += Productlst_Btn_Click;
            // 
            // Orders_btn
            // 
            Orders_btn.BackColor = Color.Gray;
            Orders_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_btn.ForeColor = Color.White;
            Orders_btn.Image = (Image)resources.GetObject("Orders_btn.Image");
            Orders_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_btn.Location = new Point(3, 156);
            Orders_btn.Name = "Orders_btn";
            Orders_btn.Size = new Size(148, 45);
            Orders_btn.TabIndex = 3;
            Orders_btn.Text = "Orders";
            Orders_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_btn.UseVisualStyleBackColor = false;
            Orders_btn.Click += Orders_btn_Click;
            // 
            // customers_btn
            // 
            customers_btn.BackColor = Color.Gray;
            customers_btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_btn.ForeColor = Color.White;
            customers_btn.Image = (Image)resources.GetObject("customers_btn.Image");
            customers_btn.ImageAlign = ContentAlignment.MiddleLeft;
            customers_btn.Location = new Point(3, 207);
            customers_btn.Name = "customers_btn";
            customers_btn.Size = new Size(148, 45);
            customers_btn.TabIndex = 4;
            customers_btn.Text = "Customers";
            customers_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_btn.UseVisualStyleBackColor = false;
            customers_btn.Click += customers_btn_Click;
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
            // mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1109, 650);
            Controls.Add(contentPanel);
            Controls.Add(flowLayoutPanel1);
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
            flowLayoutPanel1.ResumeLayout(false);
            contentPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Dashbrd_Btn;
        private Button Productlst_Btn;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Button userModule_Btn;
        private Panel contentPanel;
        private Panel Order_pnl;
        private Button Orders_btn;
        private Panel Orders_pnl;
        private Panel productlist_pnl;
        private Button customers_btn;
        private Panel customers_pnl;
    }
}