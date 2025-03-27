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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
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
            cost_price = new DataGridViewTextBoxColumn();
            created_at = new DataGridViewTextBoxColumn();
            products_add = new Button();
            products_searchbtn = new Button();
            panel3 = new Panel();
            products_searchTxtbox = new TextBox();
            products_add_pnl = new Panel();
            label_Acc_Title = new Label();
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
            productlist_datagd.BackgroundColor = Color.WhiteSmoke;
            productlist_datagd.BorderStyle = BorderStyle.None;
            productlist_datagd.CellBorderStyle = DataGridViewCellBorderStyle.None;
            productlist_datagd.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.DimGray;
            dataGridViewCellStyle1.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productlist_datagd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productlist_datagd.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productlist_datagd.Columns.AddRange(new DataGridViewColumn[] { product_id, item_name, item_code, item_description, item_color, item_category, supplier, stock, unit, item_price, cost_price, created_at });
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.InfoText;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productlist_datagd.DefaultCellStyle = dataGridViewCellStyle2;
            productlist_datagd.GridColor = Color.Black;
            productlist_datagd.Location = new Point(0, 54);
            productlist_datagd.Name = "productlist_datagd";
            productlist_datagd.ReadOnly = true;
            productlist_datagd.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = Color.Black;
            dataGridViewCellStyle3.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.Window;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            productlist_datagd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            productlist_datagd.RowHeadersVisible = false;
            dataGridViewCellStyle4.BackColor = Color.Black;
            dataGridViewCellStyle4.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = Color.SteelBlue;
            dataGridViewCellStyle4.SelectionBackColor = Color.AliceBlue;
            dataGridViewCellStyle4.SelectionForeColor = Color.SteelBlue;
            productlist_datagd.RowsDefaultCellStyle = dataGridViewCellStyle4;
            productlist_datagd.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productlist_datagd.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            productlist_datagd.RowTemplate.DefaultCellStyle.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productlist_datagd.RowTemplate.DefaultCellStyle.ForeColor = Color.Black;
            productlist_datagd.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            productlist_datagd.RowTemplate.DefaultCellStyle.SelectionForeColor = Color.SteelBlue;
            productlist_datagd.RowTemplate.DividerHeight = 1;
            productlist_datagd.RowTemplate.Height = 35;
            productlist_datagd.SelectionMode = DataGridViewSelectionMode.CellSelect;
            productlist_datagd.Size = new Size(1074, 567);
            productlist_datagd.TabIndex = 0;
            productlist_datagd.CellContentClick += productlist_datagd_CellContentClick_1;
            // 
            // product_id
            // 
            product_id.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            product_id.HeaderText = "Product ID";
            product_id.Name = "product_id";
            product_id.ReadOnly = true;
            product_id.Width = 90;
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
            // cost_price
            // 
            cost_price.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            cost_price.HeaderText = "Cost Price";
            cost_price.Name = "cost_price";
            cost_price.ReadOnly = true;
            cost_price.Width = 88;
            // 
            // created_at
            // 
            created_at.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            created_at.HeaderText = "Creation Date";
            created_at.Name = "created_at";
            created_at.ReadOnly = true;
            created_at.Width = 109;
            // 
            // products_add
            // 
            products_add.BackColor = Color.MediumSeaGreen;
            products_add.FlatAppearance.BorderSize = 0;
            products_add.FlatStyle = FlatStyle.Flat;
            products_add.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_add.ForeColor = Color.White;
            products_add.Image = (Image)resources.GetObject("products_add.Image");
            products_add.ImageAlign = ContentAlignment.MiddleLeft;
            products_add.Location = new Point(156, 12);
            products_add.Name = "products_add";
            products_add.Size = new Size(95, 36);
            products_add.TabIndex = 1;
            products_add.Text = "Add";
            products_add.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_add.UseVisualStyleBackColor = false;
            products_add.Click += products_add_Click;
            // 
            // products_searchbtn
            // 
            products_searchbtn.BackColor = Color.DodgerBlue;
            products_searchbtn.FlatAppearance.BorderSize = 0;
            products_searchbtn.FlatStyle = FlatStyle.Flat;
            products_searchbtn.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_searchbtn.ForeColor = Color.White;
            products_searchbtn.Image = (Image)resources.GetObject("products_searchbtn.Image");
            products_searchbtn.ImageAlign = ContentAlignment.MiddleLeft;
            products_searchbtn.Location = new Point(509, 13);
            products_searchbtn.Name = "products_searchbtn";
            products_searchbtn.Size = new Size(127, 34);
            products_searchbtn.TabIndex = 5;
            products_searchbtn.Text = "Search";
            products_searchbtn.TextImageRelation = TextImageRelation.ImageBeforeText;
            products_searchbtn.UseVisualStyleBackColor = false;
            products_searchbtn.Click += products_searchbtn_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(products_searchTxtbox);
            panel3.Location = new Point(257, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(379, 36);
            panel3.TabIndex = 6;
            // 
            // products_searchTxtbox
            // 
            products_searchTxtbox.BackColor = Color.White;
            products_searchTxtbox.BorderStyle = BorderStyle.None;
            products_searchTxtbox.Font = new Font("Verdana", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            products_searchTxtbox.Location = new Point(7, 7);
            products_searchTxtbox.Name = "products_searchTxtbox";
            products_searchTxtbox.Size = new Size(241, 24);
            products_searchTxtbox.TabIndex = 2;
            // 
            // products_add_pnl
            // 
            products_add_pnl.Anchor = AnchorStyles.None;
            products_add_pnl.Location = new Point(405, 8);
            products_add_pnl.Name = "products_add_pnl";
            products_add_pnl.Size = new Size(261, 590);
            products_add_pnl.TabIndex = 7;
            // 
            // label_Acc_Title
            // 
            label_Acc_Title.AutoSize = true;
            label_Acc_Title.Font = new Font("Verdana", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label_Acc_Title.ForeColor = Color.Black;
            label_Acc_Title.Location = new Point(3, 13);
            label_Acc_Title.Name = "label_Acc_Title";
            label_Acc_Title.Size = new Size(147, 25);
            label_Acc_Title.TabIndex = 8;
            label_Acc_Title.Text = "Accessories";
            // 
            // productListUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label_Acc_Title);
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
            PerformLayout();
        }

        #endregion

        private DataGridView productlist_datagd;
        private Button products_add;
        private Button products_searchbtn;
        private Panel panel3;
        private TextBox products_searchTxtbox;
        private Panel products_add_pnl;
        private Label label_Acc_Title;
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
        private DataGridViewTextBoxColumn cost_price;
        private DataGridViewTextBoxColumn created_at;
    }
}