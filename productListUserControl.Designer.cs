namespace inventory_system
{
    partial class productListUserControl
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
            productsDataGrid = new DataGridView();
            id = new DataGridViewTextBoxColumn();
            itemCode = new DataGridViewTextBoxColumn();
            itemDescription = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            itemColor = new DataGridViewTextBoxColumn();
            itemCategory = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            itemPrice = new DataGridViewTextBoxColumn();
            creationDate = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // productsDataGrid
            // 
            productsDataGrid.Anchor = AnchorStyles.None;
            productsDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsDataGrid.Columns.AddRange(new DataGridViewColumn[] { id, itemCode, itemDescription, supplier, itemColor, itemCategory, stock, itemPrice, creationDate });
            productsDataGrid.Location = new Point(-1, 63);
            productsDataGrid.Name = "productsDataGrid";
            productsDataGrid.Size = new Size(956, 559);
            productsDataGrid.TabIndex = 0;
            // 
            // id
            // 
            id.HeaderText = "ID";
            id.Name = "id";
            id.ReadOnly = true;
            // 
            // itemCode
            // 
            itemCode.HeaderText = "Item code";
            itemCode.Name = "itemCode";
            itemCode.ReadOnly = true;
            // 
            // itemDescription
            // 
            itemDescription.HeaderText = "Item Description";
            itemDescription.Name = "itemDescription";
            itemDescription.ReadOnly = true;
            // 
            // supplier
            // 
            supplier.HeaderText = "Supplier";
            supplier.Name = "supplier";
            // 
            // itemColor
            // 
            itemColor.HeaderText = "Item Color";
            itemColor.Name = "itemColor";
            // 
            // itemCategory
            // 
            itemCategory.HeaderText = "Item Category";
            itemCategory.Name = "itemCategory";
            // 
            // stock
            // 
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            // 
            // itemPrice
            // 
            itemPrice.HeaderText = "Item Price";
            itemPrice.Name = "itemPrice";
            // 
            // creationDate
            // 
            creationDate.HeaderText = "Creation Date";
            creationDate.Name = "creationDate";
            // 
            // productListUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(productsDataGrid);
            Name = "productListUserControl";
            Size = new Size(955, 621);
            Load += productListUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)productsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productsDataGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn itemCode;
        private DataGridViewTextBoxColumn itemDescription;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn itemColor;
        private DataGridViewTextBoxColumn itemCategory;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn itemPrice;
        private DataGridViewTextBoxColumn creationDate;
    }
}