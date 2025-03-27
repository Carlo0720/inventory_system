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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            puchaseOrderLbl = new ReaLTaiizor.Controls.BigLabel();
            deliveryReceiptLbl = new ReaLTaiizor.Controls.BigLabel();
            orderItemsDatagridview = new ReaLTaiizor.Controls.PoisonDataGridView();
            smallLabel1 = new ReaLTaiizor.Controls.SmallLabel();
            totalQuantityLbl = new ReaLTaiizor.Controls.SmallLabel();
            totalPriceLbl = new ReaLTaiizor.Controls.SmallLabel();
            panel1 = new ReaLTaiizor.Controls.Panel();
            excelBtn = new ReaLTaiizor.Controls.Button();
            pdfBtn = new ReaLTaiizor.Controls.Button();
            wordBtn = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)orderItemsDatagridview).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // puchaseOrderLbl
            // 
            puchaseOrderLbl.AutoSize = true;
            puchaseOrderLbl.BackColor = Color.Transparent;
            puchaseOrderLbl.Font = new Font("Segoe UI", 25F);
            puchaseOrderLbl.ForeColor = Color.FromArgb(80, 80, 80);
            puchaseOrderLbl.Location = new Point(3, 46);
            puchaseOrderLbl.Name = "puchaseOrderLbl";
            puchaseOrderLbl.Size = new Size(251, 46);
            puchaseOrderLbl.TabIndex = 0;
            puchaseOrderLbl.Text = "Purchase Order";
            // 
            // deliveryReceiptLbl
            // 
            deliveryReceiptLbl.AutoSize = true;
            deliveryReceiptLbl.BackColor = Color.Transparent;
            deliveryReceiptLbl.Font = new Font("Segoe UI", 25F);
            deliveryReceiptLbl.ForeColor = Color.FromArgb(80, 80, 80);
            deliveryReceiptLbl.Location = new Point(3, 0);
            deliveryReceiptLbl.Name = "deliveryReceiptLbl";
            deliveryReceiptLbl.Size = new Size(260, 46);
            deliveryReceiptLbl.TabIndex = 1;
            deliveryReceiptLbl.Text = "Delivery Receipt";
            // 
            // orderItemsDatagridview
            // 
            orderItemsDatagridview.AllowUserToResizeRows = false;
            orderItemsDatagridview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            orderItemsDatagridview.BackgroundColor = Color.FromArgb(255, 255, 255);
            orderItemsDatagridview.BorderStyle = BorderStyle.None;
            orderItemsDatagridview.CellBorderStyle = DataGridViewCellBorderStyle.None;
            orderItemsDatagridview.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            orderItemsDatagridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            orderItemsDatagridview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            orderItemsDatagridview.DefaultCellStyle = dataGridViewCellStyle5;
            orderItemsDatagridview.EnableHeadersVisualStyles = false;
            orderItemsDatagridview.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            orderItemsDatagridview.GridColor = Color.FromArgb(255, 255, 255);
            orderItemsDatagridview.Location = new Point(3, 95);
            orderItemsDatagridview.Name = "orderItemsDatagridview";
            orderItemsDatagridview.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(0, 174, 219);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle6.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(0, 198, 247);
            dataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            orderItemsDatagridview.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            orderItemsDatagridview.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            orderItemsDatagridview.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            orderItemsDatagridview.Size = new Size(441, 279);
            orderItemsDatagridview.TabIndex = 2;
            // 
            // smallLabel1
            // 
            smallLabel1.AutoSize = true;
            smallLabel1.BackColor = Color.Transparent;
            smallLabel1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            smallLabel1.ForeColor = Color.White;
            smallLabel1.Location = new Point(18, 5);
            smallLabel1.Name = "smallLabel1";
            smallLabel1.Size = new Size(42, 21);
            smallLabel1.TabIndex = 3;
            smallLabel1.Text = "Total";
            // 
            // totalQuantityLbl
            // 
            totalQuantityLbl.AutoSize = true;
            totalQuantityLbl.BackColor = Color.Transparent;
            totalQuantityLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalQuantityLbl.ForeColor = Color.White;
            totalQuantityLbl.Location = new Point(165, 5);
            totalQuantityLbl.Name = "totalQuantityLbl";
            totalQuantityLbl.Size = new Size(106, 21);
            totalQuantityLbl.TabIndex = 4;
            totalQuantityLbl.Text = "Quantity Total";
            // 
            // totalPriceLbl
            // 
            totalPriceLbl.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            totalPriceLbl.AutoSize = true;
            totalPriceLbl.BackColor = Color.Transparent;
            totalPriceLbl.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalPriceLbl.ForeColor = Color.White;
            totalPriceLbl.Location = new Point(313, 5);
            totalPriceLbl.Name = "totalPriceLbl";
            totalPriceLbl.Size = new Size(80, 21);
            totalPriceLbl.TabIndex = 5;
            totalPriceLbl.Text = "Total Price";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel1.BackColor = Color.FromArgb(39, 51, 63);
            panel1.Controls.Add(excelBtn);
            panel1.Controls.Add(pdfBtn);
            panel1.Controls.Add(wordBtn);
            panel1.Controls.Add(totalPriceLbl);
            panel1.Controls.Add(smallLabel1);
            panel1.Controls.Add(totalQuantityLbl);
            panel1.EdgeColor = Color.FromArgb(32, 41, 50);
            panel1.Location = new Point(3, 380);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(5);
            panel1.Size = new Size(441, 172);
            panel1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            panel1.TabIndex = 6;
            panel1.Text = "panel1";
            // 
            // excelBtn
            // 
            excelBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            excelBtn.BackColor = Color.Transparent;
            excelBtn.BorderColor = Color.FromArgb(32, 34, 37);
            excelBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            excelBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            excelBtn.Font = new Font("Microsoft Sans Serif", 12F);
            excelBtn.Image = null;
            excelBtn.ImageAlign = ContentAlignment.MiddleLeft;
            excelBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            excelBtn.Location = new Point(313, 86);
            excelBtn.Name = "excelBtn";
            excelBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            excelBtn.PressedColor = Color.FromArgb(165, 37, 37);
            excelBtn.Size = new Size(120, 40);
            excelBtn.TabIndex = 8;
            excelBtn.Text = "button3";
            excelBtn.TextAlignment = StringAlignment.Center;
            // 
            // pdfBtn
            // 
            pdfBtn.Anchor = AnchorStyles.Bottom;
            pdfBtn.BackColor = Color.Transparent;
            pdfBtn.BorderColor = Color.FromArgb(32, 34, 37);
            pdfBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            pdfBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            pdfBtn.Font = new Font("Microsoft Sans Serif", 12F);
            pdfBtn.Image = null;
            pdfBtn.ImageAlign = ContentAlignment.MiddleLeft;
            pdfBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            pdfBtn.Location = new Point(165, 86);
            pdfBtn.Name = "pdfBtn";
            pdfBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            pdfBtn.PressedColor = Color.FromArgb(165, 37, 37);
            pdfBtn.Size = new Size(120, 40);
            pdfBtn.TabIndex = 7;
            pdfBtn.Text = "button2";
            pdfBtn.TextAlignment = StringAlignment.Center;
            // 
            // wordBtn
            // 
            wordBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            wordBtn.BackColor = Color.Transparent;
            wordBtn.BorderColor = Color.FromArgb(32, 34, 37);
            wordBtn.EnteredBorderColor = Color.FromArgb(165, 37, 37);
            wordBtn.EnteredColor = Color.FromArgb(32, 34, 37);
            wordBtn.Font = new Font("Microsoft Sans Serif", 12F);
            wordBtn.Image = null;
            wordBtn.ImageAlign = ContentAlignment.MiddleLeft;
            wordBtn.InactiveColor = Color.FromArgb(32, 34, 37);
            wordBtn.Location = new Point(18, 86);
            wordBtn.Name = "wordBtn";
            wordBtn.PressedBorderColor = Color.FromArgb(165, 37, 37);
            wordBtn.PressedColor = Color.FromArgb(165, 37, 37);
            wordBtn.Size = new Size(120, 40);
            wordBtn.TabIndex = 6;
            wordBtn.Text = "button1";
            wordBtn.TextAlignment = StringAlignment.Center;
            // 
            // OrderInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(orderItemsDatagridview);
            Controls.Add(deliveryReceiptLbl);
            Controls.Add(puchaseOrderLbl);
            Name = "OrderInfo";
            Size = new Size(447, 555);
            ((System.ComponentModel.ISupportInitialize)orderItemsDatagridview).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel puchaseOrderLbl;
        private ReaLTaiizor.Controls.BigLabel deliveryReceiptLbl;
        private ReaLTaiizor.Controls.PoisonDataGridView orderItemsDatagridview;
        private ReaLTaiizor.Controls.SmallLabel smallLabel1;
        private ReaLTaiizor.Controls.SmallLabel totalQuantityLbl;
        private ReaLTaiizor.Controls.SmallLabel totalPriceLbl;
        private ReaLTaiizor.Controls.Panel panel1;
        private ReaLTaiizor.Controls.Button excelBtn;
        private ReaLTaiizor.Controls.Button pdfBtn;
        private ReaLTaiizor.Controls.Button wordBtn;
    }
}
