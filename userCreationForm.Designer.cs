namespace inventory_system
{
    partial class userCreationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(userCreationForm));
            Create_btnUser = new ReaLTaiizor.Controls.Button();
            Close_btn = new ReaLTaiizor.Controls.Button();
            crownTextBoxFrstNme = new ReaLTaiizor.Controls.CrownTextBox();
            crownTextBoxLstNme = new ReaLTaiizor.Controls.CrownTextBox();
            pictureBoxCreate = new PictureBox();
            Lable_FrstNme = new Label();
            Lable_LstNme = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreate).BeginInit();
            SuspendLayout();
            // 
            // Create_btnUser
            // 
            Create_btnUser.Anchor = AnchorStyles.None;
            Create_btnUser.BackColor = Color.Transparent;
            Create_btnUser.BorderColor = Color.FromArgb(32, 34, 37);
            Create_btnUser.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            Create_btnUser.EnteredColor = Color.FromArgb(32, 34, 37);
            Create_btnUser.Font = new Font("Microsoft Sans Serif", 12F);
            Create_btnUser.Image = null;
            Create_btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            Create_btnUser.InactiveColor = Color.FromArgb(32, 34, 37);
            Create_btnUser.Location = new Point(141, 210);
            Create_btnUser.Name = "Create_btnUser";
            Create_btnUser.PressedBorderColor = Color.FromArgb(165, 37, 37);
            Create_btnUser.PressedColor = Color.FromArgb(165, 37, 37);
            Create_btnUser.Size = new Size(101, 52);
            Create_btnUser.TabIndex = 2;
            Create_btnUser.Text = "Create";
            Create_btnUser.TextAlignment = StringAlignment.Center;
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
            Close_btn.TabIndex = 3;
            Close_btn.Text = "X";
            Close_btn.TextAlignment = StringAlignment.Center;
            // 
            // crownTextBoxFrstNme
            // 
            crownTextBoxFrstNme.BackColor = Color.Silver;
            crownTextBoxFrstNme.BorderStyle = BorderStyle.FixedSingle;
            crownTextBoxFrstNme.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBoxFrstNme.Location = new Point(108, 114);
            crownTextBoxFrstNme.Multiline = true;
            crownTextBoxFrstNme.Name = "crownTextBoxFrstNme";
            crownTextBoxFrstNme.Size = new Size(169, 23);
            crownTextBoxFrstNme.TabIndex = 4;
            // 
            // crownTextBoxLstNme
            // 
            crownTextBoxLstNme.BackColor = Color.Silver;
            crownTextBoxLstNme.BorderStyle = BorderStyle.FixedSingle;
            crownTextBoxLstNme.ForeColor = Color.FromArgb(220, 220, 220);
            crownTextBoxLstNme.Location = new Point(108, 160);
            crownTextBoxLstNme.Multiline = true;
            crownTextBoxLstNme.Name = "crownTextBoxLstNme";
            crownTextBoxLstNme.Size = new Size(169, 23);
            crownTextBoxLstNme.TabIndex = 5;
            // 
            // pictureBoxCreate
            // 
            pictureBoxCreate.BackColor = Color.Transparent;
            pictureBoxCreate.Image = (Image)resources.GetObject("pictureBoxCreate.Image");
            pictureBoxCreate.Location = new Point(167, 41);
            pictureBoxCreate.Name = "pictureBoxCreate";
            pictureBoxCreate.Size = new Size(52, 52);
            pictureBoxCreate.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBoxCreate.TabIndex = 6;
            pictureBoxCreate.TabStop = false;
            // 
            // Lable_FrstNme
            // 
            Lable_FrstNme.AutoSize = true;
            Lable_FrstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_FrstNme.Location = new Point(108, 96);
            Lable_FrstNme.Name = "Lable_FrstNme";
            Lable_FrstNme.Size = new Size(74, 17);
            Lable_FrstNme.TabIndex = 7;
            Lable_FrstNme.Text = "First Name";
            Lable_FrstNme.Click += label1_Click;
            // 
            // Lable_LstNme
            // 
            Lable_LstNme.AutoSize = true;
            Lable_LstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_LstNme.Location = new Point(108, 142);
            Lable_LstNme.Name = "Lable_LstNme";
            Lable_LstNme.Size = new Size(72, 17);
            Lable_LstNme.TabIndex = 8;
            Lable_LstNme.Text = "Last Name";
            Lable_LstNme.Click += label2_Click;
            // 
            // userCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(Lable_LstNme);
            Controls.Add(Lable_FrstNme);
            Controls.Add(pictureBoxCreate);
            Controls.Add(crownTextBoxLstNme);
            Controls.Add(crownTextBoxFrstNme);
            Controls.Add(Close_btn);
            Controls.Add(Create_btnUser);
            Name = "userCreationForm";
            Size = new Size(385, 265);
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.Button Create_btnUser;
        private ReaLTaiizor.Controls.Button Close_btn;
        private ReaLTaiizor.Controls.CrownTextBox crownTextBoxFrstNme;
        private ReaLTaiizor.Controls.CrownTextBox crownTextBoxLstNme;
        private PictureBox pictureBoxCreate;
        private Label Lable_FrstNme;
        private Label Lable_LstNme;
    }
}