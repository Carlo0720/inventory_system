namespace inventory_system
{
    partial class CustomersAddUserControl
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
            TextBox email_txtbox;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomersAddUserControl));
            add_costumer_btn = new Button();
            Label_add = new ReaLTaiizor.Controls.BigLabel();
            add_customers_close_btn = new Button();
            panel2 = new Panel();
            itemcolor_txtbox = new Label();
            supplier_txtbox = new Label();
            address_txtbox = new TextBox();
            Order_dtle = new Label();
            label4 = new Label();
            itemcategory_txtbox = new Label();
            firstname_txtbox = new TextBox();
            phonenumber_txtbox = new TextBox();
            lastname_txtbox = new TextBox();
            label6 = new Label();
            lastnamelbl = new Label();
            companyname_txtbox = new TextBox();
            email_txtbox = new TextBox();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // email_txtbox
            // 
            email_txtbox.Location = new Point(3, 159);
            email_txtbox.Name = "email_txtbox";
            email_txtbox.Size = new Size(201, 23);
            email_txtbox.TabIndex = 13;
            // 
            // add_costumer_btn
            // 
            add_costumer_btn.BackColor = Color.MediumSeaGreen;
            add_costumer_btn.FlatAppearance.BorderSize = 0;
            add_costumer_btn.FlatStyle = FlatStyle.Flat;
            add_costumer_btn.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            add_costumer_btn.ForeColor = Color.White;
            add_costumer_btn.Image = (Image)resources.GetObject("add_costumer_btn.Image");
            add_costumer_btn.ImageAlign = ContentAlignment.MiddleLeft;
            add_costumer_btn.Location = new Point(26, 370);
            add_costumer_btn.Name = "add_costumer_btn";
            add_costumer_btn.Size = new Size(209, 33);
            add_costumer_btn.TabIndex = 24;
            add_costumer_btn.Text = "Add Customer";
            add_costumer_btn.TextImageRelation = TextImageRelation.ImageBeforeText;
            add_costumer_btn.UseVisualStyleBackColor = false;
            add_costumer_btn.Click += add_product_btn_Click;
            // 
            // Label_add
            // 
            Label_add.Anchor = AnchorStyles.None;
            Label_add.AutoSize = true;
            Label_add.BackColor = Color.Transparent;
            Label_add.FlatStyle = FlatStyle.Flat;
            Label_add.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Label_add.ForeColor = Color.White;
            Label_add.Location = new Point(38, 37);
            Label_add.Name = "Label_add";
            Label_add.Size = new Size(189, 32);
            Label_add.TabIndex = 22;
            Label_add.Text = "Add Customers";
            // 
            // add_customers_close_btn
            // 
            add_customers_close_btn.BackColor = Color.Red;
            add_customers_close_btn.BackgroundImage = (Image)resources.GetObject("add_customers_close_btn.BackgroundImage");
            add_customers_close_btn.BackgroundImageLayout = ImageLayout.Stretch;
            add_customers_close_btn.FlatAppearance.BorderColor = Color.FromArgb(255, 128, 0);
            add_customers_close_btn.FlatAppearance.BorderSize = 0;
            add_customers_close_btn.FlatStyle = FlatStyle.Flat;
            add_customers_close_btn.Location = new Point(237, 3);
            add_customers_close_btn.Name = "add_customers_close_btn";
            add_customers_close_btn.Size = new Size(21, 22);
            add_customers_close_btn.TabIndex = 25;
            add_customers_close_btn.UseVisualStyleBackColor = false;
            add_customers_close_btn.Click += add_product_close_btn_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.WhiteSmoke;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(itemcolor_txtbox);
            panel2.Controls.Add(email_txtbox);
            panel2.Controls.Add(supplier_txtbox);
            panel2.Controls.Add(address_txtbox);
            panel2.Controls.Add(Order_dtle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(itemcategory_txtbox);
            panel2.Controls.Add(firstname_txtbox);
            panel2.Controls.Add(phonenumber_txtbox);
            panel2.Controls.Add(lastname_txtbox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(lastnamelbl);
            panel2.Controls.Add(companyname_txtbox);
            panel2.Location = new Point(26, 72);
            panel2.Name = "panel2";
            panel2.Size = new Size(209, 289);
            panel2.TabIndex = 23;
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
            // address_txtbox
            // 
            address_txtbox.Location = new Point(2, 247);
            address_txtbox.Name = "address_txtbox";
            address_txtbox.Size = new Size(202, 23);
            address_txtbox.TabIndex = 10;
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
            // firstname_txtbox
            // 
            firstname_txtbox.Location = new Point(3, 27);
            firstname_txtbox.Name = "firstname_txtbox";
            firstname_txtbox.Size = new Size(201, 23);
            firstname_txtbox.TabIndex = 1;
            // 
            // phonenumber_txtbox
            // 
            phonenumber_txtbox.Location = new Point(3, 203);
            phonenumber_txtbox.Name = "phonenumber_txtbox";
            phonenumber_txtbox.Size = new Size(201, 23);
            phonenumber_txtbox.TabIndex = 7;
            // 
            // lastname_txtbox
            // 
            lastname_txtbox.Location = new Point(3, 71);
            lastname_txtbox.Name = "lastname_txtbox";
            lastname_txtbox.Size = new Size(201, 23);
            lastname_txtbox.TabIndex = 3;
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
            // companyname_txtbox
            // 
            companyname_txtbox.Location = new Point(3, 115);
            companyname_txtbox.Name = "companyname_txtbox";
            companyname_txtbox.Size = new Size(201, 23);
            companyname_txtbox.TabIndex = 5;
            // 
            // CustomersAddUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            Controls.Add(add_costumer_btn);
            Controls.Add(Label_add);
            Controls.Add(add_customers_close_btn);
            Controls.Add(panel2);
            Name = "CustomersAddUserControl";
            Size = new Size(261, 439);
            Load += CustomersAddUserControl_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button add_costumer_btn;
        private ReaLTaiizor.Controls.BigLabel Label_add;
        private Button add_customers_close_btn;
        private Panel panel2;
        private Label itemcolor_txtbox;
        private TextBox email_txtbox;
        private Label Order_dtle;
        private Label label4;
        private Label itemcategory_txtbox;
        private TextBox firstname_txtbox;
        private TextBox phonenumber_txtbox;
        private TextBox lastname_txtbox;
        private Label label6;
        private Label lastnamelbl;
        private TextBox companyname_txtbox;
        private Label supplier_txtbox;
        private TextBox address_txtbox;
    }
}
