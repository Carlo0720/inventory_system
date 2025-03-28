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
            label1 = new Label();
            crownComboBoxUserType = new ReaLTaiizor.Controls.CrownComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxCreate).BeginInit();
            SuspendLayout();
            // 
            // Create_btnUser
            // 
            Create_btnUser.Anchor = AnchorStyles.None;
            Create_btnUser.BackColor = Color.Transparent;
            Create_btnUser.BorderColor = Color.Transparent;
            Create_btnUser.EnteredBorderColor = Color.White;
            Create_btnUser.EnteredColor = Color.DarkGreen;
            Create_btnUser.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create_btnUser.Image = null;
            Create_btnUser.ImageAlign = ContentAlignment.MiddleLeft;
            Create_btnUser.InactiveColor = Color.MediumSeaGreen;
            Create_btnUser.Location = new Point(141, 247);
            Create_btnUser.Name = "Create_btnUser";
            Create_btnUser.PressedBorderColor = Color.SeaGreen;
            Create_btnUser.PressedColor = Color.Green;
            Create_btnUser.Size = new Size(101, 52);
            Create_btnUser.TabIndex = 2;
            Create_btnUser.Text = "Create";
            Create_btnUser.TextAlignment = StringAlignment.Center;
            Create_btnUser.Click += Create_btnUser_Click;
            // 
            // Close_btn
            // 
            Close_btn.BackColor = Color.Red;
            Close_btn.BorderColor = Color.Transparent;
            Close_btn.EnteredBorderColor = Color.White;
            Close_btn.EnteredColor = Color.Red;
            Close_btn.Font = new Font("Microsoft Sans Serif", 12F);
            Close_btn.Image = null;
            Close_btn.ImageAlign = ContentAlignment.MiddleLeft;
            Close_btn.InactiveColor = Color.Red;
            Close_btn.Location = new Point(361, 3);
            Close_btn.Name = "Close_btn";
            Close_btn.PressedBorderColor = Color.Firebrick;
            Close_btn.PressedColor = Color.Maroon;
            Close_btn.Size = new Size(21, 22);
            Close_btn.TabIndex = 3;
            Close_btn.Text = "X";
            Close_btn.TextAlignment = StringAlignment.Center;
            Close_btn.Click += Close_btn_Click_1;
            // 
            // crownTextBoxFrstNme
            // 
            crownTextBoxFrstNme.BackColor = Color.White;
            crownTextBoxFrstNme.BorderStyle = BorderStyle.FixedSingle;
            crownTextBoxFrstNme.ForeColor = Color.Black;
            crownTextBoxFrstNme.Location = new Point(105, 96);
            crownTextBoxFrstNme.Multiline = true;
            crownTextBoxFrstNme.Name = "crownTextBoxFrstNme";
            crownTextBoxFrstNme.Size = new Size(169, 23);
            crownTextBoxFrstNme.TabIndex = 4;
            // 
            // crownTextBoxLstNme
            // 
            crownTextBoxLstNme.BackColor = Color.White;
            crownTextBoxLstNme.BorderStyle = BorderStyle.FixedSingle;
            crownTextBoxLstNme.ForeColor = Color.Black;
            crownTextBoxLstNme.Location = new Point(105, 142);
            crownTextBoxLstNme.Multiline = true;
            crownTextBoxLstNme.Name = "crownTextBoxLstNme";
            crownTextBoxLstNme.Size = new Size(169, 23);
            crownTextBoxLstNme.TabIndex = 5;
            // 
            // pictureBoxCreate
            // 
            pictureBoxCreate.BackColor = Color.Transparent;
            pictureBoxCreate.Image = (Image)resources.GetObject("pictureBoxCreate.Image");
            pictureBoxCreate.Location = new Point(156, 9);
            pictureBoxCreate.Name = "pictureBoxCreate";
            pictureBoxCreate.Size = new Size(73, 66);
            pictureBoxCreate.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxCreate.TabIndex = 6;
            pictureBoxCreate.TabStop = false;
            // 
            // Lable_FrstNme
            // 
            Lable_FrstNme.AutoSize = true;
            Lable_FrstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_FrstNme.ForeColor = Color.White;
            Lable_FrstNme.Location = new Point(105, 78);
            Lable_FrstNme.Name = "Lable_FrstNme";
            Lable_FrstNme.Size = new Size(74, 17);
            Lable_FrstNme.TabIndex = 7;
            Lable_FrstNme.Text = "First Name";
            // 
            // Lable_LstNme
            // 
            Lable_LstNme.AutoSize = true;
            Lable_LstNme.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Lable_LstNme.ForeColor = Color.White;
            Lable_LstNme.Location = new Point(105, 124);
            Lable_LstNme.Name = "Lable_LstNme";
            Lable_LstNme.Size = new Size(72, 17);
            Lable_LstNme.TabIndex = 8;
            Lable_LstNme.Text = "Last Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(105, 178);
            label1.Name = "label1";
            label1.Size = new Size(67, 17);
            label1.TabIndex = 9;
            label1.Text = "User Type";
            // 
            // crownComboBoxUserType
            // 
            crownComboBoxUserType.DrawMode = DrawMode.OwnerDrawVariable;
            crownComboBoxUserType.FormattingEnabled = true;
            crownComboBoxUserType.Location = new Point(105, 198);
            crownComboBoxUserType.Name = "crownComboBoxUserType";
            crownComboBoxUserType.Size = new Size(169, 24);
            crownComboBoxUserType.TabIndex = 10;
            crownComboBoxUserType.SelectedIndexChanged += crownComboBoxUserType_SelectedIndexChanged;
            // 
            // userCreationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 37);
            BackgroundImageLayout = ImageLayout.Stretch;
            Controls.Add(crownComboBoxUserType);
            Controls.Add(label1);
            Controls.Add(Lable_LstNme);
            Controls.Add(Lable_FrstNme);
            Controls.Add(pictureBoxCreate);
            Controls.Add(crownTextBoxLstNme);
            Controls.Add(crownTextBoxFrstNme);
            Controls.Add(Close_btn);
            Controls.Add(Create_btnUser);
            Name = "userCreationForm";
            Size = new Size(385, 310);
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
        private Label label1;
        private ReaLTaiizor.Controls.CrownComboBox crownComboBoxUserType;
    }
}