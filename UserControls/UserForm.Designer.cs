﻿namespace inventory_system
{
    partial class UserForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            user_datagd = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            User_Type = new DataGridViewTextBoxColumn();
            First_Name = new DataGridViewTextBoxColumn();
            Last_Name = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            temp_password = new DataGridViewTextBoxColumn();
            Create_Btn = new Button();
            Refresh_Btn = new Button();
            userCreationPanel = new Panel();
            User_Title = new Label();
            ((System.ComponentModel.ISupportInitialize)user_datagd).BeginInit();
            SuspendLayout();
            // 
            // user_datagd
            // 
            user_datagd.AllowUserToAddRows = false;
            user_datagd.AllowUserToDeleteRows = false;
            user_datagd.AllowUserToOrderColumns = true;
            user_datagd.AllowUserToResizeColumns = false;
            user_datagd.AllowUserToResizeRows = false;
            user_datagd.BackgroundColor = Color.WhiteSmoke;
            user_datagd.BorderStyle = BorderStyle.None;
            user_datagd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            user_datagd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            user_datagd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            user_datagd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            user_datagd.Columns.AddRange(new DataGridViewColumn[] { ID, User_Type, First_Name, Last_Name, Username, temp_password });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            user_datagd.DefaultCellStyle = dataGridViewCellStyle2;
            user_datagd.GridColor = Color.LightGray;
            user_datagd.Location = new Point(0, 57);
            user_datagd.Name = "user_datagd";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            user_datagd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            user_datagd.RowHeadersVisible = false;
            user_datagd.RowTemplate.DividerHeight = 1;
            user_datagd.RowTemplate.Height = 35;
            user_datagd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            user_datagd.Size = new Size(955, 556);
            user_datagd.TabIndex = 0;
            user_datagd.CellContentClick += user_datagd_CellContentClick_1;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 45;
            // 
            // User_Type
            // 
            User_Type.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            User_Type.HeaderText = "User Type";
            User_Type.Name = "User_Type";
            // 
            // First_Name
            // 
            First_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            First_Name.HeaderText = "First Name";
            First_Name.Name = "First_Name";
            // 
            // Last_Name
            // 
            Last_Name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Last_Name.HeaderText = "Last Name";
            Last_Name.Name = "Last_Name";
            // 
            // Username
            // 
            Username.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Username.HeaderText = "Username";
            Username.Name = "Username";
            // 
            // temp_password
            // 
            temp_password.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            temp_password.HeaderText = "Password";
            temp_password.Name = "temp_password";
            temp_password.Width = 93;
            // 
            // Create_Btn
            // 
            Create_Btn.BackColor = Color.MediumSeaGreen;
            Create_Btn.FlatAppearance.BorderSize = 0;
            Create_Btn.FlatStyle = FlatStyle.Flat;
            Create_Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create_Btn.ForeColor = Color.White;
            Create_Btn.Image = (Image)resources.GetObject("Create_Btn.Image");
            Create_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Create_Btn.Location = new Point(98, 12);
            Create_Btn.Name = "Create_Btn";
            Create_Btn.Size = new Size(124, 38);
            Create_Btn.TabIndex = 1;
            Create_Btn.Text = "Create";
            Create_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Create_Btn.UseVisualStyleBackColor = false;
            Create_Btn.Click += Create_Btn_Click;
            // 
            // Refresh_Btn
            // 
            Refresh_Btn.BackColor = Color.OrangeRed;
            Refresh_Btn.FlatAppearance.BorderSize = 0;
            Refresh_Btn.FlatStyle = FlatStyle.Flat;
            Refresh_Btn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Refresh_Btn.ForeColor = Color.White;
            Refresh_Btn.Image = (Image)resources.GetObject("Refresh_Btn.Image");
            Refresh_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Refresh_Btn.Location = new Point(228, 12);
            Refresh_Btn.Name = "Refresh_Btn";
            Refresh_Btn.Size = new Size(135, 38);
            Refresh_Btn.TabIndex = 2;
            Refresh_Btn.Text = "Refresh";
            Refresh_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Refresh_Btn.UseVisualStyleBackColor = false;
            Refresh_Btn.Click += Refresh_button_Click;
            // 
            // userCreationPanel
            // 
            userCreationPanel.Anchor = AnchorStyles.None;
            userCreationPanel.Location = new Point(268, 164);
            userCreationPanel.Name = "userCreationPanel";
            userCreationPanel.Size = new Size(385, 310);
            userCreationPanel.TabIndex = 3;
            // 
            // User_Title
            // 
            User_Title.AutoSize = true;
            User_Title.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            User_Title.Location = new Point(3, 19);
            User_Title.Name = "User_Title";
            User_Title.Size = new Size(89, 25);
            User_Title.TabIndex = 4;
            User_Title.Text = "USERS";
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(User_Title);
            Controls.Add(userCreationPanel);
            Controls.Add(Refresh_Btn);
            Controls.Add(Create_Btn);
            Controls.Add(user_datagd);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UserForm";
            Size = new Size(955, 616);
            Load += UserForm_Load_1;
            Resize += UserForm_Resize;
            ((System.ComponentModel.ISupportInitialize)user_datagd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView user_datagd;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn User_Type;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_Name;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn temp_password;
        private Button Create_Btn;
        private Button Refresh_Btn;
        private Panel userCreationPanel;
        private Label User_Title;
    }
}