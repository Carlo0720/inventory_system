﻿namespace inventory_system
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
            SuspendLayout();
            // 
            // Login
            // 
            Login.Location = new Point(141, 160);
            Login.Name = "Login";
            Login.Size = new Size(106, 37);
            Login.TabIndex = 0;
            Login.Text = "Login";
            Login.Click += Login_Click;
            // 
            // Usertxtbox
            // 
            Usertxtbox.Cursor = Cursors.SizeWE;
            Usertxtbox.Location = new Point(106, 60);
            Usertxtbox.Name = "Usertxtbox";
            Usertxtbox.ShortcutsEnabled = false;
            Usertxtbox.Size = new Size(221, 23);
            Usertxtbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(21, 63);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 2;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 109);
            label2.Name = "label2";
            label2.Size = new Size(57, 15);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // Passwordtxtbox
            // 
            Passwordtxtbox.Cursor = Cursors.SizeWE;
            Passwordtxtbox.Location = new Point(106, 106);
            Passwordtxtbox.Name = "Passwordtxtbox";
            Passwordtxtbox.Size = new Size(221, 23);
            Passwordtxtbox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(409, 229);
            Controls.Add(Passwordtxtbox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Usertxtbox);
            Controls.Add(Login);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Login;
        private TextBox Usertxtbox;
        private Label label1;
        private Label label2;
        private TextBox Passwordtxtbox;
    }
}
