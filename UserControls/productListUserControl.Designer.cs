﻿namespace inventory_system
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(productListUserControl));
            productlist_datagd = new DataGridView();
            product_id = new DataGridViewTextBoxColumn();
            item_name = new DataGridViewTextBoxColumn();
            item_code = new DataGridViewTextBoxColumn();
            item_description = new DataGridViewTextBoxColumn();
            item_color = new DataGridViewTextBoxColumn();
            item_category = new DataGridViewTextBoxColumn();
            supplier = new DataGridViewTextBoxColumn();
            stock = new DataGridViewTextBoxColumn();
            unit = new DataGridViewTextBoxColumn();
            item_price = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            products_add = new Button();
            products_searchbtn = new Button();
            panel3 = new Panel();
            products_searchTxtbox = new TextBox();
            products_add_pnl = new Panel();
            ((System.ComponentModel.ISupportInitialize)productlist_datagd).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
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
            productlist_datagd.Columns.AddRange(new DataGridViewColumn[] { product_id, item_name, item_code, item_description, item_color, item_category, supplier, stock, unit, item_price, created_at });
            productlist_datagd.Location = new Point(0, 54);
            productlist_datagd.Name = "productlist_datagd";
            productlist_datagd.ReadOnly = true;
            productlist_datagd.Size = new Size(1073, 564);
            productlist_datagd.TabIndex = 0;
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Width = 81;
            // 
            // item_name
            // 
            item_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_name.HeaderText = "Item Name";
            item_name.Name = "item_name";
            item_name.ReadOnly = true;
            // 
            // item_code
            // 
            item_code.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            item_code.HeaderText = "Item Code";
            item_code.Name = "item_code";
            item_code.ReadOnly = true;
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
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            created_at.HeaderText = "Creation Date";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            created_at.Width = 96;
            // 
            // products_add
            // 
            products_add.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_add.Image = (Image)resources.GetObject("products_add.Image");
            products_add.ImageAlign = ContentAlignment.MiddleLeft;
            products_add.Location = new Point(13, 8);
            products_add.Name = "products_add";
            products_add.Size = new Size(79, 40);
            products_add.TabIndex = 1;
            products_add.Text = "Add";
            products_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_add.UseVisualStyleBackColor = true;
            products_add.Click += products_add_Click;
            // 
            // products_searchbtn
            // 
            products_searchbtn.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_searchbtn.Image = (Image)resources.GetObject("products_searchbtn.Image");
            products_searchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            products_searchbtn.Location = new Point(534, 8);
            products_searchbtn.Name = "products_searchbtn";
            products_searchbtn.Size = new Size(79, 40);
            products_searchbtn.TabIndex = 5;
            products_searchbtn.Text = "Search";
            products_searchbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_searchbtn.UseVisualStyleBackColor = true;
            products_searchbtn.Click += products_searchbtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.White;
            panel3.Controls.Add(products_searchTxtbox);
            panel3.Location = new Point(287, 10);
            panel3.Name = "panel3";
            panel3.Size = new Size(326, 36);
            panel3.TabIndex = 6;
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
            // products_add_pnl
            // 
            products_add_pnl.Anchor = AnchorStyles.None;
            products_add_pnl.Location = new Point(415, 8);
            products_add_pnl.Name = "products_add_pnl";
            products_add_pnl.Size = new Size(261, 590);
            products_add_pnl.TabIndex = 7;
            // 
            // productListUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(products_add_pnl);
            Controls.Add(products_searchbtn);
            Controls.Add(panel3);
            Controls.Add(products_add);
            Controls.Add(productlist_datagd);
            Name = "productListUserControl";
            Size = new Size(1074, 621);
            Load += productListUserControl_Load;
            ((System.ComponentModel.ISupportInitialize)productlist_datagd).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView productlist_datagd;
        private Button products_add;
        private Button products_searchbtn;
        private Panel panel3;
        private TextBox products_searchTxtbox;
        private Panel products_add_pnl;
        private DataGridViewTextBoxColumn product_id;
        private DataGridViewTextBoxColumn item_name;
        private DataGridViewTextBoxColumn item_code;
        private DataGridViewTextBoxColumn item_description;
        private DataGridViewTextBoxColumn item_color;
        private DataGridViewTextBoxColumn item_category;
        private DataGridViewTextBoxColumn supplier;
        private DataGridViewTextBoxColumn stock;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn item_price;
        private DataGridViewTextBoxColumn created_at;
    }
}