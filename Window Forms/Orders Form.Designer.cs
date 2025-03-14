namespace inventory_system
{
    partial class Orders_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_Form));
            panel1 = new Panel();
            Order_search = new Button();
            Orders_refresh = new Button();
            Orders_add = new Button();
            panel3 = new Panel();
            textBox1 = new TextBox();
            dataGridView_Orders = new DataGridView();
            orders_id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Customername = new DataGridViewTextBoxColumn();
            Customerdetail = new DataGridViewTextBoxColumn();
            Po = new DataGridViewTextBoxColumn();
            Dr = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            Edit_order = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(Edit_order);
            panel1.Controls.Add(Order_search);
            panel1.Controls.Add(Orders_refresh);
            panel1.Controls.Add(Orders_add);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 59);
            panel1.TabIndex = 0;
            // 
            // Order_search
            // 
            Order_search.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_search.Image = (Image)resources.GetObject("Order_search.Image");
            Order_search.ImageAlign = ContentAlignment.MiddleLeft;
            Order_search.Location = new Point(573, 11);
            Order_search.Name = "Order_search";
            Order_search.Size = new Size(79, 40);
            Order_search.TabIndex = 3;
            Order_search.Text = "Search";
            Order_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            Order_search.UseVisualStyleBackColor = true;
            Order_search.Click += Order_search_Click;
            // 
            // Orders_refresh
            // 
            Orders_refresh.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_refresh.Image = (Image)resources.GetObject("Orders_refresh.Image");
            Orders_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_refresh.Location = new Point(90, 10);
            Orders_refresh.Name = "Orders_refresh";
            Orders_refresh.Size = new Size(79, 40);
            Orders_refresh.TabIndex = 1;
            Orders_refresh.Text = "Refresh";
            Orders_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_refresh.UseVisualStyleBackColor = true;
            // 
            // Orders_add
            // 
            Orders_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_add.Image = (Image)resources.GetObject("Orders_add.Image");
            Orders_add.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_add.Location = new Point(5, 10);
            Orders_add.Name = "Orders_add";
            Orders_add.Size = new Size(79, 40);
            Orders_add.TabIndex = 0;
            Orders_add.Text = "Add";
            Orders_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_add.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(326, 13);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 36);
            panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 9F);
            textBox1.Location = new Point(3, 10);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 16);
            textBox1.TabIndex = 2;
            // 
            // dataGridView_Orders
            // 
            dataGridView_Orders.AllowUserToAddRows = false;
            dataGridView_Orders.AllowUserToDeleteRows = false;
            dataGridView_Orders.AllowUserToOrderColumns = true;
            dataGridView_Orders.AllowUserToResizeColumns = false;
            dataGridView_Orders.AllowUserToResizeRows = false;
            dataGridView_Orders.BackgroundColor = Color.FromArgb(224, 224, 224);
            dataGridView_Orders.BorderStyle = BorderStyle.None;
            dataGridView_Orders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlDark;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Orders.ColumnHeadersHeight = 30;
            dataGridView_Orders.Columns.AddRange(new DataGridViewColumn[] { orders_id, Date, Customername, Customerdetail, Po, Dr, Total });
            dataGridView_Orders.Dock = DockStyle.Fill;
            dataGridView_Orders.EnableHeadersVisualStyles = false;
            dataGridView_Orders.GridColor = Color.LightGray;
            dataGridView_Orders.Location = new Point(0, 59);
            dataGridView_Orders.Name = "dataGridView_Orders";
            dataGridView_Orders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridView_Orders.RowHeadersVisible = false;
            dataGridView_Orders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView_Orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Orders.Size = new Size(955, 557);
            dataGridView_Orders.TabIndex = 1;
            // 
            // orders_id
            // 
            orders_id.HeaderText = "ID";
            orders_id.Name = "orders_id";
            // 
            // Date
            // 
            Date.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Date.HeaderText = "Date";
            Date.Name = "Date";
            Date.Width = 55;
            // 
            // Customername
            // 
            Customername.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customername.HeaderText = "Customer name ";
            Customername.Name = "Customername";
            // 
            // Customerdetail
            // 
            Customerdetail.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Customerdetail.HeaderText = "Customer Details";
            Customerdetail.Name = "Customerdetail";
            // 
            // Po
            // 
            Po.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Po.HeaderText = "PO.#";
            Po.Name = "Po";
            Po.Width = 57;
            // 
            // Dr
            // 
            Dr.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dr.HeaderText = "DR.#";
            Dr.Name = "Dr";
            Dr.Width = 56;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Total.HeaderText = "Total Amount(Php)";
            Total.Name = "Total";
            Total.Width = 132;
            // 
            // panel2
            // 
            panel2.Location = new Point(81, 88);
            panel2.Name = "panel2";
            panel2.Size = new Size(800, 411);
            panel2.TabIndex = 4;
            // 
            // Edit_order
            // 
            Edit_order.BackColor = Color.Gainsboro;
            Edit_order.FlatAppearance.BorderColor = Color.Black;
            Edit_order.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Edit_order.ForeColor = SystemColors.ActiveCaptionText;
            Edit_order.Image = (Image)resources.GetObject("Edit_order.Image");
            Edit_order.ImageAlign = ContentAlignment.MiddleLeft;
            Edit_order.Location = new Point(175, 11);
            Edit_order.Name = "Edit_order";
            Edit_order.Size = new Size(81, 39);
            Edit_order.TabIndex = 15;
            Edit_order.Text = "Edit";
            Edit_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            Edit_order.UseVisualStyleBackColor = false;
            // 
            // Orders_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel2);
            Controls.Add(dataGridView_Orders);
            Controls.Add(panel1);
            Name = "Orders_Form";
            Size = new Size(955, 616);
            Load += Orders_Form_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dataGridView_Orders;
        private Button Orders_add;
        private Button Orders_refresh;
        private Button Order_search;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn orders_id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Customername;
        private DataGridViewTextBoxColumn Customerdetail;
        private DataGridViewTextBoxColumn Po;
        private DataGridViewTextBoxColumn Dr;
        private DataGridViewTextBoxColumn Total;
        private Panel panel2;
        private Panel panel3;
        private Button Edit_order;
    }
}