namespace inventory_system.UserControls.Order
{
    partial class OrderAddForm_Customer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAddForm_Customer));
            customers_add_btn = new Button();
            cancelBtn = new Button();
            customers_datagd = new DataGridView();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            company_name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            textBox1 = new TextBox();
            Order_search = new Button();
            ((System.ComponentModel.ISupportInitialize)customers_datagd).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // customers_add_btn
            // 
            customers_add_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            customers_add_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_add_btn.Image = (Image)resources.GetObject("customers_add_btn.Image");
            customers_add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            customers_add_btn.Location = new Point(522, 427);
            customers_add_btn.Name = "customers_add_btn";
            customers_add_btn.Size = new Size(79, 40);
            customers_add_btn.TabIndex = 2;
            customers_add_btn.Text = "Add";
            customers_add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_add_btn.UseVisualStyleBackColor = true;
            customers_add_btn.Click += customers_add_btn_Click;
            // 
            // cancelBtn
            // 
            cancelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            cancelBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(437, 427);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(79, 40);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // customers_datagd
            // 
            customers_datagd.AllowUserToAddRows = false;
            customers_datagd.AllowUserToDeleteRows = false;
            customers_datagd.AllowUserToResizeColumns = false;
            customers_datagd.AllowUserToResizeRows = false;
            customers_datagd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            customers_datagd.BackgroundColor = Color.FromArgb(224, 224, 224);
            customers_datagd.BorderStyle = BorderStyle.None;
            customers_datagd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            customers_datagd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customers_datagd.Columns.AddRange(new DataGridViewColumn[] { first_name, last_name, company_name, email, phone_number, address });
            customers_datagd.Location = new Point(10, 65);
            customers_datagd.Margin = new Padding(10);
            customers_datagd.MultiSelect = false;
            customers_datagd.Name = "customers_datagd";
            customers_datagd.ReadOnly = true;
            customers_datagd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customers_datagd.Size = new Size(591, 349);
            customers_datagd.TabIndex = 3;
            customers_datagd.CellDoubleClick += customers_datagd_CellDoubleClick;
            // 
            // first_name
            // 
            first_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            first_name.HeaderText = "First Name";
            first_name.Name = "first_name";
            first_name.ReadOnly = true;
            first_name.Resizable = DataGridViewTriState.False;
            // 
            // last_name
            // 
            last_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            last_name.HeaderText = "Last Name";
            last_name.Name = "last_name";
            last_name.ReadOnly = true;
            // 
            // company_name
            // 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            company_name.HeaderText = "Company Name";
            company_name.Name = "company_name";
            company_name.ReadOnly = true;
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.Name = "email";
            email.ReadOnly = true;
            // 
            // phone_number
            // 
            phone_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone_number.HeaderText = "Phone Number";
            phone_number.Name = "phone_number";
            phone_number.ReadOnly = true;
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Address ";
            address.Name = "address";
            address.ReadOnly = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(Order_search);
            panel3.Location = new Point(10, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(395, 36);
            panel3.TabIndex = 5;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(3, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(307, 16);
            textBox1.TabIndex = 2;
            // 
            // Order_search
            // 
            Order_search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_search.Image = (Image)resources.GetObject("Order_search.Image");
            Order_search.ImageAlign = ContentAlignment.MiddleLeft;
            Order_search.Location = new Point(316, -4);
            Order_search.Name = "Order_search";
            Order_search.Size = new Size(79, 40);
            Order_search.TabIndex = 3;
            Order_search.Text = "Search";
            Order_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            Order_search.UseVisualStyleBackColor = true;
            // 
            // OrderAddForm_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel3);
            Controls.Add(customers_datagd);
            Controls.Add(customers_add_btn);
            Controls.Add(cancelBtn);
            Name = "OrderAddForm_Customer";
            Size = new Size(611, 480);
            Load += OrderAddForm_Customer_Load;
            ((System.ComponentModel.ISupportInitialize)customers_datagd).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button customers_add_btn;
        private Button cancelBtn;
        private DataGridView customers_datagd;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn company_name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address;
        private Panel panel3;
        private TextBox textBox1;
        private Button Order_search;
    }
}
