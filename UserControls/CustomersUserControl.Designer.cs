namespace inventory_system
{
    partial class Customers_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Customers_Form));
            customers_datagd = new DataGridView();
            first_name = new DataGridViewTextBoxColumn();
            last_name = new DataGridViewTextBoxColumn();
            company_name = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            phone_number = new DataGridViewTextBoxColumn();
            address = new DataGridViewTextBoxColumn();
            customers_add_btn = new Button();
            customers_add_pnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)customers_datagd).BeginInit();
            SuspendLayout();
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
            customers_datagd.Location = new Point(0, 54);
            customers_datagd.Name = "customers_datagd";
            customers_datagd.Size = new Size(955, 563);
            customers_datagd.TabIndex = 0;
            // 
            // first_name
            // 
            first_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            first_name.HeaderText = "First Name";
            first_name.Name = "first_name";
            first_name.Resizable = DataGridViewTriState.False;
            // 
            // last_name
            // 
            last_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            last_name.HeaderText = "Last Name";
            last_name.Name = "last_name";
            // 
            // company_name
            // 
            company_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            company_name.HeaderText = "Company Name";
            company_name.Name = "company_name";
            // 
            // email
            // 
            email.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            email.HeaderText = "Email";
            email.Name = "email";
            // 
            // phone_number
            // 
            phone_number.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            phone_number.HeaderText = "Phone Number";
            phone_number.Name = "phone_number";
            // 
            // address
            // 
            address.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            address.HeaderText = "Address ";
            address.Name = "address";
            // 
            // customers_add_btn
            // 
            customers_add_btn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_add_btn.Image = (Image)resources.GetObject("customers_add_btn.Image");
            customers_add_btn.ImageAlign = ContentAlignment.MiddleLeft;
            customers_add_btn.Location = new Point(14, 8);
            customers_add_btn.Name = "customers_add_btn";
            customers_add_btn.Size = new Size(79, 40);
            customers_add_btn.TabIndex = 1;
            customers_add_btn.Text = "Add";
            customers_add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_add_btn.UseVisualStyleBackColor = true;
            customers_add_btn.Click += customers_add_btn_Click;
            // 
            // customers_add_pnl
            // 
            customers_add_pnl.Anchor = AnchorStyles.None;
            customers_add_pnl.Location = new Point(347, 13);
            customers_add_pnl.Name = "customers_add_pnl";
            customers_add_pnl.Size = new Size(261, 439);
            customers_add_pnl.TabIndex = 8;
            // 
            // Customers_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(customers_add_pnl);
            Controls.Add(customers_add_btn);
            Controls.Add(customers_datagd);
            Name = "Customers_Form";
            Size = new Size(955, 617);
            Load += Customers_Form_Load;
            ((System.ComponentModel.ISupportInitialize)customers_datagd).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView customers_datagd;
        private Button customers_add_btn;
        private Panel customers_add_pnl;
        private DataGridViewTextBoxColumn first_name;
        private DataGridViewTextBoxColumn last_name;
        private DataGridViewTextBoxColumn company_name;
        private DataGridViewTextBoxColumn email;
        private DataGridViewTextBoxColumn phone_number;
        private DataGridViewTextBoxColumn address;
    }
}