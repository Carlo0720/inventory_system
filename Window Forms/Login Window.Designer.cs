namespace inventory_system
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Login = new Button();
            Usertxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Passwordtxtbox = new TextBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            gradient_SidebarPanel1 = new TestDesigns.Gradient_SidebarPanel();
            moonLabel1 = new ReaLTaiizor.Controls.MoonLabel();
            pictureBox5 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            gradient_SidebarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.Transparent;
            Login.FlatAppearance.BorderColor = Color.LightSeaGreen;
            Login.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Login.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(128, 251);
            Login.Name = "Login";
            Login.Size = new Size(103, 37);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.UseVisualStyleBackColor = false;
            Login.Click += Login_Click;
            // 
            // Usertxtbox
            // 
            Usertxtbox.BackColor = SystemColors.InactiveBorder;
            Usertxtbox.BorderStyle = BorderStyle.FixedSingle;
            Usertxtbox.Cursor = Cursors.SizeWE;
            Usertxtbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Usertxtbox.Location = new Point(85, 158);
            Usertxtbox.Name = "Usertxtbox";
            Usertxtbox.ShortcutsEnabled = false;
            Usertxtbox.Size = new Size(221, 25);
            Usertxtbox.TabIndex = 1;
            Usertxtbox.KeyDown += Passwordtxtbox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(85, 140);
            label1.Name = "label1";
            label1.Size = new Size(75, 16);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(88, 186);
            label2.Name = "label2";
            label2.Size = new Size(72, 16);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Passwordtxtbox
            // 
            Passwordtxtbox.BackColor = SystemColors.InactiveBorder;
            Passwordtxtbox.BorderStyle = BorderStyle.FixedSingle;
            Passwordtxtbox.Cursor = Cursors.SizeWE;
            Passwordtxtbox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Passwordtxtbox.Location = new Point(85, 204);
            Passwordtxtbox.Name = "Passwordtxtbox";
            Passwordtxtbox.Size = new Size(221, 25);
            Passwordtxtbox.TabIndex = 4;
            Passwordtxtbox.KeyDown += Passwordtxtbox_KeyDown;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.FromArgb(2, 24, 37);
            foreverClose1.BaseColor = Color.Transparent;
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(331, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 5;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // gradient_SidebarPanel1
            // 
            gradient_SidebarPanel1.BackColor = Color.Transparent;
            gradient_SidebarPanel1.Controls.Add(moonLabel1);
            gradient_SidebarPanel1.Controls.Add(pictureBox5);
            gradient_SidebarPanel1.Controls.Add(pictureBox4);
            gradient_SidebarPanel1.Controls.Add(pictureBox3);
            gradient_SidebarPanel1.Controls.Add(bigLabel1);
            gradient_SidebarPanel1.Controls.Add(pictureBox2);
            gradient_SidebarPanel1.Controls.Add(pictureBox1);
            gradient_SidebarPanel1.Controls.Add(foreverClose1);
            gradient_SidebarPanel1.Controls.Add(Passwordtxtbox);
            gradient_SidebarPanel1.Controls.Add(label2);
            gradient_SidebarPanel1.Controls.Add(label1);
            gradient_SidebarPanel1.Controls.Add(Usertxtbox);
            gradient_SidebarPanel1.Controls.Add(Login);
            gradient_SidebarPanel1.gradientBottom = Color.FromArgb(2, 24, 37);
            gradient_SidebarPanel1.gradientTop = Color.FromArgb(2, 24, 37);
            gradient_SidebarPanel1.Location = new Point(0, -1);
            gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            gradient_SidebarPanel1.Size = new Size(361, 435);
            gradient_SidebarPanel1.TabIndex = 7;
            // 
            // moonLabel1
            // 
            moonLabel1.AutoSize = true;
            moonLabel1.BackColor = Color.Transparent;
            moonLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            moonLabel1.ForeColor = Color.White;
            moonLabel1.Location = new Point(321, 409);
            moonLabel1.Name = "moonLabel1";
            moonLabel1.Size = new Size(39, 21);
            moonLabel1.TabIndex = 14;
            moonLabel1.Text = "IMS";
            // 
            // pictureBox5
            // 
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(67, 402);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(26, 25);
            pictureBox5.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox5.TabIndex = 13;
            pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(35, 402);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(26, 25);
            pictureBox4.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox4.TabIndex = 12;
            pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(3, 402);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(26, 25);
            pictureBox3.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Verdana", 25F, FontStyle.Bold);
            bigLabel1.ForeColor = Color.White;
            bigLabel1.Location = new Point(83, 83);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(193, 41);
            bigLabel1.TabIndex = 10;
            bigLabel1.Text = "Welcome";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(51, 202);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(51, 156);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(361, 430);
            Controls.Add(gradient_SidebarPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gradient_SidebarPanel1.ResumeLayout(false);
            gradient_SidebarPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Login;
        private TextBox Usertxtbox;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxtbox;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private TestDesigns.Gradient_SidebarPanel gradient_SidebarPanel1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private PictureBox pictureBox3;
        private ReaLTaiizor.Controls.MoonLabel moonLabel1;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
    }
}
