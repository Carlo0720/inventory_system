namespace inventory_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserForm));
            userDataGd = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            User_Type = new DataGridViewTextBoxColumn();
            First_Name = new DataGridViewTextBoxColumn();
            Last_Name = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            temp_password = new DataGridViewTextBoxColumn();
            Create_Btn = new Button();
            Refresh_Btn = new Button();
            ((System.ComponentModel.ISupportInitialize)userDataGd).BeginInit();
            SuspendLayout();
            // 
            // userDataGd
            // 
            userDataGd.AllowUserToAddRows = false;
            userDataGd.AllowUserToDeleteRows = false;
            userDataGd.AllowUserToOrderColumns = true;
            userDataGd.AllowUserToResizeColumns = false;
            userDataGd.AllowUserToResizeRows = false;
            userDataGd.BorderStyle = BorderStyle.None;
            userDataGd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            userDataGd.Columns.AddRange(new DataGridViewColumn[] { ID, User_Type, First_Name, Last_Name, Username, temp_password });
            userDataGd.Location = new Point(0, 57);
            userDataGd.Name = "userDataGd";
            userDataGd.RowHeadersVisible = false;
            userDataGd.Size = new Size(955, 556);
            userDataGd.TabIndex = 0;
            userDataGd.CellContentClick += userDataGd_CellContentClick;
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
            temp_password.Width = 82;
            // 
            // Create_Btn
            // 
            Create_Btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Create_Btn.Image = (Image)resources.GetObject("Create_Btn.Image");
            Create_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Create_Btn.Location = new Point(3, 11);
            Create_Btn.Name = "Create_Btn";
            Create_Btn.Size = new Size(79, 40);
            Create_Btn.TabIndex = 1;
            Create_Btn.Text = "Create";
            Create_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Create_Btn.UseVisualStyleBackColor = true;
            Create_Btn.Click += Create_Btn_Click;
            // 
            // Refresh_Btn
            // 
            Refresh_Btn.BackColor = Color.Silver;
            Refresh_Btn.Image = (Image)resources.GetObject("Refresh_Btn.Image");
            Refresh_Btn.ImageAlign = ContentAlignment.MiddleLeft;
            Refresh_Btn.Location = new Point(88, 11);
            Refresh_Btn.Name = "Refresh_Btn";
            Refresh_Btn.Size = new Size(79, 40);
            Refresh_Btn.TabIndex = 2;
            Refresh_Btn.Text = "Refresh";
            Refresh_Btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            Refresh_Btn.UseVisualStyleBackColor = true;
            Refresh_Btn.Click += button1_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Refresh_Btn);
            Controls.Add(Create_Btn);
            Controls.Add(userDataGd);
            Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Name = "UserForm";
            Size = new Size(955, 616);
            Load += UserForm_Load_1;
            Resize += UserForm_Resize;
            ((System.ComponentModel.ISupportInitialize)userDataGd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView userDataGd;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn User_Type;
        private DataGridViewTextBoxColumn First_Name;
        private DataGridViewTextBoxColumn Last_Name;
        private DataGridViewTextBoxColumn Username;
        private DataGridViewTextBoxColumn temp_password;
        private Button Create_Btn;
        private Button Refresh_Btn;
    }
}