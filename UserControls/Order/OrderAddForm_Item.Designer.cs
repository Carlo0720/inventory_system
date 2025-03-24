namespace inventory_system.UserControls.Order
{
    partial class OrderAddForm_Item
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderAddForm_Item));
            products_searchbtn = new Button();
            panel3 = new Panel();
            products_searchTxtbox = new TextBox();
            products_add = new Button();
            productlist_datagd = new DataGridView();
            panel1 = new Panel();
            quantityTbox = new TextBox();
            panel2 = new Panel();
            lengthTbox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            product_id = new DataGridViewTextBoxColumn();
            item_code = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            item_description = new DataGridViewTextBoxColumn();
            item_color = new DataGridViewTextBoxColumn();
            item_category = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            item_price = new DataGridViewTextBoxColumn();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productlist_datagd).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // products_searchbtn
            // 
            products_searchbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_searchbtn.Image = (Image)resources.GetObject("products_searchbtn.Image");
            products_searchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            products_searchbtn.Location = new Point(1279, 8);
            products_searchbtn.Name = "products_searchbtn";
            products_searchbtn.Size = new Size(79, 40);
            products_searchbtn.TabIndex = 10;
            products_searchbtn.Text = "Search";
            products_searchbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_searchbtn.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(products_searchTxtbox);
            panel3.Location = new Point(1032, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 36);
            panel3.TabIndex = 11;
            // 
            // products_searchTxtbox
            // 
            products_searchTxtbox.BackColor = Color.White;
            products_searchTxtbox.BorderStyle = BorderStyle.None;
            products_searchTxtbox.Font = new Font("Segoe UI", 9F);
            products_searchTxtbox.Location = new Point(3, 9);
            products_searchTxtbox.Name = "products_searchTxtbox";
            products_searchTxtbox.Size = new Size(241, 16);
            products_searchTxtbox.TabIndex = 2;
            // 
            // products_add
            // 
            products_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_add.Image = (Image)resources.GetObject("products_add.Image");
            products_add.ImageAlign = ContentAlignment.MiddleLeft;
            products_add.Location = new Point(27, 6);
            products_add.Name = "products_add";
            products_add.Size = new Size(79, 40);
            products_add.TabIndex = 9;
            products_add.Text = "Add";
            products_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_add.UseVisualStyleBackColor = true;
            products_add.Click += products_add_Click;
            // 
            // productlist_datagd
            // 
            productlist_datagd.AllowDrop = true;
            productlist_datagd.AllowUserToAddRows = false;
            productlist_datagd.AllowUserToDeleteRows = false;
            productlist_datagd.AllowUserToResizeColumns = false;
            productlist_datagd.AllowUserToResizeRows = false;
            productlist_datagd.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productlist_datagd.BackgroundColor = Color.FromArgb(224, 224, 224);
            productlist_datagd.BorderStyle = BorderStyle.None;
            productlist_datagd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productlist_datagd.Columns.AddRange(new DataGridViewColumn[] { product_id, item_code, item_name, item_description, item_color, item_category, supplier, stock, unit, item_price });
            productlist_datagd.Location = new Point(3, 52);
            productlist_datagd.MultiSelect = false;
            productlist_datagd.Name = "productlist_datagd";
            productlist_datagd.ReadOnly = true;
            productlist_datagd.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productlist_datagd.Size = new Size(1365, 564);
            productlist_datagd.TabIndex = 8;
            productlist_datagd.CellDoubleClick += productlist_datagd_CellDoubleClick_1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(quantityTbox);
            panel1.Location = new Point(222, 10);
            panel1.Name = "panel1";
            panel1.Size = new Size(158, 36);
            panel1.TabIndex = 12;
            // 
            // quantityTbox
            // 
            quantityTbox.BackColor = Color.White;
            quantityTbox.BorderStyle = BorderStyle.None;
            quantityTbox.Font = new Font("Segoe UI", 9F);
            quantityTbox.Location = new Point(3, 9);
            quantityTbox.Name = "quantityTbox";
            quantityTbox.Size = new Size(152, 16);
            quantityTbox.TabIndex = 2;
            quantityTbox.Text = "1";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(lengthTbox);
            panel2.Location = new Point(492, 10);
            panel2.Name = "panel2";
            panel2.Size = new Size(158, 36);
            panel2.TabIndex = 13;
            // 
            // lengthTbox
            // 
            lengthTbox.BackColor = Color.White;
            lengthTbox.BorderStyle = BorderStyle.None;
            lengthTbox.Font = new Font("Segoe UI", 9F);
            lengthTbox.Location = new Point(3, 9);
            lengthTbox.Name = "lengthTbox";
            lengthTbox.Size = new Size(152, 16);
            lengthTbox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(166, 21);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 14;
            label1.Text = "Quantity";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 21);
            label2.Name = "label2";
            label2.Size = new Size(44, 15);
            label2.TabIndex = 15;
            label2.Text = "Length";
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Width = 88;
            // 
            // item_code
            // 
            item_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_code.HeaderText = "Item Code";
            item_code.Name = "item_code";
            item_code.ReadOnly = true;
            // 
            // item_name
            // 
            item_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            // 
            // item_description
            // 
            item_description.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_description.HeaderText = "Item Description";
            item_description.Name = "item_description";
            item_description.ReadOnly = true;
            // 
            // item_color
            // 
            item_color.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_color.HeaderText = "Item Color";
            item_color.Name = "item_color";
            item_color.ReadOnly = true;
            // 
            // item_category
            // 
            item_category.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_category.HeaderText = "Item Category";
            item_category.Name = "item_category";
            item_category.ReadOnly = true;
            // 
            // supplier
            // 
            supplier.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            supplier.HeaderText = "Supplier";
            supplier.Name = "supplier";
            supplier.ReadOnly = true;
            // 
            // stock
            // 
            stock.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            stock.HeaderText = "Stock";
            stock.Name = "stock";
            stock.ReadOnly = true;
            // 
            // unit
            // 
            unit.HeaderText = "Unit";
            unit.Name = "unit";
            unit.ReadOnly = true;
            // 
            // item_price
            // 
            item_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_price.HeaderText = "Item Price";
            item_price.Name = "item_price";
            item_price.ReadOnly = true;
            // 
            // OrderAddForm_Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(products_searchbtn);
            Controls.Add(panel3);
            Controls.Add(products_add);
            Controls.Add(productlist_datagd);
            Name = "OrderAddForm_Item";
            Size = new Size(1371, 619);
            Load += OrderAddForm_Item_Load;
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productlist_datagd).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button products_searchbtn;
        private Panel panel3;
        private TextBox products_searchTxtbox;
        private Button products_add;
        private DataGridView productlist_datagd;
        private Panel panel1;
        private TextBox quantityTbox;
        private Panel panel2;
        private TextBox lengthTbox;
        private Label label1;
        private Label label2;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn item_code;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_description;
        private DataGridViewTextBoxColumn item_color;
        private DataGridViewTextBoxColumn item_category;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn item_price;
    }
}
