namespace inventory_system.UserControls.SubUserControls
{
    partial class editCustomerUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editCustomerUserControl));
            edit_costumer_btn = new Button();
            Label_add = new ReaLTaiizor.Controls.BigLabel();
            add_customers_close_btn = new Button();
            panel2 = new Panel();
            edit_email_txtbox = new TextBox();
            itemcolor_txtbox = new Label();
            supplier_txtbox = new Label();
            edit_address_txtbox = new TextBox();
            Order_dtle = new Label();
            label4 = new Label();
            itemcategory_txtbox = new Label();
            edit_firstname_txtbox = new TextBox();
            edit_phonenumber_txtbox = new TextBox();
            edit_lastname_txtbox = new TextBox();
            label6 = new Label();
            lastnamelbl = new Label();
            edit_companyname_txtbox = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // edit_costumer_btn
            // 
            edit_costumer_btn.BackColor = Color.MediumSeaGreen;
            edit_costumer_btn.FlatAppearance.BorderSize = 0;
            edit_costumer_btn.FlatStyle = FlatStyle.Flat;
            edit_costumer_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_costumer_btn.ForeColor = Color.White;
            edit_costumer_btn.Image = (Image)resources.GetObject("edit_costumer_btn.Image");
            edit_costumer_btn.ImageAlign = ContentAlignment.MiddleLeft;
            edit_costumer_btn.Location = new Point(27, 369);
            edit_costumer_btn.Name = "edit_costumer_btn";
            edit_costumer_btn.Size = new Size(209, 33);
            edit_costumer_btn.TabIndex = 28;
            edit_costumer_btn.Text = " Update Customer";
            edit_costumer_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            edit_costumer_btn.UseVisualStyleBackColor = false;
            edit_costumer_btn.Click += edit_costumer_btn_Click;
            // 
            // Label_add
            // 
            Label_add.Anchor = AnchorStyles.None;
            Label_add.AutoSize = true;
            Label_add.BackColor = Color.Transparent;
            Label_add.FlatStyle = FlatStyle.Flat;
            Label_add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_add.ForeColor = Color.White;
            Label_add.Location = new Point(25, 25);
            Label_add.Name = "Label_add";
            Label_add.Size = new Size(213, 32);
            Label_add.TabIndex = 26;
            Label_add.Text = "Update Customer";
            // 
            // add_customers_close_btn
            // 
            add_customers_close_btn.BackColor = Color.Red;
            add_customers_close_btn.BackgroundImage = (Image)resources.GetObject("add_customers_close_btn.BackgroundImage");
            add_customers_close_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_customers_close_btn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            add_customers_close_btn.FlatAppearance.BorderSize = 0;
            add_customers_close_btn.FlatStyle = FlatStyle.Flat;
            add_customers_close_btn.Location = new Point(238, 2);
            add_customers_close_btn.Name = "add_customers_close_btn";
            add_customers_close_btn.Size = new Size(21, 22);
            add_customers_close_btn.TabIndex = 29;
            add_customers_close_btn.UseVisualStyleBackColor = false;
            add_customers_close_btn.Click += add_customers_close_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(edit_email_txtbox);
            panel2.Controls.Add(itemcolor_txtbox);
            panel2.Controls.Add(supplier_txtbox);
            panel2.Controls.Add(edit_address_txtbox);
            panel2.Controls.Add(Order_dtle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(itemcategory_txtbox);
            panel2.Controls.Add(edit_firstname_txtbox);
            panel2.Controls.Add(edit_phonenumber_txtbox);
            panel2.Controls.Add(edit_lastname_txtbox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lastnamelbl);
            panel2.Controls.Add(edit_companyname_txtbox);
            panel2.Location = new Point(27, 71);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 289);
            panel2.TabIndex = 27;
            // 
            // edit_email_txtbox
            // 
            edit_email_txtbox.Location = new Point(3, 159);
            edit_email_txtbox.Name = "edit_email_txtbox";
            edit_email_txtbox.Size = new Size(201, 23);
            edit_email_txtbox.TabIndex = 15;
            // 
            // itemcolor_txtbox
            // 
            itemcolor_txtbox.AutoSize = true;
            itemcolor_txtbox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemcolor_txtbox.Location = new Point(3, 141);
            itemcolor_txtbox.Name = "itemcolor_txtbox";
            itemcolor_txtbox.Size = new Size(81, 15);
            itemcolor_txtbox.TabIndex = 14;
            itemcolor_txtbox.Text = "Email Address";
            // 
            // supplier_txtbox
            // 
            supplier_txtbox.AutoSize = true;
            supplier_txtbox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            supplier_txtbox.Location = new Point(3, 229);
            supplier_txtbox.Name = "supplier_txtbox";
            supplier_txtbox.Size = new Size(49, 15);
            supplier_txtbox.TabIndex = 11;
            supplier_txtbox.Text = "Address";
            // 
            // edit_address_txtbox
            // 
            edit_address_txtbox.Location = new Point(2, 247);
            edit_address_txtbox.Name = "edit_address_txtbox";
            edit_address_txtbox.Size = new Size(202, 23);
            edit_address_txtbox.TabIndex = 10;
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
            label4.Size = new Size(64, 15);
            label4.TabIndex = 2;
            label4.Text = "First Name";
            // 
            // itemcategory_txtbox
            // 
            itemcategory_txtbox.AutoSize = true;
            itemcategory_txtbox.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            itemcategory_txtbox.Location = new Point(3, 185);
            itemcategory_txtbox.Name = "itemcategory_txtbox";
            itemcategory_txtbox.Size = new Size(88, 15);
            itemcategory_txtbox.TabIndex = 8;
            itemcategory_txtbox.Text = "Phone Number";
            // 
            // edit_firstname_txtbox
            // 
            edit_firstname_txtbox.Location = new Point(3, 27);
            edit_firstname_txtbox.Name = "edit_firstname_txtbox";
            edit_firstname_txtbox.Size = new Size(201, 23);
            edit_firstname_txtbox.TabIndex = 1;
            // 
            // edit_phonenumber_txtbox
            // 
            edit_phonenumber_txtbox.Location = new Point(3, 203);
            edit_phonenumber_txtbox.Name = "edit_phonenumber_txtbox";
            edit_phonenumber_txtbox.Size = new Size(201, 23);
            edit_phonenumber_txtbox.TabIndex = 7;
            // 
            // edit_lastname_txtbox
            // 
            edit_lastname_txtbox.Location = new Point(3, 71);
            edit_lastname_txtbox.Name = "edit_lastname_txtbox";
            edit_lastname_txtbox.Size = new Size(201, 23);
            edit_lastname_txtbox.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 97);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(93, 15);
            label6.TabIndex = 6;
            label6.Text = "Company Name";
            // 
            // lastnamelbl
            // 
            lastnamelbl.AutoSize = true;
            lastnamelbl.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lastnamelbl.Location = new Point(3, 53);
            lastnamelbl.Name = "lastnamelbl";
            lastnamelbl.Size = new Size(63, 15);
            lastnamelbl.TabIndex = 4;
            lastnamelbl.Text = "Last Name";
            // 
            // edit_companyname_txtbox
            // 
            edit_companyname_txtbox.Location = new Point(3, 115);
            edit_companyname_txtbox.Name = "edit_companyname_txtbox";
            edit_companyname_txtbox.Size = new Size(201, 23);
            edit_companyname_txtbox.TabIndex = 5;
            // 
            // editCustomerUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(2, 24, 37);
            Controls.Add(edit_costumer_btn);
            Controls.Add(Label_add);
            Controls.Add(add_customers_close_btn);
            Controls.Add(panel2);
            ForeColor = Color.FromArgb(2, 24, 37);
            Name = "editCustomerUserControl";
            Size = new Size(261, 439);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button edit_costumer_btn;
        private ReaLTaiizor.Controls.BigLabel Label_add;
        private Button add_customers_close_btn;
        private Panel panel2;
        private Label itemcolor_txtbox;
        private Label supplier_txtbox;
        private TextBox edit_address_txtbox;
        private Label Order_dtle;
        private Label label4;
        private Label itemcategory_txtbox;
        private TextBox edit_firstname_txtbox;
        private TextBox edit_phonenumber_txtbox;
        private TextBox edit_lastname_txtbox;
        private Label label6;
        private Label lastnamelbl;
        private TextBox edit_companyname_txtbox;
        private TextBox edit_email_txtbox;
    }
}
