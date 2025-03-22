namespace inventory_system.Window_Forms
{
    partial class OrdersAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersAddForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            Label_add = new ReaLTaiizor.Controls.BigLabel();
            customerNameTbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            customerDetailsTbox = new TextBox();
            label3 = new Label();
            purchaseOrderTbox = new TextBox();
            DR_No = new Label();
            deliveryReceiptTbox = new TextBox();
            panel1 = new Panel();
            selectCustomerBtn = new Button();
            label10 = new Label();
            totalAmountTbox = new TextBox();
            New_ctm = new Label();
            panel2 = new Panel();
            label9 = new Label();
            itemLengthTbox = new TextBox();
            addItemBtn = new Button();
            dataGridView_Order = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            sellingPriceTbox = new TextBox();
            Order_dtle = new Label();
            label4 = new Label();
            label5 = new Label();
            itemCodeTbox = new TextBox();
            itemColorTbox = new TextBox();
            itemDescriptionTbox = new TextBox();
            label6 = new Label();
            label7 = new Label();
            itemShockTbox = new TextBox();
            deleteBtn = new Button();
            Exit_ordrs = new Button();
            addOrderBtn = new Button();
            poisonDataGridView1 = new ReaLTaiizor.Controls.PoisonDataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Label_add
            // 
            Label_add.AutoSize = true;
            Label_add.BackColor = Color.Transparent;
            Label_add.Font = new Font("Segoe UI", 25F);
            Label_add.ForeColor = Color.FromArgb(80, 80, 80);
            Label_add.Location = new Point(12, 9);
            Label_add.Name = "Label_add";
            Label_add.Size = new Size(179, 46);
            Label_add.TabIndex = 0;
            Label_add.Text = "Add Order";
            // 
            // customerNameTbox
            // 
            customerNameTbox.Location = new Point(3, 53);
            customerNameTbox.Name = "customerNameTbox";
            customerNameTbox.ReadOnly = true;
            customerNameTbox.Size = new Size(179, 23);
            customerNameTbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 35);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 79);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Customer Details";
            // 
            // customerDetailsTbox
            // 
            customerDetailsTbox.Location = new Point(3, 97);
            customerDetailsTbox.Name = "customerDetailsTbox";
            customerDetailsTbox.ReadOnly = true;
            customerDetailsTbox.Size = new Size(179, 23);
            customerDetailsTbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 123);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 6;
            label3.Text = "Purchase Order (PO.#)";
            // 
            // purchaseOrderTbox
            // 
            purchaseOrderTbox.Location = new Point(3, 141);
            purchaseOrderTbox.Name = "purchaseOrderTbox";
            purchaseOrderTbox.Size = new Size(179, 23);
            purchaseOrderTbox.TabIndex = 5;
            // 
            // DR_No
            // 
            DR_No.AutoSize = true;
            DR_No.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DR_No.Location = new Point(3, 167);
            DR_No.Name = "DR_No";
            DR_No.Size = new Size(129, 15);
            DR_No.TabIndex = 8;
            DR_No.Text = "Delivery Receip t(DR.#)";
            // 
            // deliveryReceiptTbox
            // 
            deliveryReceiptTbox.Location = new Point(3, 185);
            deliveryReceiptTbox.Name = "deliveryReceiptTbox";
            deliveryReceiptTbox.Size = new Size(179, 23);
            deliveryReceiptTbox.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(selectCustomerBtn);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(totalAmountTbox);
            panel1.Controls.Add(New_ctm);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DR_No);
            panel1.Controls.Add(customerNameTbox);
            panel1.Controls.Add(deliveryReceiptTbox);
            panel1.Controls.Add(customerDetailsTbox);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(purchaseOrderTbox);
            panel1.Location = new Point(9, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 334);
            panel1.TabIndex = 9;
            // 
            // selectCustomerBtn
            // 
            selectCustomerBtn.BackColor = Color.Silver;
            selectCustomerBtn.FlatStyle = FlatStyle.Popup;
            selectCustomerBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectCustomerBtn.ForeColor = SystemColors.ActiveCaptionText;
            selectCustomerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            selectCustomerBtn.Location = new Point(57, 288);
            selectCustomerBtn.Name = "selectCustomerBtn";
            selectCustomerBtn.Size = new Size(70, 36);
            selectCustomerBtn.TabIndex = 15;
            selectCustomerBtn.Text = "Select";
            selectCustomerBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            selectCustomerBtn.UseVisualStyleBackColor = false;
            selectCustomerBtn.Click += selectCustomerBtn_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.Location = new Point(3, 211);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 12;
            label10.Text = "Total Amount ₱";
            // 
            // totalAmountTbox
            // 
            totalAmountTbox.Location = new Point(3, 229);
            totalAmountTbox.Name = "totalAmountTbox";
            totalAmountTbox.ReadOnly = true;
            totalAmountTbox.Size = new Size(179, 23);
            totalAmountTbox.TabIndex = 11;
            // 
            // New_ctm
            // 
            New_ctm.AutoSize = true;
            New_ctm.Location = new Point(46, 9);
            New_ctm.Name = "New_ctm";
            New_ctm.Size = new Size(86, 15);
            New_ctm.TabIndex = 10;
            New_ctm.Text = "New Customer";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label9);
            panel2.Controls.Add(itemLengthTbox);
            panel2.Controls.Add(addItemBtn);
            panel2.Controls.Add(dataGridView_Order);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(sellingPriceTbox);
            panel2.Controls.Add(Order_dtle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(itemCodeTbox);
            panel2.Controls.Add(itemColorTbox);
            panel2.Controls.Add(itemDescriptionTbox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(itemShockTbox);
            panel2.Location = new Point(202, 65);
            panel2.Name = "panel2";
            panel2.Size = new Size(589, 334);
            panel2.TabIndex = 10;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 141);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 14;
            label9.Text = "Item Length";
            // 
            // itemLengthTbox
            // 
            itemLengthTbox.Location = new Point(3, 159);
            itemLengthTbox.Name = "itemLengthTbox";
            itemLengthTbox.Size = new Size(127, 23);
            itemLengthTbox.TabIndex = 13;
            // 
            // addItemBtn
            // 
            addItemBtn.BackColor = Color.Silver;
            addItemBtn.FlatStyle = FlatStyle.Popup;
            addItemBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemBtn.ForeColor = SystemColors.ActiveCaptionText;
            addItemBtn.Image = (Image)resources.GetObject("addItemBtn.Image");
            addItemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addItemBtn.Location = new Point(26, 288);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(70, 36);
            addItemBtn.TabIndex = 13;
            addItemBtn.Text = "Add";
            addItemBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addItemBtn.UseVisualStyleBackColor = false;
            addItemBtn.Click += Add_btn1_Click;
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AccessibleRole = AccessibleRole.None;
            dataGridView_Order.AllowUserToAddRows = false;
            dataGridView_Order.AllowUserToResizeColumns = false;
            dataGridView_Order.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = Color.White;
            dataGridView_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Order.BackgroundColor = Color.Gray;
            dataGridView_Order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Window;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView_Order.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_Order.GridColor = SystemColors.Window;
            dataGridView_Order.Location = new Point(136, 29);
            dataGridView_Order.MultiSelect = false;
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.ReadOnly = true;
            dataGridView_Order.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Window;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_Order.RowHeadersVisible = false;
            dataGridView_Order.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.BackColor = Color.Silver;
            dataGridViewCellStyle11.ForeColor = Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridView_Order.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView_Order.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView_Order.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridView_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Order.ShowEditingIcon = false;
            dataGridView_Order.ShowRowErrors = false;
            dataGridView_Order.Size = new Size(447, 295);
            dataGridView_Order.TabIndex = 12;
            // 
            // Column1
            // 
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle3;
            Column1.HeaderText = "Item Code";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            Column1.Width = 87;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle4;
            Column2.HeaderText = "Discription";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Column3.DefaultCellStyle = dataGridViewCellStyle5;
            Column3.HeaderText = "Length";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            Column3.Width = 69;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            Column4.DefaultCellStyle = dataGridViewCellStyle6;
            Column4.HeaderText = "Stock";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            Column4.Width = 61;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            Column5.DefaultCellStyle = dataGridViewCellStyle7;
            Column5.HeaderText = "Color";
            Column5.Name = "Column5";
            Column5.ReadOnly = true;
            Column5.Width = 61;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            Column6.DefaultCellStyle = dataGridViewCellStyle8;
            Column6.HeaderText = "Selling Price";
            Column6.Name = "Column6";
            Column6.ReadOnly = true;
            Column6.Width = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 229);
            label8.Name = "label8";
            label8.Size = new Size(72, 15);
            label8.TabIndex = 11;
            label8.Text = "Selling Price";
            // 
            // sellingPriceTbox
            // 
            sellingPriceTbox.Location = new Point(2, 247);
            sellingPriceTbox.Name = "sellingPriceTbox";
            sellingPriceTbox.Size = new Size(128, 23);
            sellingPriceTbox.TabIndex = 10;
            // 
            // Order_dtle
            // 
            Order_dtle.AutoSize = true;
            Order_dtle.Location = new Point(235, 9);
            Order_dtle.Name = "Order_dtle";
            Order_dtle.Size = new Size(70, 15);
            Order_dtle.TabIndex = 9;
            Order_dtle.Text = "Order Detail";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 9);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "Item Code";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 185);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Item Color";
            // 
            // itemCodeTbox
            // 
            itemCodeTbox.Location = new Point(3, 27);
            itemCodeTbox.Name = "itemCodeTbox";
            itemCodeTbox.Size = new Size(127, 23);
            itemCodeTbox.TabIndex = 1;
            // 
            // itemColorTbox
            // 
            itemColorTbox.Location = new Point(3, 203);
            itemColorTbox.Name = "itemColorTbox";
            itemColorTbox.Size = new Size(127, 23);
            itemColorTbox.TabIndex = 7;
            // 
            // itemDescriptionTbox
            // 
            itemDescriptionTbox.Location = new Point(3, 71);
            itemDescriptionTbox.Name = "itemDescriptionTbox";
            itemDescriptionTbox.Size = new Size(127, 23);
            itemDescriptionTbox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 97);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 6;
            label6.Text = "Item Stock";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 53);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 4;
            label7.Text = "Item Description";
            // 
            // itemShockTbox
            // 
            itemShockTbox.Location = new Point(3, 115);
            itemShockTbox.Name = "itemShockTbox";
            itemShockTbox.Size = new Size(127, 23);
            itemShockTbox.TabIndex = 5;
            itemShockTbox.TextChanged += itemShockTbox_TextChanged;
            // 
            // deleteBtn
            // 
            deleteBtn.BackColor = Color.Silver;
            deleteBtn.FlatStyle = FlatStyle.Popup;
            deleteBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = SystemColors.ActiveCaptionText;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(317, 23);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(86, 36);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // Exit_ordrs
            // 
            Exit_ordrs.BackColor = SystemColors.ButtonFace;
            Exit_ordrs.BackgroundImage = (Image)resources.GetObject("Exit_ordrs.BackgroundImage");
            Exit_ordrs.BackgroundImageLayout = ImageLayout.Center;
            Exit_ordrs.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            Exit_ordrs.FlatAppearance.BorderSize = 2;
            Exit_ordrs.FlatStyle = FlatStyle.Popup;
            Exit_ordrs.Location = new Point(759, 9);
            Exit_ordrs.Name = "Exit_ordrs";
            Exit_ordrs.Size = new Size(27, 26);
            Exit_ordrs.TabIndex = 15;
            Exit_ordrs.UseVisualStyleBackColor = false;
            Exit_ordrs.Click += Exit_ordrs_Click;
            // 
            // addOrderBtn
            // 
            addOrderBtn.BackColor = Color.Silver;
            addOrderBtn.FlatStyle = FlatStyle.Popup;
            addOrderBtn.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderBtn.ForeColor = SystemColors.ActiveCaptionText;
            addOrderBtn.Image = (Image)resources.GetObject("addOrderBtn.Image");
            addOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addOrderBtn.Location = new Point(202, 23);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new Size(109, 36);
            addOrderBtn.TabIndex = 15;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addOrderBtn.UseVisualStyleBackColor = false;
            addOrderBtn.Click += Add_order_Click;
            // 
            // poisonDataGridView1
            // 
            poisonDataGridView1.AllowUserToAddRows = false;
            poisonDataGridView1.AllowUserToDeleteRows = false;
            poisonDataGridView1.AllowUserToResizeRows = false;
            poisonDataGridView1.BackgroundColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.BorderStyle = BorderStyle.None;
            poisonDataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.None;
            poisonDataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle12.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle12.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            poisonDataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle13.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            poisonDataGridView1.DefaultCellStyle = dataGridViewCellStyle13;
            poisonDataGridView1.EnableHeadersVisualStyles = false;
            poisonDataGridView1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            poisonDataGridView1.GridColor = Color.FromArgb(255, 255, 255);
            poisonDataGridView1.Location = new Point(797, 93);
            poisonDataGridView1.Name = "poisonDataGridView1";
            poisonDataGridView1.ReadOnly = true;
            poisonDataGridView1.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle14.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            poisonDataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            poisonDataGridView1.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            poisonDataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            poisonDataGridView1.Size = new Size(321, 297);
            poisonDataGridView1.TabIndex = 15;
            // 
            // OrdersAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(poisonDataGridView1);
            Controls.Add(addOrderBtn);
            Controls.Add(Exit_ordrs);
            Controls.Add(deleteBtn);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Label_add);
            Name = "OrdersAddForm";
            Size = new Size(1136, 411);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            ((System.ComponentModel.ISupportInitialize)poisonDataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel Label_add;
        private TextBox customerNameTbox;
        private Label label1;
        private Label label2;
        private TextBox customerDetailsTbox;
        private Label label3;
        private TextBox purchaseOrderTbox;
        private Label DR_No;
        private TextBox deliveryReceiptTbox;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private TextBox itemCodeTbox;
        private Label New_ctm;
        private Label Order_dtle;
        private Label label5;
        private TextBox itemColorTbox;
        private TextBox itemDescriptionTbox;
        private Label label6;
        private Label label7;
        private TextBox itemShockTbox;
        private Label label8;
        private TextBox sellingPriceTbox;
        private DataGridView dataGridView_Order;
        private Label label9;
        private TextBox itemLengthTbox;
        private Label label10;
        private TextBox totalAmountTbox;
        private Button addItemBtn;
        private Button deleteBtn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button Exit_ordrs;
        private Button addOrderBtn;
        private Button selectCustomerBtn;
        private ReaLTaiizor.Controls.PoisonDataGridView poisonDataGridView1;
    }
}