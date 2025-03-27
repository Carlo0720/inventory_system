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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_Form));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            panel1 = new Panel();
            Print_Rcpt = new Button();
            label_Orders_Title = new Label();
            Orders_refresh = new Button();
            Orders_add = new Button();
            panel3 = new Panel();
            textBox1 = new TextBox();
            Order_search = new Button();
            dataGridView_Orders = new DataGridView();
            orders_id = new DataGridViewTextBoxColumn();
            Date = new DataGridViewTextBoxColumn();
            Customername = new DataGridViewTextBoxColumn();
            Customerdetail = new DataGridViewTextBoxColumn();
            Po = new DataGridViewTextBoxColumn();
            Dr = new DataGridViewTextBoxColumn();
            Total = new DataGridViewTextBoxColumn();
            ordersAddPanel = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Orders).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(Print_Rcpt);
            panel1.Controls.Add(label_Orders_Title);
            panel1.Controls.Add(Orders_refresh);
            panel1.Controls.Add(Orders_add);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(955, 59);
            panel1.TabIndex = 0;
            // 
            // Print_Rcpt
            // 
            Print_Rcpt.BackColor = Color.MediumSeaGreen;
            Print_Rcpt.FlatAppearance.BorderSize = 0;
            Print_Rcpt.FlatStyle = FlatStyle.Flat;
            Print_Rcpt.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Print_Rcpt.ForeColor = Color.White;
            Print_Rcpt.Image = (Image)resources.GetObject("Print_Rcpt.Image");
            Print_Rcpt.Location = new Point(117, 10);
            Print_Rcpt.Name = "Print_Rcpt";
            Print_Rcpt.Size = new Size(106, 38);
            Print_Rcpt.TabIndex = 17;
            Print_Rcpt.Text = "Print";
            Print_Rcpt.TextImageRelation = TextImageRelation.ImageBeforeText;
            Print_Rcpt.UseVisualStyleBackColor = false;
            // 
            // label_Orders_Title
            // 
            label_Orders_Title.AutoSize = true;
            label_Orders_Title.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Orders_Title.Location = new Point(3, 16);
            label_Orders_Title.Name = "label_Orders_Title";
            label_Orders_Title.Size = new Size(108, 25);
            label_Orders_Title.TabIndex = 16;
            label_Orders_Title.Text = "ORDERS";
            // 
            // Orders_refresh
            // 
            Orders_refresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Orders_refresh.BackColor = Color.OrangeRed;
            Orders_refresh.FlatAppearance.BorderSize = 0;
            Orders_refresh.FlatStyle = FlatStyle.Flat;
            Orders_refresh.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_refresh.ForeColor = Color.White;
            Orders_refresh.Image = (Image)resources.GetObject("Orders_refresh.Image");
            Orders_refresh.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_refresh.Location = new Point(677, 10);
            Orders_refresh.Name = "Orders_refresh";
            Orders_refresh.Size = new Size(135, 39);
            Orders_refresh.TabIndex = 1;
            Orders_refresh.Text = "Refresh";
            Orders_refresh.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_refresh.UseVisualStyleBackColor = false;
            Orders_refresh.Click += Orders_refresh_Click;
            // 
            // Orders_add
            // 
            Orders_add.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Orders_add.BackColor = Color.MediumSeaGreen;
            Orders_add.FlatStyle = FlatStyle.Flat;
            Orders_add.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Orders_add.ForeColor = Color.White;
            Orders_add.Image = (Image)resources.GetObject("Orders_add.Image");
            Orders_add.ImageAlign = ContentAlignment.MiddleLeft;
            Orders_add.Location = new Point(818, 9);
            Orders_add.Name = "Orders_add";
            Orders_add.Size = new Size(125, 40);
            Orders_add.TabIndex = 0;
            Orders_add.Text = "Create";
            Orders_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            Orders_add.UseVisualStyleBackColor = false;
            Orders_add.Click += Orders_add_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(Order_search);
            panel3.Location = new Point(277, 9);
            panel3.Name = "panel3";
            panel3.Size = new Size(394, 39);
            panel3.TabIndex = 4;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Verdana", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(10, 8);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(254, 24);
            textBox1.TabIndex = 2;
            // 
            // Order_search
            // 
            Order_search.BackColor = Color.DodgerBlue;
            Order_search.FlatStyle = FlatStyle.Flat;
            Order_search.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_search.ForeColor = Color.White;
            Order_search.Image = (Image)resources.GetObject("Order_search.Image");
            Order_search.ImageAlign = ContentAlignment.MiddleLeft;
            Order_search.Location = new Point(272, 0);
            Order_search.Name = "Order_search";
            Order_search.Size = new Size(121, 39);
            Order_search.TabIndex = 3;
            Order_search.Text = "Search";
            Order_search.TextImageRelation = TextImageRelation.ImageBeforeText;
            Order_search.UseVisualStyleBackColor = false;
            Order_search.Click += Order_search_Click;
            // 
            // dataGridView_Orders
            // 
            dataGridView_Orders.AllowUserToAddRows = false;
            dataGridView_Orders.AllowUserToDeleteRows = false;
            dataGridView_Orders.AllowUserToOrderColumns = true;
            dataGridView_Orders.AllowUserToResizeColumns = false;
            dataGridView_Orders.AllowUserToResizeRows = false;
            dataGridView_Orders.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Orders.BackgroundColor = Color.WhiteSmoke;
            dataGridView_Orders.BorderStyle = BorderStyle.None;
            dataGridView_Orders.CellBorderStyle = DataGridViewCellBorderStyle.SingleVertical;
            dataGridView_Orders.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.ControlLightLight;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView_Orders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Orders.ColumnHeadersHeight = 30;
            dataGridView_Orders.Columns.AddRange(new DataGridViewColumn[] { orders_id, Date, Customername, Customerdetail, Po, Dr, Total });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.White;
            dataGridViewCellStyle2.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle2.SelectionForeColor = Color.SteelBlue;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridView_Orders.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Orders.GridColor = Color.Silver;
            dataGridView_Orders.Location = new Point(0, 59);
            dataGridView_Orders.Name = "dataGridView_Orders";
            dataGridView_Orders.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = Color.White;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView_Orders.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView_Orders.RowHeadersVisible = false;
            dataGridView_Orders.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SteelBlue;
            dataGridView_Orders.RowsDefaultCellStyle = dataGridViewCellStyle4;
            dataGridView_Orders.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView_Orders.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridView_Orders.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView_Orders.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dataGridView_Orders.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            dataGridView_Orders.RowTemplate.DividerHeight = 1;
            dataGridView_Orders.RowTemplate.Height = 35;
            dataGridView_Orders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Orders.Size = new Size(955, 558);
            dataGridView_Orders.TabIndex = 1;
            dataGridView_Orders.CellDoubleClick += dataGridView_Orders_CellDoubleClick;
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
            Date.Width = 61;
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
            Po.Width = 62;
            // 
            // Dr
            // 
            Dr.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Dr.HeaderText = "DR.#";
            Dr.Name = "Dr";
            Dr.Width = 61;
            // 
            // Total
            // 
            Total.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Total.HeaderText = "Total Amount(Php)";
            Total.Name = "Total";
            Total.Width = 149;
            // 
            // ordersAddPanel
            // 
            ordersAddPanel.Anchor = AnchorStyles.None;
            ordersAddPanel.BackColor = Color.WhiteSmoke;
            ordersAddPanel.Location = new Point(81, 88);
            ordersAddPanel.Name = "ordersAddPanel";
            ordersAddPanel.Size = new Size(800, 411);
            ordersAddPanel.TabIndex = 4;
            // 
            // Orders_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ordersAddPanel);
            Controls.Add(dataGridView_Orders);
            Controls.Add(panel1);
            Name = "Orders_Form";
            Size = new Size(955, 617);
            Load += Orders_Form_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private Panel ordersAddPanel;
        private Panel panel3;
        private DataGridViewTextBoxColumn orders_id;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Customername;
        private DataGridViewTextBoxColumn Customerdetail;
        private DataGridViewTextBoxColumn Po;
        private DataGridViewTextBoxColumn Dr;
        private DataGridViewTextBoxColumn Total;
        private Label label_Orders_Title;
        private Button Print_Rcpt;
    }
}