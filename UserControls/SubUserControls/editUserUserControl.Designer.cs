namespace inventory_system.UserControls.SubUserControls
{
    partial class editUserUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editUserUserControl));
            Lable_LstNme = new Label();
            Lable_FrstNme = new Label();
            pictureBoxCreate = new PictureBox();
            edituserfirstname_txtbox = new ReaLTaiizor.Controls.CrownTextBox();
            Close_btn = new ReaLTaiizor.Controls.Button();
            edituserlastname_txtbox = new ReaLTaiizor.Controls.CrownTextBox();
            edituserpassword_txtbox = new ReaLTaiizor.Controls.CrownTextBox();
            passwordlbl = new Label();
            edituser_btn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreate).BeginInit();
            SuspendLayout();
            // 
            // Lable_LstNme
            // 
            Lable_LstNme.AutoSize = true;
            Lable_LstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_LstNme.Location = new Point(105, 113);
            Lable_LstNme.Name = "Lable_LstNme";
            Lable_LstNme.Size = new Size(72, 17);
            Lable_LstNme.TabIndex = 11;
            Lable_LstNme.Text = "Last Name";
            // 
            // Lable_FrstNme
            // 
            Lable_FrstNme.AutoSize = true;
            Lable_FrstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_FrstNme.Location = new Point(105, 67);
            Lable_FrstNme.Name = "Lable_FrstNme";
            Lable_FrstNme.Size = new Size(74, 17);
            Lable_FrstNme.TabIndex = 10;
            Lable_FrstNme.Text = "First Name";
            // 
            // pictureBoxCreate
            // 
            pictureBoxCreate.BackColor = Color.Transparent;
            pictureBoxCreate.Image = (Image)resources.GetObject("pictureBoxCreate.Image");
            pictureBoxCreate.Location = new Point(173, 12);
            pictureBoxCreate.Name = "pictureBoxCreate";
            pictureBoxCreate.Size = new Size(52, 52);
            pictureBoxCreate.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCreate.TabIndex = 9;
            pictureBoxCreate.TabStop = false;
            // 
            // edituserfirstname_txtbox
            // 
            edituserfirstname_txtbox.BackColor = Color.White;
            edituserfirstname_txtbox.BorderStyle = BorderStyle.FixedSingle;
            edituserfirstname_txtbox.ForeColor = Color.Black;
            edituserfirstname_txtbox.Location = new Point(107, 87);
            edituserfirstname_txtbox.Name = "edituserfirstname_txtbox";
            edituserfirstname_txtbox.Size = new Size(169, 23);
            edituserfirstname_txtbox.TabIndex = 12;
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Transparent;
            Close_btn.BorderColor = Color.FromArgb(32, 34, 37);
            Close_btn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            Close_btn.EnteredColor = Color.FromArgb(32, 34, 37);
            Close_btn.Font = new Font("Microsoft Sans Serif", 12F);
            Close_btn.Image = null;
            Close_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Close_btn.InactiveColor = Color.FromArgb(32, 34, 37);
            Close_btn.Location = new Point(361, 3);
            Close_btn.Name = "Close_btn";
            Close_btn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            Close_btn.PressedColor = Color.FromArgb(165, 37, 37);
            Close_btn.Size = new Size(21, 22);
            Close_btn.TabIndex = 14;
            Close_btn.Text = "X";
            Close_btn.TextAlignment = StringAlignment.Center;
            Close_btn.Click += Close_btn_Click;
            // 
            // edituserlastname_txtbox
            // 
            edituserlastname_txtbox.BackColor = Color.White;
            edituserlastname_txtbox.BorderStyle = BorderStyle.FixedSingle;
            edituserlastname_txtbox.ForeColor = Color.Black;
            edituserlastname_txtbox.Location = new Point(105, 133);
            edituserlastname_txtbox.Name = "edituserlastname_txtbox";
            edituserlastname_txtbox.Size = new Size(169, 23);
            edituserlastname_txtbox.TabIndex = 15;
            // 
            // edituserpassword_txtbox
            // 
            edituserpassword_txtbox.BackColor = Color.White;
            edituserpassword_txtbox.BorderStyle = BorderStyle.FixedSingle;
            edituserpassword_txtbox.ForeColor = Color.Black;
            edituserpassword_txtbox.Location = new Point(105, 179);
            edituserpassword_txtbox.Name = "edituserpassword_txtbox";
            edituserpassword_txtbox.Size = new Size(169, 23);
            edituserpassword_txtbox.TabIndex = 17;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlbl.Location = new Point(105, 159);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(66, 17);
            passwordlbl.TabIndex = 16;
            passwordlbl.Text = "Password";
            // 
            // edituser_btn
            // 
            edituser_btn.Anchor = AnchorStyles.None;
            edituser_btn.BackColor = Color.Transparent;
            edituser_btn.BorderColor = Color.FromArgb(32, 34, 37);
            edituser_btn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            edituser_btn.EnteredColor = Color.FromArgb(32, 34, 37);
            edituser_btn.Font = new Font("Microsoft Sans Serif", 12F);
            edituser_btn.Image = null;
            edituser_btn.ImageAlign = ContentAlignment.MiddleLeft;
            edituser_btn.InactiveColor = Color.FromArgb(32, 34, 37);
            edituser_btn.Location = new Point(139, 208);
            edituser_btn.Name = "edituser_btn";
            edituser_btn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            edituser_btn.PressedColor = Color.FromArgb(165, 37, 37);
            edituser_btn.Size = new Size(101, 52);
            edituser_btn.TabIndex = 18;
            edituser_btn.Text = "Edit";
            edituser_btn.TextAlignment = StringAlignment.Center;
            edituser_btn.Click += edituser_btn_Click;
            // 
            // editUserUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(edituser_btn);
            Controls.Add(edituserpassword_txtbox);
            Controls.Add(passwordlbl);
            Controls.Add(edituserlastname_txtbox);
            Controls.Add(Close_btn);
            Controls.Add(edituserfirstname_txtbox);
            Controls.Add(Lable_LstNme);
            Controls.Add(Lable_FrstNme);
            Controls.Add(pictureBoxCreate);
            Name = "editUserUserControl";
            Size = new Size(385, 265);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Lable_LstNme;
        private Label Lable_FrstNme;
        private PictureBox pictureBoxCreate;
        private ReaLTaiizor.Controls.CrownTextBox edituserfirstname_txtbox;
        private ReaLTaiizor.Controls.Button Close_btn;
        private ReaLTaiizor.Controls.CrownTextBox edituserlastname_txtbox;
        private ReaLTaiizor.Controls.CrownTextBox edituserpassword_txtbox;
        private Label passwordlbl;
        private ReaLTaiizor.Controls.Button edituser_btn;
    }
}
