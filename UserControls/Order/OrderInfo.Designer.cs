namespace inventory_system.UserControls.Order
{
    partial class OrderInfo
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
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle16 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle17 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle18 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
            puchaseOrderLbl = new ReaLTaiizor.Controls.BigLabel();
            deliveryReceiptLbl = new ReaLTaiizor.Controls.BigLabel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            printReceiptBtn = new ReaLTaiizor.Controls.Button();
            orderItemsDatagridview = new DataGridView();
            item_code = new DataGridViewTextBoxColumn();
            description = new DataGridViewTextBoxColumn();
            product_id = new DataGridViewTextBoxColumn();
            quantity = new DataGridViewTextBoxColumn();
            price = new DataGridViewTextBoxColumn();
            nameLbl = new ReaLTaiizor.Controls.BigLabel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)orderItemsDatagridview).BeginInit();
            SuspendLayout();
            // 
            // puchaseOrderLbl
            // 
            puchaseOrderLbl.AutoSize = true;
            puchaseOrderLbl.BackColor = Color.Transparent;
            puchaseOrderLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            puchaseOrderLbl.ForeColor = Color.FromArgb(80, 80, 80);
            puchaseOrderLbl.Location = new Point(3, 32);
            puchaseOrderLbl.Name = "puchaseOrderLbl";
            puchaseOrderLbl.Size = new Size(177, 32);
            puchaseOrderLbl.TabIndex = 0;
            puchaseOrderLbl.Text = "Purchase Order";
            // 
            // deliveryReceiptLbl
            // 
            deliveryReceiptLbl.AutoSize = true;
            deliveryReceiptLbl.BackColor = Color.Transparent;
            deliveryReceiptLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deliveryReceiptLbl.ForeColor = Color.FromArgb(80, 80, 80);
            deliveryReceiptLbl.Location = new Point(3, 0);
            deliveryReceiptLbl.Name = "deliveryReceiptLbl";
            deliveryReceiptLbl.Size = new Size(186, 32);
            deliveryReceiptLbl.TabIndex = 1;
            deliveryReceiptLbl.Text = "Delivery Receipt";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(printReceiptBtn);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(3, 487);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(441, 65);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 6;
            panel1.Text = "panel1";
            // 
            // printReceiptBtn
            // 
            printReceiptBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            printReceiptBtn.BackColor = Color.Transparent;
            printReceiptBtn.BorderColor = Color.FromArgb(32, 34, 37);
            printReceiptBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            printReceiptBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            printReceiptBtn.Font = new Font("Microsoft Sans Serif", 12F);
            printReceiptBtn.Image = null;
            printReceiptBtn.ImageAlign = ContentAlignment.MiddleLeft;
            printReceiptBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            printReceiptBtn.Location = new Point(171, 17);
            printReceiptBtn.Name = "printReceiptBtn";
            printReceiptBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            printReceiptBtn.PressedColor = Color.FromArgb(165, 37, 37);
            printReceiptBtn.Size = new Size(120, 40);
            printReceiptBtn.TabIndex = 6;
            printReceiptBtn.Text = "PRINT";
            printReceiptBtn.TextAlignment = StringAlignment.Center;
            // 
            // orderItemsDatagridview
            // 
            orderItemsDatagridview.AccessibleRole = AccessibleRole.None;
            orderItemsDatagridview.AllowUserToAddRows = false;
            orderItemsDatagridview.AllowUserToResizeColumns = false;
            orderItemsDatagridview.AllowUserToResizeRows = false;
            dataGridViewCellStyle10.ForeColor = Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle10.SelectionForeColor = Color.White;
            orderItemsDatagridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            orderItemsDatagridview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsDatagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            orderItemsDatagridview.BackgroundColor = Color.White;
            orderItemsDatagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = Color.DimGray;
            dataGridViewCellStyle11.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.White;
            dataGridViewCellStyle11.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle11.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.True;
            orderItemsDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            orderItemsDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            orderItemsDatagridview.Columns.AddRange(new DataGridViewColumn[] { item_code, description, product_id, quantity, price });
            dataGridViewCellStyle16.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = Color.Silver;
            dataGridViewCellStyle16.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle16.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle16.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle16.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = DataGridViewTriState.False;
            orderItemsDatagridview.DefaultCellStyle = dataGridViewCellStyle16;
            orderItemsDatagridview.GridColor = Color.Silver;
            orderItemsDatagridview.Location = new Point(3, 95);
            orderItemsDatagridview.MultiSelect = false;
            orderItemsDatagridview.Name = "orderItemsDatagridview";
            orderItemsDatagridview.ReadOnly = true;
            orderItemsDatagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle17.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = Color.LightSlateGray;
            dataGridViewCellStyle17.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle17.ForeColor = Color.White;
            dataGridViewCellStyle17.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle17.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = DataGridViewTriState.True;
            orderItemsDatagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            orderItemsDatagridview.RowHeadersVisible = false;
            orderItemsDatagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle18.BackColor = Color.LightGray;
            dataGridViewCellStyle18.ForeColor = Color.White;
            dataGridViewCellStyle18.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle18.SelectionForeColor = Color.White;
            orderItemsDatagridview.RowsDefaultCellStyle = dataGridViewCellStyle18;
            orderItemsDatagridview.RowTemplate.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            orderItemsDatagridview.RowTemplate.DefaultCellStyle.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            orderItemsDatagridview.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            orderItemsDatagridview.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.LightSteelBlue;
            orderItemsDatagridview.RowTemplate.DividerHeight = 1;
            orderItemsDatagridview.RowTemplate.Height = 35;
            orderItemsDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderItemsDatagridview.ShowEditingIcon = false;
            orderItemsDatagridview.ShowRowErrors = false;
            orderItemsDatagridview.Size = new Size(441, 386);
            orderItemsDatagridview.TabIndex = 13;
            // 
            // item_code
            // 
            item_code.HeaderText = "Item Code";
            item_code.Name = "item_code";
            item_code.ReadOnly = true;
            item_code.Width = 92;
            // 
            // description
            // 
            description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle12.BackColor = Color.Silver;
            dataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            description.DefaultCellStyle = dataGridViewCellStyle12;
            description.HeaderText = "Item Description";
            description.Name = "description";
            description.ReadOnly = true;
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle13.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle13.SelectionForeColor = Color.Black;
            product_id.DefaultCellStyle = dataGridViewCellStyle13;
            product_id.HeaderText = "product_id";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Width = 102;
            // 
            // quantity
            // 
            quantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle14.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle14.SelectionForeColor = Color.Black;
            quantity.DefaultCellStyle = dataGridViewCellStyle14;
            quantity.HeaderText = "Quantity";
            quantity.Name = "quantity";
            quantity.ReadOnly = true;
            quantity.Width = 89;
            // 
            // price
            // 
            price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle15.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle15.SelectionForeColor = Color.Black;
            price.DefaultCellStyle = dataGridViewCellStyle15;
            price.HeaderText = "Selling Price";
            price.Name = "price";
            price.ReadOnly = true;
            price.Width = 102;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.BackColor = Color.Transparent;
            nameLbl.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameLbl.ForeColor = Color.FromArgb(80, 80, 80);
            nameLbl.Location = new Point(3, 64);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(188, 32);
            nameLbl.TabIndex = 14;
            nameLbl.Text = "Customer Name";
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(nameLbl);
            Controls.Add(orderItemsDatagridview);
            Controls.Add(panel1);
            Controls.Add(deliveryReceiptLbl);
            Controls.Add(puchaseOrderLbl);
            Name = "OrderInfo";
            Size = new Size(447, 555);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)orderItemsDatagridview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel puchaseOrderLbl;
        private ReaLTaiizor.Controls.BigLabel deliveryReceiptLbl;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallLabel totalQuantityLbl;
        private ReaLTaiizor.Controls.SmallLabel totalPriceLbl;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button excelBtn;
        private ReaLTaiizor.Controls.Button pdfBtn;
        private ReaLTaiizor.Controls.Button printReceiptBtn;
        private DataGridView orderItemsDatagridview;
        private DataGridViewTextBoxColumn item_code;
        private DataGridViewTextBoxColumn description;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn quantity;
        private DataGridViewTextBoxColumn price;
        private ReaLTaiizor.Controls.BigLabel nameLbl;
    }
}
