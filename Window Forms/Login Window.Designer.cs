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
            l = new ReaLTaiizor.Controls.BigLabel();
            gradient_SidebarPanel1 = new TestDesigns.Gradient_SidebarPanel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            Login_Gif = new PictureBox();
            gradient_SidebarPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Login_Gif).BeginInit();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.Transparent;
            Login.FlatAppearance.BorderColor = Color.Cyan;
            Login.FlatAppearance.BorderSize = 0;
            Login.FlatAppearance.MouseDownBackColor = Color.LightSeaGreen;
            Login.FlatAppearance.MouseOverBackColor = Color.MediumTurquoise;
            Login.FlatStyle = FlatStyle.Flat;
            Login.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.ForeColor = Color.White;
            Login.Location = new Point(138, 225);
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
            Usertxtbox.Location = new Point(72, 124);
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
            label1.Location = new Point(72, 106);
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
            label2.Location = new Point(75, 152);
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
            Passwordtxtbox.Location = new Point(72, 170);
            Passwordtxtbox.Name = "Passwordtxtbox";
            Passwordtxtbox.Size = new Size(221, 25);
            Passwordtxtbox.TabIndex = 4;
            Passwordtxtbox.KeyDown += Passwordtxtbox_KeyDown;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(128, 255, 128);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(359, 0);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 5;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // l
            // 
            l.AutoSize = true;
            l.BackColor = Color.Transparent;
            l.Font = new Font("Segoe UI", 25F);
            l.ForeColor = Color.White;
            l.Location = new Point(138, 7);
            l.Name = "l";
            l.Size = new Size(103, 46);
            l.TabIndex = 6;
            l.Text = "Login";
            // 
            // gradient_SidebarPanel1
            // 
            gradient_SidebarPanel1.BackColor = Color.Transparent;
            gradient_SidebarPanel1.Controls.Add(pictureBox2);
            gradient_SidebarPanel1.Controls.Add(pictureBox1);
            gradient_SidebarPanel1.Controls.Add(foreverClose1);
            gradient_SidebarPanel1.Controls.Add(Login_Gif);
            gradient_SidebarPanel1.Controls.Add(l);
            gradient_SidebarPanel1.Controls.Add(Passwordtxtbox);
            gradient_SidebarPanel1.Controls.Add(label2);
            gradient_SidebarPanel1.Controls.Add(label1);
            gradient_SidebarPanel1.Controls.Add(Usertxtbox);
            gradient_SidebarPanel1.Controls.Add(Login);
            gradient_SidebarPanel1.gradientBottom = Color.FromArgb(0, 192, 192);
            gradient_SidebarPanel1.gradientTop = Color.FromArgb(128, 255, 128);
            gradient_SidebarPanel1.Location = new Point(0, -1);
            gradient_SidebarPanel1.Name = "gradient_SidebarPanel1";
            gradient_SidebarPanel1.Size = new Size(377, 278);
            gradient_SidebarPanel1.TabIndex = 7;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(38, 168);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(28, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(38, 122);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // Login_Gif
            // 
            Login_Gif.Image = (Image)resources.GetObject("Login_Gif.Image");
            Login_Gif.Location = new Point(163, 69);
            Login_Gif.Name = "Login_Gif";
            Login_Gif.Size = new Size(48, 49);
            Login_Gif.SizeMode = PictureBoxSizeMode.CenterImage;
            Login_Gif.TabIndex = 7;
            Login_Gif.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(377, 276);
            Controls.Add(gradient_SidebarPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            gradient_SidebarPanel1.ResumeLayout(false);
            gradient_SidebarPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Login_Gif).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button Login;
        private TextBox Usertxtbox;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxtbox;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel l;
        private TestDesigns.Gradient_SidebarPanel gradient_SidebarPanel1;
        private PictureBox Login_Gif;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}
