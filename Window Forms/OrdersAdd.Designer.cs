namespace inventory_system.Window_Forms
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
            DataGridViewCellStyle dataGridViewCellStyle34 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle35 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle42 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle43 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle44 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle36 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle37 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle38 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle39 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle40 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle41 = new DataGridViewCellStyle();
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
            panel2 = new Panel();
            label4 = new Label();
            textBox1 = new TextBox();
            Order_dtle = new Label();
            New_ctm = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            textBox3 = new TextBox();
            label5 = new Label();
            label8 = new Label();
            textBox6 = new TextBox();
            dataGridView_Order = new DataGridView();
            label9 = new Label();
            textBox7 = new TextBox();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            royalEllipseButton1 = new ReaLTaiizor.Controls.RoyalEllipseButton();
            royalEllipseButton2 = new ReaLTaiizor.Controls.RoyalEllipseButton();
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
            Label_add.Location = new Point(167, 9);
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
            panel1.Controls.Add(royalEllipseButton1);
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
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(224, 224, 224);
            panel2.Controls.Add(royalEllipseButton2);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(textBox7);
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
            panel2.Paint += panel2_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 35);
            label4.Name = "label4";
            label4.Size = new Size(62, 15);
            label4.TabIndex = 2;
            label4.Text = "Item Code";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(3, 53);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(127, 23);
            textBox1.TabIndex = 1;
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
            // New_ctm
            // 
            New_ctm.AutoSize = true;
            New_ctm.Location = new Point(62, 9);
            New_ctm.Name = "New_ctm";
            New_ctm.Size = new Size(86, 15);
            New_ctm.TabIndex = 10;
            New_ctm.Text = "New Customer";
            New_ctm.Click += label9_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(3, 141);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(127, 23);
            textBox5.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(3, 79);
            label7.Name = "label7";
            label7.Size = new Size(93, 15);
            label7.TabIndex = 4;
            label7.Text = "Item Discription";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(3, 123);
            label6.Name = "label6";
            label6.Size = new Size(72, 15);
            label6.TabIndex = 6;
            label6.Text = "Item Length";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(3, 97);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(127, 23);
            textBox4.TabIndex = 3;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(3, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(127, 23);
            textBox3.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(3, 211);
            label5.Name = "label5";
            label5.Size = new Size(63, 15);
            label5.TabIndex = 8;
            label5.Text = "Item Color";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(2, 255);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 11;
            label8.Text = "Price";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(2, 273);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(128, 23);
            textBox6.TabIndex = 10;
            // 
            // dataGridView_Order
            // 
            dataGridView_Order.AccessibleRole = AccessibleRole.None;
            dataGridView_Order.AllowUserToAddRows = false;
            dataGridView_Order.AllowUserToResizeColumns = false;
            dataGridView_Order.AllowUserToResizeRows = false;
            dataGridViewCellStyle34.ForeColor = Color.Black;
            dataGridViewCellStyle34.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle34.SelectionForeColor = Color.White;
            dataGridView_Order.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle34;
            dataGridView_Order.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView_Order.BackgroundColor = Color.Gray;
            dataGridView_Order.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle35.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle35.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle35.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle35.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle35.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle35.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle35.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle35;
            dataGridView_Order.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Order.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle42.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle42.BackColor = SystemColors.Window;
            dataGridViewCellStyle42.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle42.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle42.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle42.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle42.WrapMode = DataGridViewTriState.False;
            dataGridView_Order.DefaultCellStyle = dataGridViewCellStyle42;
            dataGridView_Order.GridColor = SystemColors.Window;
            dataGridView_Order.Location = new Point(136, 29);
            dataGridView_Order.Name = "dataGridView_Order";
            dataGridView_Order.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle43.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle43.BackColor = SystemColors.Window;
            dataGridViewCellStyle43.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle43.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle43.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle43.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle43.WrapMode = DataGridViewTriState.True;
            dataGridView_Order.RowHeadersDefaultCellStyle = dataGridViewCellStyle43;
            dataGridView_Order.RowHeadersVisible = false;
            dataGridView_Order.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridViewCellStyle44.BackColor = Color.Silver;
            dataGridViewCellStyle44.ForeColor = Color.Black;
            dataGridViewCellStyle44.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle44.SelectionForeColor = Color.White;
            dataGridView_Order.RowsDefaultCellStyle = dataGridViewCellStyle44;
            dataGridView_Order.RowTemplate.DefaultCellStyle.BackColor = Color.White;
            dataGridView_Order.RowTemplate.DefaultCellStyle.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridView_Order.ShowEditingIcon = false;
            dataGridView_Order.ShowRowErrors = false;
            dataGridView_Order.Size = new Size(447, 295);
            dataGridView_Order.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(3, 167);
            label9.Name = "label9";
            label9.Size = new Size(72, 15);
            label9.TabIndex = 14;
            label9.Text = "Item Length";
            // 
            // textBox7
            // 
            textBox7.Location = new Point(3, 185);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(127, 23);
            textBox7.TabIndex = 13;
            // 
            // Column1
            // 
            dataGridViewCellStyle36.BackColor = Color.Silver;
            dataGridViewCellStyle36.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle36.SelectionForeColor = Color.Black;
            Column1.DefaultCellStyle = dataGridViewCellStyle36;
            Column1.HeaderText = "Item Code";
            Column1.Name = "Column1";
            Column1.Width = 87;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle37.BackColor = Color.Silver;
            dataGridViewCellStyle37.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle37.SelectionForeColor = Color.Black;
            Column2.DefaultCellStyle = dataGridViewCellStyle37;
            Column2.HeaderText = "Discription";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            dataGridViewCellStyle38.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle38.SelectionForeColor = Color.Black;
            Column3.DefaultCellStyle = dataGridViewCellStyle38;
            Column3.HeaderText = "Length";
            Column3.Name = "Column3";
            Column3.Width = 69;
            // 
            // Column4
            // 
            dataGridViewCellStyle39.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle39.SelectionForeColor = Color.Black;
            Column4.DefaultCellStyle = dataGridViewCellStyle39;
            Column4.HeaderText = "Stock";
            Column4.Name = "Column4";
            Column4.Width = 61;
            // 
            // Column5
            // 
            dataGridViewCellStyle40.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle40.SelectionForeColor = Color.Black;
            Column5.DefaultCellStyle = dataGridViewCellStyle40;
            Column5.HeaderText = "Color";
            Column5.Name = "Column5";
            Column5.Width = 61;
            // 
            // Column6
            // 
            dataGridViewCellStyle41.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle41.SelectionForeColor = Color.Black;
            Column6.DefaultCellStyle = dataGridViewCellStyle41;
            Column6.HeaderText = "Selling Price";
            Column6.Name = "Column6";
            Column6.Width = 96;
            // 
            // royalEllipseButton1
            // 
            royalEllipseButton1.BackColor = Color.FromArgb(243, 243, 243);
            royalEllipseButton1.BorderColor = Color.FromArgb(180, 180, 180);
            royalEllipseButton1.BorderThickness = 3;
            royalEllipseButton1.DrawBorder = true;
            royalEllipseButton1.ForeColor = Color.FromArgb(31, 31, 31);
            royalEllipseButton1.HotTrackColor = Color.FromArgb(221, 221, 221);
            royalEllipseButton1.Image = null;
            royalEllipseButton1.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            royalEllipseButton1.Location = new Point(19, 255);
            royalEllipseButton1.Name = "royalEllipseButton1";
            royalEllipseButton1.PressedColor = Color.FromArgb(51, 102, 255);
            royalEllipseButton1.PressedForeColor = Color.White;
            royalEllipseButton1.Size = new Size(53, 37);
            royalEllipseButton1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            royalEllipseButton1.TabIndex = 11;
            royalEllipseButton1.Text = "royalEllipseButton1";
            // 
            // royalEllipseButton2
            // 
            royalEllipseButton2.BackColor = Color.FromArgb(243, 243, 243);
            royalEllipseButton2.BorderColor = Color.FromArgb(180, 180, 180);
            royalEllipseButton2.BorderThickness = 3;
            royalEllipseButton2.DrawBorder = true;
            royalEllipseButton2.ForeColor = Color.FromArgb(31, 31, 31);
            royalEllipseButton2.HotTrackColor = Color.FromArgb(221, 221, 221);
            royalEllipseButton2.Image = null;
            royalEllipseButton2.LayoutFlags = ReaLTaiizor.Util.RoyalLayoutFlags.ImageBeforeText;
            royalEllipseButton2.Location = new Point(37, 302);
            royalEllipseButton2.Name = "royalEllipseButton2";
            royalEllipseButton2.PressedColor = Color.FromArgb(51, 102, 255);
            royalEllipseButton2.PressedForeColor = Color.White;
            royalEllipseButton2.Size = new Size(38, 22);
            royalEllipseButton2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            royalEllipseButton2.TabIndex = 12;
            royalEllipseButton2.Text = "royalEllipseButton2";
            // 
            // OrdersAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 411);
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
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private ReaLTaiizor.Controls.RoyalEllipseButton royalEllipseButton1;
        private ReaLTaiizor.Controls.RoyalEllipseButton royalEllipseButton2;
    }
}