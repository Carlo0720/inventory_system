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
            customerNameTbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            customerDetailsTbox = new TextBox();
            label3 = new Label();
            purchaseOrderTbox = new TextBox();
            DR_No = new Label();
            deliveryReceiptTbox = new TextBox();
            selectCustomerBtn = new Button();
            label10 = new Label();
            totalAmountTbox = new TextBox();
            addItemBtn = new Button();
            dataGridView_Order = new DataGridView();
            item_code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            color = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            Order_dtle = new Label();
            deleteBtn = new Button();
            addOrderBtn = new Button();
            panel3 = new ReaLTaiizor.Controls.Panel();
            Label_add = new ReaLTaiizor.Controls.BigLabel();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // customerNameTbox
            // 
            customerNameTbox.Location = new Point(8, 54);
            customerNameTbox.Name = "customerNameTbox";
            customerNameTbox.ReadOnly = true;
            customerNameTbox.Size = new Size(179, 23);
            customerNameTbox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.Location = new Point(8, 36);
            label1.Name = "label1";
            label1.Size = new Size(93, 15);
            label1.TabIndex = 2;
            label1.Text = "Customer Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(8, 80);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 4;
            label2.Text = "Customer Details";
            // 
            // customerDetailsTbox
            // 
            customerDetailsTbox.Location = new Point(8, 98);
            customerDetailsTbox.Name = "customerDetailsTbox";
            customerDetailsTbox.ReadOnly = true;
            customerDetailsTbox.Size = new Size(179, 23);
            customerDetailsTbox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(8, 173);
            label3.Name = "label3";
            label3.Size = new Size(124, 15);
            label3.TabIndex = 6;
            label3.Text = "Purchase Order (PO.#)";
            // 
            // purchaseOrderTbox
            // 
            purchaseOrderTbox.Location = new Point(8, 191);
            purchaseOrderTbox.Name = "purchaseOrderTbox";
            purchaseOrderTbox.Size = new Size(179, 23);
            purchaseOrderTbox.TabIndex = 5;
            // 
            // DR_No
            // 
            DR_No.AutoSize = true;
            DR_No.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DR_No.Location = new Point(8, 217);
            DR_No.Name = "DR_No";
            DR_No.Size = new Size(129, 15);
            DR_No.TabIndex = 8;
            DR_No.Text = "Delivery Receip t(DR.#)";
            // 
            // deliveryReceiptTbox
            // 
            deliveryReceiptTbox.Location = new Point(8, 235);
            deliveryReceiptTbox.Name = "deliveryReceiptTbox";
            deliveryReceiptTbox.Size = new Size(179, 23);
            deliveryReceiptTbox.TabIndex = 7;
            // 
            // selectCustomerBtn
            // 
            selectCustomerBtn.BackColor = Color.DodgerBlue;
            selectCustomerBtn.FlatAppearance.BorderSize = 0;
            selectCustomerBtn.FlatStyle = FlatStyle.Flat;
            selectCustomerBtn.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            selectCustomerBtn.ForeColor = Color.White;
            selectCustomerBtn.ImageAlign = ContentAlignment.MiddleLeft;
            selectCustomerBtn.Location = new Point(8, 127);
            selectCustomerBtn.Name = "selectCustomerBtn";
            selectCustomerBtn.Size = new Size(179, 36);
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
            label10.Location = new Point(8, 261);
            label10.Name = "label10";
            label10.Size = new Size(90, 15);
            label10.TabIndex = 12;
            label10.Text = "Total Amount ₱";
            // 
            // totalAmountTbox
            // 
            totalAmountTbox.Location = new Point(8, 279);
            totalAmountTbox.Name = "totalAmountTbox";
            totalAmountTbox.ReadOnly = true;
            totalAmountTbox.Size = new Size(179, 23);
            totalAmountTbox.TabIndex = 11;
            // 
            // addItemBtn
            // 
            addItemBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addItemBtn.BackColor = Color.MediumSeaGreen;
            addItemBtn.FlatAppearance.BorderSize = 0;
            addItemBtn.FlatStyle = FlatStyle.Flat;
            addItemBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addItemBtn.ForeColor = Color.White;
            addItemBtn.Image = (Image)resources.GetObject("addItemBtn.Image");
            addItemBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addItemBtn.Location = new Point(619, 337);
            addItemBtn.Name = "addItemBtn";
            addItemBtn.Size = new Size(88, 36);
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
            dataGridView_Order.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Order.BackgroundColor = Color.White;
            dataGridView_Order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.DimGray;
            dataGridViewCellStyle2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Columns.AddRange(new DataGridViewColumn[] { item_code, description, product_id, quantity, color, price });
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.Silver;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle9.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.False;
            dataGridView_Order.DefaultCellStyle = dataGridViewCellStyle9;
            dataGridView_Order.GridColor = Color.Silver;
            dataGridView_Order.Location = new Point(200, 36);
            dataGridView_Order.MultiSelect = false;
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.ReadOnly = true;
            dataGridView_Order.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = Color.White;
            dataGridViewCellStyle10.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle10;
            dataGridView_Order.RowHeadersVisible = false;
            dataGridView_Order.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle11.BackColor = Color.LightGray;
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridView_Order.RowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridView_Order.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            dataGridView_Order.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridView_Order.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            dataGridView_Order.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            dataGridView_Order.RowTemplate.DividerHeight = 1;
            dataGridView_Order.RowTemplate.Height = 35;
            dataGridView_Order.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView_Order.ShowEditingIcon = false;
            dataGridView_Order.ShowRowErrors = false;
            dataGridView_Order.Size = new Size(507, 295);
            dataGridView_Order.TabIndex = 12;
            // 
            // item_code
            // 
            dataGridViewCellStyle3.BackColor = Color.Silver;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            item_code.DefaultCellStyle = dataGridViewCellStyle3;
            item_code.HeaderText = "Item Code";
            item_code.Name = "item_code";
            item_code.ReadOnly = true;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.BackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle4.SelectionForeColor = Color.Black;
            description.DefaultCellStyle = dataGridViewCellStyle4;
            description.HeaderText = "Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            product_id.DefaultCellStyle = dataGridViewCellStyle5;
            product_id.HeaderText = "product_id";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Width = 102;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle6.SelectionForeColor = Color.Black;
            quantity.DefaultCellStyle = dataGridViewCellStyle6;
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 89;
            // 
            // color
            // 
            color.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            color.DefaultCellStyle = dataGridViewCellStyle7;
            color.HeaderText = "Color";
            color.Name = "color";
            color.ReadOnly = true;
            color.Width = 65;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle8.SelectionForeColor = Color.Black;
            price.DefaultCellStyle = dataGridViewCellStyle8;
            price.HeaderText = "Selling Price";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 102;
            // 
            // Order_dtle
            // 
            Order_dtle.AutoSize = true;
            Order_dtle.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Order_dtle.Location = new Point(8, 0);
            Order_dtle.Name = "Order_dtle";
            Order_dtle.Size = new Size(99, 21);
            Order_dtle.TabIndex = 9;
            Order_dtle.Text = "Order Detail";
            // 
            // deleteBtn
            // 
            deleteBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            deleteBtn.BackColor = Color.Red;
            deleteBtn.FlatAppearance.BorderSize = 0;
            deleteBtn.FlatStyle = FlatStyle.Flat;
            deleteBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBtn.ForeColor = Color.White;
            deleteBtn.Image = (Image)resources.GetObject("deleteBtn.Image");
            deleteBtn.ImageAlign = ContentAlignment.MiddleLeft;
            deleteBtn.Location = new Point(487, 337);
            deleteBtn.Name = "deleteBtn";
            deleteBtn.Size = new Size(110, 36);
            deleteBtn.TabIndex = 14;
            deleteBtn.Text = "Delete";
            deleteBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            deleteBtn.UseVisualStyleBackColor = false;
            deleteBtn.Click += deleteBtn_Click;
            // 
            // addOrderBtn
            // 
            addOrderBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addOrderBtn.BackColor = Color.MediumSeaGreen;
            addOrderBtn.FlatAppearance.BorderSize = 0;
            addOrderBtn.FlatStyle = FlatStyle.Flat;
            addOrderBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addOrderBtn.ForeColor = Color.White;
            addOrderBtn.Image = (Image)resources.GetObject("addOrderBtn.Image");
            addOrderBtn.ImageAlign = ContentAlignment.MiddleLeft;
            addOrderBtn.Location = new Point(537, 447);
            addOrderBtn.Name = "addOrderBtn";
            addOrderBtn.Size = new Size(186, 40);
            addOrderBtn.TabIndex = 15;
            addOrderBtn.Text = "Add Order";
            addOrderBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            addOrderBtn.UseVisualStyleBackColor = false;
            addOrderBtn.Click += Add_order_Click;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(addItemBtn);
            panel3.Controls.Add(deleteBtn);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(selectCustomerBtn);
            panel3.Controls.Add(totalAmountTbox);
            panel3.Controls.Add(dataGridView_Order);
            panel3.Controls.Add(Order_dtle);
            panel3.Controls.Add(DR_No);
            panel3.Controls.Add(customerDetailsTbox);
            panel3.Controls.Add(deliveryReceiptTbox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(customerNameTbox);
            panel3.Controls.Add(purchaseOrderTbox);
            panel3.Controls.Add(label1);
            panel3.EdgeColor = Color.FromArgb(32, 41, 50);
            panel3.Location = new Point(8, 60);
            panel3.Name = "panel3";
            panel3.Padding = new Padding(5);
            panel3.Size = new Size(715, 381);
            panel3.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel3.TabIndex = 16;
            panel3.Text = "panel3";
            // 
            // Label_add
            // 
            Label_add.AutoSize = true;
            Label_add.BackColor = Color.Transparent;
            Label_add.Font = new Font("Segoe UI", 24.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_add.ForeColor = Color.White;
            Label_add.Location = new Point(3, 9);
            Label_add.Name = "Label_add";
            Label_add.Size = new Size(181, 45);
            Label_add.TabIndex = 0;
            Label_add.Text = "Add Order";
            // 
            // OrdersAddForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 37);
            Controls.Add(panel3);
            Controls.Add(addOrderBtn);
            Controls.Add(Label_add);
            Name = "OrdersAddForm";
            Size = new Size(732, 502);
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox customerNameTbox;
        private Label label1;
        private Label label2;
        private TextBox customerDetailsTbox;
        private Label label3;
        private TextBox purchaseOrderTbox;
        private Label DR_No;
        private TextBox deliveryReceiptTbox;
        private Label Order_dtle;
        private DataGridView dataGridView_Order;
        private Label label10;
        private TextBox totalAmountTbox;
        private Button addItemBtn;
        private Button deleteBtn;
        private Button addOrderBtn;
        private Button selectCustomerBtn;
        private ReaLTaiizor.Controls.Panel panel3;
        private ReaLTaiizor.Controls.BigLabel Label_add;
        private DataGridViewTextBoxColumn item_code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn color;
        private DataGridViewTextBoxColumn price;
    }
}