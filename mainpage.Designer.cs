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
            Login = new Label();
            SuspendLayout();
            // 
            // Login
            // 
            Login.AutoSize = true;
            Login.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login.Location = new Point(254, 194);
            Login.Name = "Login";
            Login.Size = new Size(254, 45);
            Login.TabIndex = 0;
            Login.Text = "Login Successful";
            // 
            // mainpage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Login);
            Name = "mainpage";
            Text = "mainpage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Login;
    }
}