﻿namespace inventory_system.Window_Forms
{
    partial class OrdersAdd
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
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdersAdd));
            Label_add = new ReaLTaiizor.Controls.BigLabel();
            Customer_nme = new TextBox();
            label1 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label3 = new Label();
            Purchase_ordr = new TextBox();
            DR_No = new Label();
            Delivery_rcpt = new TextBox();
            panel1 = new Panel();
            label10 = new Label();
            textBox8 = new TextBox();
            New_ctm = new Label();
            panel2 = new Panel();
            label9 = new Label();
            textBox7 = new TextBox();
            dataGridView_Order = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            label8 = new Label();
            textBox6 = new TextBox();
            Order_dtle = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            textBox5 = new TextBox();
            Add_btn1 = new Button();
            Delete_order = new Button();
            Exit_ordrs = new Button();
            Add_order = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).BeginInit();
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
            // Customer_nme
            // 
            Customer_nme.Location = new Point(3, 53);
            Customer_nme.Name = "Customer_nme";
            Customer_nme.Size = new Size(179, 23);
            Customer_nme.TabIndex = 1;
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
            // textBox2
            // 
            textBox2.Location = new Point(3, 97);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(179, 23);
            textBox2.TabIndex = 3;
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
            // Purchase_ordr
            // 
            Purchase_ordr.Location = new Point(3, 141);
            Purchase_ordr.Name = "Purchase_ordr";
            Purchase_ordr.Size = new Size(179, 23);
            Purchase_ordr.TabIndex = 5;
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
            // Delivery_rcpt
            // 
            Delivery_rcpt.Location = new Point(3, 185);
            Delivery_rcpt.Name = "Delivery_rcpt";
            Delivery_rcpt.Size = new Size(179, 23);
            Delivery_rcpt.TabIndex = 7;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label10);
            panel1.Controls.Add(textBox8);
            panel1.Controls.Add(New_ctm);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(DR_No);
            panel1.Controls.Add(Customer_nme);
            panel1.Controls.Add(Delivery_rcpt);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(Purchase_ordr);
            panel1.Location = new Point(9, 65);
            panel1.Name = "panel1";
            panel1.Size = new Size(187, 334);
            panel1.TabIndex = 9;
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
            // textBox8
            // 
            textBox8.Location = new Point(3, 229);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(179, 23);
            textBox8.TabIndex = 11;
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
            panel2.Controls.Add(textBox7);
            panel2.Controls.Add(Add_btn1);
            panel2.Controls.Add(dataGridView_Order);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(textBox6);
            panel2.Controls.Add(Order_dtle);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(textBox3);
            panel2.Controls.Add(textBox4);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(textBox5);
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
            // textBox7
            // 
            textBox7.Location = new Point(3, 159);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(127, 23);
            textBox7.TabIndex = 13;
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
            dataGridView_Order.Name = "dataGridView_Order";
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
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle5.SelectionForeColor = Color.Black;
            Column3.DefaultCellStyle = dataGridViewCellStyle5;
            Column3.HeaderText = "Length";
            Column3.Name = "Column3";
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
            Column6.Width = 96;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(3, 229);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 11;
            label8.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(2, 247);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 10;
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
            // textBox1
            // 
            textBox1.Location = new Point(3, 27);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 203);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 7;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 71);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 97);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Item Length";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 53);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 4;
            label7.Text = "Item Discription";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 115);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 5;
            // 
            // Add_btn1
            // 
            Add_btn1.BackColor = Color.Silver;
            Add_btn1.FlatStyle = FlatStyle.Popup;
            Add_btn1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_btn1.ForeColor = SystemColors.ActiveCaptionText;
            Add_btn1.Image = (Image)resources.GetObject("Add_btn1.Image");
            Add_btn1.ImageAlign = ContentAlignment.MiddleLeft;
            Add_btn1.Location = new Point(26, 288);
            Add_btn1.Name = "Add_btn1";
            Add_btn1.Size = new Size(70, 36);
            Add_btn1.TabIndex = 13;
            Add_btn1.Text = "Add";
            Add_btn1.TextImageRelation = TextImageRelation.ImageBeforeText;
            Add_btn1.UseVisualStyleBackColor = false;
            // 
            // Delete_order
            // 
            Delete_order.BackColor = Color.Silver;
            Delete_order.FlatStyle = FlatStyle.Popup;
            Delete_order.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Delete_order.ForeColor = SystemColors.ActiveCaptionText;
            Delete_order.Image = (Image)resources.GetObject("Delete_order.Image");
            Delete_order.ImageAlign = ContentAlignment.MiddleLeft;
            Delete_order.Location = new Point(317, 23);
            Delete_order.Name = "Delete_order";
            Delete_order.Size = new Size(86, 36);
            Delete_order.TabIndex = 14;
            Delete_order.Text = "Delete";
            Delete_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            Delete_order.UseVisualStyleBackColor = false;
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
            // 
            // Add_order
            // 
            Add_order.BackColor = Color.Silver;
            Add_order.FlatStyle = FlatStyle.Popup;
            Add_order.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Add_order.ForeColor = SystemColors.ActiveCaptionText;
            Add_order.Image = (Image)resources.GetObject("Add_order.Image");
            Add_order.ImageAlign = ContentAlignment.MiddleLeft;
            Add_order.Location = new Point(202, 23);
            Add_order.Name = "Add_order";
            Add_order.Size = new Size(109, 36);
            Add_order.TabIndex = 15;
            Add_order.Text = "Add Order";
            Add_order.TextImageRelation = TextImageRelation.ImageBeforeText;
            Add_order.UseVisualStyleBackColor = false;
            // 
            // OrdersAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
            Controls.Add(Add_order);
            Controls.Add(Exit_ordrs);
            Controls.Add(Delete_order);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(Label_add);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OrdersAdd";
            Text = "OrdersAdd";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel Label_add;
        private TextBox Customer_nme;
        private Label label1;
        private Label label2;
        private TextBox textBox2;
        private Label label3;
        private TextBox Purchase_ordr;
        private Label DR_No;
        private TextBox Delivery_rcpt;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private TextBox textBox1;
        private Label New_ctm;
        private Label Order_dtle;
        private Label label5;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label6;
        private Label label7;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox6;
        private DataGridView dataGridView_Order;
        private Label label9;
        private TextBox textBox7;
        private Label label10;
        private TextBox textBox8;
        private Button Add_btn1;
        private Button Delete_order;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private Button Exit_ordrs;
        private Button Add_order;
    }
}