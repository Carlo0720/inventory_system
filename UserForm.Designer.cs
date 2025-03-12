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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            userDataGd = new DataGridView();
            ID = new DataGridViewTextBoxColumn();
            User_Type = new DataGridViewTextBoxColumn();
            First_Name = new DataGridViewTextBoxColumn();
            Last_Name = new DataGridViewTextBoxColumn();
            Username = new DataGridViewTextBoxColumn();
            temp_password = new DataGridViewTextBoxColumn();
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
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            userDataGd.DefaultCellStyle = dataGridViewCellStyle2;
            userDataGd.Location = new Point(0, 59);
            userDataGd.Name = "userDataGd";
            userDataGd.Size = new Size(955, 557);
            userDataGd.TabIndex = 0;
            // 
            // ID
            // 
            ID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ID.HeaderText = "ID";
            ID.Name = "ID";
            ID.Width = 43;
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
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(userDataGd);
            Name = "UserForm";
            Size = new Size(955, 616);
            Load += UserForm_Load_1;
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
    }
}