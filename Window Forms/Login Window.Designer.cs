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
            Login = new Button();
            Usertxtbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            Passwordtxtbox = new TextBox();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            l = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // Login
            // 
            Login.BackColor = Color.White;
            Login.Location = new Point(150, 180);
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
            Usertxtbox.Location = new Point(115, 76);
            Usertxtbox.Name = "Usertxtbox";
            Usertxtbox.ShortcutsEnabled = false;
            Usertxtbox.Size = new Size(221, 23);
            Usertxtbox.TabIndex = 1;
            Usertxtbox.KeyDown += Passwordtxtbox_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 79);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 125);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // Passwordtxtbox
            // 
            Passwordtxtbox.BackColor = SystemColors.InactiveBorder;
            Passwordtxtbox.BorderStyle = BorderStyle.FixedSingle;
            Passwordtxtbox.Cursor = Cursors.SizeWE;
            Passwordtxtbox.Location = new Point(115, 122);
            Passwordtxtbox.Name = "Passwordtxtbox";
            Passwordtxtbox.Size = new Size(221, 23);
            Passwordtxtbox.TabIndex = 4;
            Passwordtxtbox.KeyDown += Passwordtxtbox_KeyDown;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(395, 16);
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
            l.Location = new Point(150, 9);
            l.Name = "l";
            l.Size = new Size(103, 46);
            l.TabIndex = 6;
            l.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDark;
            ClientSize = new Size(409, 229);
            Controls.Add(l);
            Controls.Add(foreverClose1);
            Controls.Add(Passwordtxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Usertxtbox);
            Controls.Add(Login);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private TextBox Usertxtbox;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxtbox;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel l;
    }
}
