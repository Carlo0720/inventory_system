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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            label1 = new Label();
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
            customers_datagd.BackgroundColor = Color.WhiteSmoke;
            customers_datagd.BorderStyle = BorderStyle.None;
            customers_datagd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            customers_datagd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            customers_datagd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            customers_datagd.ColumnHeadersHeight = 30;
            customers_datagd.Columns.AddRange(new DataGridViewColumn[] { first_name, last_name, company_name, email, phone_number, address });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            customers_datagd.DefaultCellStyle = dataGridViewCellStyle2;
            customers_datagd.GridColor = Color.Black;
            customers_datagd.Location = new Point(0, 54);
            customers_datagd.Name = "customers_datagd";
            customers_datagd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            customers_datagd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            customers_datagd.RowHeadersVisible = false;
            customers_datagd.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Arial Rounded MT Bold", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SteelBlue;
            customers_datagd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            customers_datagd.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            customers_datagd.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            customers_datagd.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_datagd.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            customers_datagd.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            customers_datagd.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            customers_datagd.RowTemplate.DividerHeight = 1;
            customers_datagd.RowTemplate.Height = 35;
            customers_datagd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
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
            customers_add_btn.BackColor = Color.MediumSeaGreen;
            customers_add_btn.FlatAppearance.BorderColor = Color.White;
            customers_add_btn.FlatAppearance.MouseDownBackColor = Color.ForestGreen;
            customers_add_btn.FlatAppearance.MouseOverBackColor = Color.LimeGreen;
            customers_add_btn.FlatStyle = FlatStyle.Flat;
            customers_add_btn.Font = new Font("Myanmar Text", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            customers_add_btn.ForeColor = Color.White;
            customers_add_btn.Image = (Image)resources.GetObject("customers_add_btn.Image");
            customers_add_btn.ImageAlign = ContentAlignment.TopLeft;
            customers_add_btn.Location = new Point(183, 8);
            customers_add_btn.Name = "customers_add_btn";
            customers_add_btn.Size = new Size(93, 34);
            customers_add_btn.TabIndex = 1;
            customers_add_btn.Text = "Add";
            customers_add_btn.TextAlign = ContentAlignment.TopCenter;
            customers_add_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            customers_add_btn.UseVisualStyleBackColor = false;
            customers_add_btn.Click += customers_add_btn_Click;
            // 
            // customers_add_pnl
            // 
            customers_add_pnl.Anchor = AnchorStyles.None;
            customers_add_pnl.Location = new Point(347, 54);
            customers_add_pnl.Name = "customers_add_pnl";
            customers_add_pnl.Size = new Size(261, 439);
            customers_add_pnl.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Verdana", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 11);
            label1.Name = "label1";
            label1.Size = new Size(177, 29);
            label1.TabIndex = 9;
            label1.Text = "CUSTOMERS";
            // 
            // Customers_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label1);
            Controls.Add(customers_add_pnl);
            Controls.Add(customers_add_btn);
            Controls.Add(customers_datagd);
            Name = "Customers_Form";
            Size = new Size(955, 617);
            Load += Customers_Form_Load;
            ((System.ComponentModel.ISupportInitialize)customers_datagd).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label label1;
    }
}