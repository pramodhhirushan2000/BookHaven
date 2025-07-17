namespace BookHaven.User_Controls
{
    partial class UC_Supplier_Management
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
            label7 = new Label();
            btn_view_order_history = new Button();
            dgvSupplierList = new DataGridView();
            btn_place_order = new Button();
            btn_add_supplier = new Button();
            tb_supplier_name = new TextBox();
            tb_supplier_address = new TextBox();
            tb_supplier_phone = new TextBox();
            tb_supplier_email = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btn_update_supplier = new Button();
            btn_delete_supplier = new Button();
            dgvOrderCart = new DataGridView();
            label10 = new Label();
            tb_supplier_id = new TextBox();
            label8 = new Label();
            tb_total_cost = new TextBox();
            label9 = new Label();
            label11 = new Label();
            dgv_order_history = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgv_order_history).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(73, 83);
            label7.Name = "label7";
            label7.Size = new Size(71, 23);
            label7.TabIndex = 85;
            label7.Text = "Name";
            // 
            // btn_view_order_history
            // 
            btn_view_order_history.BackColor = Color.Navy;
            btn_view_order_history.FlatStyle = FlatStyle.Flat;
            btn_view_order_history.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_view_order_history.ForeColor = Color.White;
            btn_view_order_history.Location = new Point(764, 472);
            btn_view_order_history.Name = "btn_view_order_history";
            btn_view_order_history.Size = new Size(204, 37);
            btn_view_order_history.TabIndex = 84;
            btn_view_order_history.Text = "View Order History";
            btn_view_order_history.UseVisualStyleBackColor = false;
            btn_view_order_history.Click += btn_view_order_history_Click;
            // 
            // dgvSupplierList
            // 
            dgvSupplierList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSupplierList.Location = new Point(515, 71);
            dgvSupplierList.Name = "dgvSupplierList";
            dgvSupplierList.RowHeadersWidth = 51;
            dgvSupplierList.Size = new Size(453, 262);
            dgvSupplierList.TabIndex = 80;
            // 
            // btn_place_order
            // 
            btn_place_order.BackColor = Color.Navy;
            btn_place_order.FlatStyle = FlatStyle.Flat;
            btn_place_order.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_place_order.ForeColor = Color.White;
            btn_place_order.Location = new Point(577, 472);
            btn_place_order.Name = "btn_place_order";
            btn_place_order.Size = new Size(168, 37);
            btn_place_order.TabIndex = 79;
            btn_place_order.Text = "Place Order";
            btn_place_order.UseVisualStyleBackColor = false;
            btn_place_order.Click += btn_place_order_Click;
            // 
            // btn_add_supplier
            // 
            btn_add_supplier.BackColor = Color.Navy;
            btn_add_supplier.FlatStyle = FlatStyle.Flat;
            btn_add_supplier.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_supplier.ForeColor = Color.White;
            btn_add_supplier.Location = new Point(40, 245);
            btn_add_supplier.Name = "btn_add_supplier";
            btn_add_supplier.Size = new Size(131, 37);
            btn_add_supplier.TabIndex = 78;
            btn_add_supplier.Text = "Add";
            btn_add_supplier.UseVisualStyleBackColor = false;
            btn_add_supplier.Click += btn_add_supplier_Click;
            // 
            // tb_supplier_name
            // 
            tb_supplier_name.BorderStyle = BorderStyle.FixedSingle;
            tb_supplier_name.Location = new Point(150, 79);
            tb_supplier_name.Name = "tb_supplier_name";
            tb_supplier_name.Size = new Size(326, 27);
            tb_supplier_name.TabIndex = 75;
            // 
            // tb_supplier_address
            // 
            tb_supplier_address.BorderStyle = BorderStyle.FixedSingle;
            tb_supplier_address.Location = new Point(149, 202);
            tb_supplier_address.Name = "tb_supplier_address";
            tb_supplier_address.Size = new Size(326, 27);
            tb_supplier_address.TabIndex = 72;
            // 
            // tb_supplier_phone
            // 
            tb_supplier_phone.BorderStyle = BorderStyle.FixedSingle;
            tb_supplier_phone.Location = new Point(149, 164);
            tb_supplier_phone.Name = "tb_supplier_phone";
            tb_supplier_phone.Size = new Size(326, 27);
            tb_supplier_phone.TabIndex = 71;
            // 
            // tb_supplier_email
            // 
            tb_supplier_email.BorderStyle = BorderStyle.FixedSingle;
            tb_supplier_email.Location = new Point(149, 118);
            tb_supplier_email.Name = "tb_supplier_email";
            tb_supplier_email.Size = new Size(326, 27);
            tb_supplier_email.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(21, 323);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 69;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(840, 45);
            label5.Name = "label5";
            label5.Size = new Size(128, 23);
            label5.TabIndex = 68;
            label5.Text = "Suppliers List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(55, 206);
            label4.Name = "label4";
            label4.Size = new Size(88, 23);
            label4.TabIndex = 67;
            label4.Text = "Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(71, 168);
            label3.Name = "label3";
            label3.Size = new Size(72, 23);
            label3.TabIndex = 66;
            label3.Text = "Phone";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(81, 122);
            label2.Name = "label2";
            label2.Size = new Size(62, 23);
            label2.TabIndex = 65;
            label2.Text = "Email";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(315, 34);
            label1.TabIndex = 64;
            label1.Text = "Supplier Management";
            // 
            // btn_update_supplier
            // 
            btn_update_supplier.BackColor = Color.Navy;
            btn_update_supplier.FlatStyle = FlatStyle.Flat;
            btn_update_supplier.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_supplier.ForeColor = Color.White;
            btn_update_supplier.Location = new Point(192, 245);
            btn_update_supplier.Name = "btn_update_supplier";
            btn_update_supplier.Size = new Size(131, 37);
            btn_update_supplier.TabIndex = 86;
            btn_update_supplier.Text = "Update";
            btn_update_supplier.UseVisualStyleBackColor = false;
            btn_update_supplier.Click += btn_update_supplier_Click;
            // 
            // btn_delete_supplier
            // 
            btn_delete_supplier.BackColor = Color.Navy;
            btn_delete_supplier.FlatStyle = FlatStyle.Flat;
            btn_delete_supplier.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_supplier.ForeColor = Color.White;
            btn_delete_supplier.Location = new Point(345, 245);
            btn_delete_supplier.Name = "btn_delete_supplier";
            btn_delete_supplier.Size = new Size(131, 37);
            btn_delete_supplier.TabIndex = 87;
            btn_delete_supplier.Text = "Delete";
            btn_delete_supplier.UseVisualStyleBackColor = false;
            btn_delete_supplier.Click += btn_delete_supplier_Click;
            // 
            // dgvOrderCart
            // 
            dgvOrderCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderCart.Location = new Point(23, 336);
            dgvOrderCart.Name = "dgvOrderCart";
            dgvOrderCart.RowHeadersWidth = 51;
            dgvOrderCart.Size = new Size(453, 101);
            dgvOrderCart.TabIndex = 88;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(360, 310);
            label10.Name = "label10";
            label10.Size = new Size(115, 23);
            label10.TabIndex = 89;
            label10.Text = "Order Cart";
            // 
            // tb_supplier_id
            // 
            tb_supplier_id.BorderStyle = BorderStyle.FixedSingle;
            tb_supplier_id.Location = new Point(642, 363);
            tb_supplier_id.Name = "tb_supplier_id";
            tb_supplier_id.Size = new Size(326, 27);
            tb_supplier_id.TabIndex = 91;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(523, 367);
            label8.Name = "label8";
            label8.Size = new Size(113, 23);
            label8.TabIndex = 90;
            label8.Text = "Supplier ID";
            // 
            // tb_total_cost
            // 
            tb_total_cost.BorderStyle = BorderStyle.FixedSingle;
            tb_total_cost.Location = new Point(642, 407);
            tb_total_cost.Name = "tb_total_cost";
            tb_total_cost.Size = new Size(326, 27);
            tb_total_cost.TabIndex = 93;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(529, 406);
            label9.Name = "label9";
            label9.Size = new Size(107, 23);
            label9.TabIndex = 92;
            label9.Text = "Total Cost";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Navy;
            label11.Location = new Point(287, 450);
            label11.Name = "label11";
            label11.Size = new Size(189, 23);
            label11.TabIndex = 95;
            label11.Text = "View Order History";
            // 
            // dgv_order_history
            // 
            dgv_order_history.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_order_history.Location = new Point(23, 476);
            dgv_order_history.Name = "dgv_order_history";
            dgv_order_history.RowHeadersWidth = 51;
            dgv_order_history.Size = new Size(453, 101);
            dgv_order_history.TabIndex = 94;
            // 
            // UC_Supplier_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label11);
            Controls.Add(dgv_order_history);
            Controls.Add(tb_total_cost);
            Controls.Add(label9);
            Controls.Add(tb_supplier_id);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(dgvOrderCart);
            Controls.Add(btn_delete_supplier);
            Controls.Add(btn_update_supplier);
            Controls.Add(label7);
            Controls.Add(btn_view_order_history);
            Controls.Add(dgvSupplierList);
            Controls.Add(btn_place_order);
            Controls.Add(btn_add_supplier);
            Controls.Add(tb_supplier_name);
            Controls.Add(tb_supplier_address);
            Controls.Add(tb_supplier_phone);
            Controls.Add(tb_supplier_email);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Supplier_Management";
            Size = new Size(988, 580);
            ((System.ComponentModel.ISupportInitialize)dgvSupplierList).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgv_order_history).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Button btn_view_order_history;
        private DataGridView dgvSupplierList;
        private Button btn_place_order;
        private Button btn_add_supplier;
        private TextBox tb_supplier_name;
        private TextBox tb_supplier_address;
        private TextBox tb_supplier_phone;
        private TextBox tb_supplier_email;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button btn_update_supplier;
        private Button btn_delete_supplier;
        private DataGridView dgvOrderCart;
        private Label label10;
        private TextBox tb_supplier_id;
        private Label label8;
        private TextBox tb_total_cost;
        private Label label9;
        private Label label11;
        private DataGridView dgv_order_history;
    }
}
