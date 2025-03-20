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
            flowLayoutPanel2 = new FlowLayoutPanel();
            customers_add_btn = new Button();
            cancelBtn = new Button();
            panel1 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            customers_datagd = new DataGridView();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            company_name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            flowLayoutPanel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)customers_datagd).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(customers_add_btn);
            flowLayoutPanel2.Controls.Add(cancelBtn);
            flowLayoutPanel2.Location = new Point(10, 423);
            flowLayoutPanel2.Margin = new Padding(10);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.RightToLeft = RightToLeft.Yes;
            flowLayoutPanel2.Size = new Size(591, 50);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // customers_add_btn
            // 
            customers_add_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_add_btn.Image = (Image)resources.GetObject("customers_add_btn.Image");
            customers_add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            customers_add_btn.Location = new Point(509, 3);
            customers_add_btn.Name = "customers_add_btn";
            customers_add_btn.Size = new Size(79, 40);
            customers_add_btn.TabIndex = 2;
            customers_add_btn.Text = "Add";
            customers_add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_add_btn.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            cancelBtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            cancelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            cancelBtn.Location = new Point(424, 3);
            cancelBtn.Name = "cancelBtn";
            cancelBtn.Size = new Size(79, 40);
            cancelBtn.TabIndex = 3;
            cancelBtn.Text = "Cancel";
            cancelBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            cancelBtn.UseVisualStyleBackColor = true;
            cancelBtn.Click += cancelBtn_Click;
            // 
            // panel1
            // 
            panel1.Location = new Point(10, 10);
            panel1.Margin = new Padding(10);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.No;
            panel1.Size = new Size(591, 52);
            panel1.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Controls.Add(customers_datagd);
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(611, 527);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // customers_datagd
            // 
            customers_datagd.AllowUserToAddRows = false;
            customers_datagd.AllowUserToDeleteRows = false;
            customers_datagd.AllowUserToResizeColumns = false;
            customers_datagd.AllowUserToResizeRows = false;
            customers_datagd.BackgroundColor = Color.FromArgb(224, 224, 224);
            customers_datagd.BorderStyle = BorderStyle.None;
            customers_datagd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            customers_datagd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customers_datagd.Columns.AddRange(new DataGridViewColumn[] { first_name, last_name, company_name, email, phone_number, address });
            customers_datagd.Location = new Point(10, 82);
            customers_datagd.Margin = new Padding(10);
            customers_datagd.MultiSelect = false;
            customers_datagd.Name = "customers_datagd";
            customers_datagd.ReadOnly = true;
            customers_datagd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            customers_datagd.Size = new Size(591, 321);
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
            // OrderAddForm_Customer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(flowLayoutPanel1);
            Name = "OrderAddForm_Customer";
            Size = new Size(611, 527);
            Load += OrderAddForm_Customer_Load;
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)customers_datagd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel2;
        private Button customers_add_btn;
        private Button cancelBtn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private DataGridView customers_datagd;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn company_name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address;
    }
}
