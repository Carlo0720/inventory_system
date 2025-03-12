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
            nightControlBox1 = new ReaLTaiizor.Controls.NightControlBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel2 = new Panel();
            Dashbrd_Btn = new Button();
            panel3 = new Panel();
            Productlst_Btn = new Button();
            panel4 = new Panel();
            userModule_Btn = new Button();
            contentPanel = new Panel();
            panel5 = new Panel();
            button1 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            flowLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(nightControlBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 34);
            panel1.TabIndex = 0;
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
            label1.Font = new Font("Segoe UI Symbol", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 9);
            label1.Name = "label1";
            label1.Size = new Size(162, 20);
            label1.TabIndex = 2;
            label1.Text = "Inventory Management";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 26);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // mySqlCommand1
            // 
            mySqlCommand1.CacheAge = 0;
            mySqlCommand1.Connection = null;
            mySqlCommand1.EnableCaching = false;
            mySqlCommand1.Transaction = null;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.Gray;
            flowLayoutPanel1.Controls.Add(panel2);
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Dock = DockStyle.Left;
            flowLayoutPanel1.Location = new Point(0, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(154, 616);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(Dashbrd_Btn);
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(148, 44);
            panel2.TabIndex = 3;
            // 
            // Dashbrd_Btn
            // 
            Dashbrd_Btn.BackColor = Color.Gray;
            Dashbrd_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Dashbrd_Btn.ForeColor = Color.White;
            Dashbrd_Btn.Image = (Image)resources.GetObject("Dashbrd_Btn.Image");
            Dashbrd_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Dashbrd_Btn.Location = new Point(-4, -12);
            Dashbrd_Btn.Name = "Dashbrd_Btn";
            Dashbrd_Btn.Size = new Size(162, 65);
            Dashbrd_Btn.TabIndex = 2;
            Dashbrd_Btn.Text = "Dashboard";
            Dashbrd_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Dashbrd_Btn.UseVisualStyleBackColor = false;
            Dashbrd_Btn.Click += Dashbrd_Btn_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(Productlst_Btn);
            panel3.Location = new Point(3, 53);
            panel3.Name = "panel3";
            panel3.Size = new Size(148, 44);
            panel3.TabIndex = 4;
            // 
            // Productlst_Btn
            // 
            Productlst_Btn.BackColor = Color.Gray;
            Productlst_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Productlst_Btn.ForeColor = Color.White;
            Productlst_Btn.Image = (Image)resources.GetObject("Productlst_Btn.Image");
            Productlst_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Productlst_Btn.Location = new Point(-4, -12);
            Productlst_Btn.Name = "Productlst_Btn";
            Productlst_Btn.Size = new Size(162, 65);
            Productlst_Btn.TabIndex = 2;
            Productlst_Btn.Text = "Product list";
            Productlst_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Productlst_Btn.UseVisualStyleBackColor = false;
            Productlst_Btn.Click += Productlst_Btn_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(userModule_Btn);
            panel4.Location = new Point(3, 153);
            panel4.Name = "panel4";
            panel4.Size = new Size(148, 44);
            panel4.TabIndex = 5;
            // 
            // userModule_Btn
            // 
            userModule_Btn.BackColor = Color.Gray;
            userModule_Btn.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            userModule_Btn.ForeColor = Color.White;
            userModule_Btn.Image = (Image)resources.GetObject("userModule_Btn.Image");
            userModule_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            userModule_Btn.Location = new Point(-4, -12);
            userModule_Btn.Name = "userModule_Btn";
            userModule_Btn.Size = new Size(162, 65);
            userModule_Btn.TabIndex = 2;
            userModule_Btn.Text = "User";
            userModule_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            userModule_Btn.UseVisualStyleBackColor = false;
            userModule_Btn.Click += userModule_Btn_Click;
            // 
            // contentPanel
            // 
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Location = new Point(154, 34);
            contentPanel.Name = "contentPanel";
            contentPanel.Size = new Size(955, 616);
            contentPanel.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Controls.Add(button1);
            panel5.Location = new Point(3, 103);
            panel5.Name = "panel5";
            panel5.Size = new Size(148, 44);
            panel5.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Gray;
            button1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(-4, -12);
            button1.Name = "button1";
            button1.Size = new Size(162, 65);
            button1.TabIndex = 2;
            button1.Text = "Orders";
            button1.TextImageRelation = TextImageRelation.ImageBeforeText;
            button1.UseVisualStyleBackColor = false;
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
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            flowLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox pictureBox1;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button Dashbrd_Btn;
        private Panel panel2;
        private Panel panel3;
        private Button Productlst_Btn;
        private ReaLTaiizor.Controls.NightControlBox nightControlBox1;
        private Panel panel4;
        private Button userModule_Btn;
        private Panel contentPanel;
        private Panel panel5;
        private Button button1;
    }
}