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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            userDataGd.DefaultCellStyle = dataGridViewCellStyle1;
            userDataGd.Location = new Point(0, 57);
            userDataGd.Name = "userDataGd";
            userDataGd.RowHeadersVisible = false;
            userDataGd.Size = new Size(955, 556);
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
    }
}