namespace BookHaven.User_Controls
{
    partial class UC_Order_Management
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
            label9 = new Label();
            label8 = new Label();
            dgvOrderCart = new DataGridView();
            btn_search_order = new Button();
            btn_update_order = new Button();
            tb_cus_id = new TextBox();
            tb_delivery_address = new TextBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            cmbDeliveryMethod = new ComboBox();
            dtpDeliveryDate = new DateTimePicker();
            cmbOrderStatus = new ComboBox();
            label5 = new Label();
            cmbPaymentStatus = new ComboBox();
            label10 = new Label();
            tb_order_id = new TextBox();
            btn_place_order = new Button();
            tb_search_order = new TextBox();
            dgvOrders = new DataGridView();
            tb_total_amount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvOrderCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(62, 76);
            label7.Name = "label7";
            label7.Size = new Size(130, 23);
            label7.TabIndex = 85;
            label7.Text = "Customer ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(62, 421);
            label9.Name = "label9";
            label9.Size = new Size(130, 23);
            label9.TabIndex = 82;
            label9.Text = "Order Status";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(844, 296);
            label8.Name = "label8";
            label8.Size = new Size(115, 23);
            label8.TabIndex = 81;
            label8.Text = "Order Cart";
            // 
            // dgvOrderCart
            // 
            dgvOrderCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderCart.Location = new Point(559, 322);
            dgvOrderCart.Name = "dgvOrderCart";
            dgvOrderCart.RowHeadersWidth = 51;
            dgvOrderCart.Size = new Size(400, 204);
            dgvOrderCart.TabIndex = 80;
            // 
            // btn_search_order
            // 
            btn_search_order.BackColor = Color.Navy;
            btn_search_order.FlatStyle = FlatStyle.Flat;
            btn_search_order.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search_order.ForeColor = Color.White;
            btn_search_order.Location = new Point(791, 19);
            btn_search_order.Name = "btn_search_order";
            btn_search_order.Size = new Size(168, 37);
            btn_search_order.TabIndex = 79;
            btn_search_order.Text = "Search Order";
            btn_search_order.UseVisualStyleBackColor = false;
            btn_search_order.Click += btn_search_order_Click;
            // 
            // btn_update_order
            // 
            btn_update_order.BackColor = Color.Navy;
            btn_update_order.FlatStyle = FlatStyle.Flat;
            btn_update_order.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_order.ForeColor = Color.White;
            btn_update_order.Location = new Point(346, 510);
            btn_update_order.Name = "btn_update_order";
            btn_update_order.Size = new Size(176, 37);
            btn_update_order.TabIndex = 78;
            btn_update_order.Text = "Update Order";
            btn_update_order.UseVisualStyleBackColor = false;
            btn_update_order.Click += btn_update_order_Click;
            // 
            // tb_cus_id
            // 
            tb_cus_id.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_id.Location = new Point(198, 72);
            tb_cus_id.Name = "tb_cus_id";
            tb_cus_id.Size = new Size(324, 27);
            tb_cus_id.TabIndex = 75;
            // 
            // tb_delivery_address
            // 
            tb_delivery_address.BorderStyle = BorderStyle.FixedSingle;
            tb_delivery_address.Location = new Point(198, 207);
            tb_delivery_address.Name = "tb_delivery_address";
            tb_delivery_address.Size = new Size(324, 27);
            tb_delivery_address.TabIndex = 70;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(21, 162);
            label6.Name = "label6";
            label6.Size = new Size(245, 23);
            label6.TabIndex = 69;
            label6.Text = "Expected Delivery Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(19, 211);
            label4.Name = "label4";
            label4.Size = new Size(173, 23);
            label4.TabIndex = 67;
            label4.Text = "Delivery Address";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(21, 120);
            label3.Name = "label3";
            label3.Size = new Size(171, 23);
            label3.TabIndex = 66;
            label3.Text = "Delivery Method";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(34, 252);
            label2.Name = "label2";
            label2.Size = new Size(158, 23);
            label2.TabIndex = 65;
            label2.Text = "Total Amount : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(22, 19);
            label1.Name = "label1";
            label1.Size = new Size(292, 34);
            label1.TabIndex = 64;
            label1.Text = "Order Management ";
            // 
            // cmbDeliveryMethod
            // 
            cmbDeliveryMethod.FormattingEnabled = true;
            cmbDeliveryMethod.Items.AddRange(new object[] { "Pickup", "Delivery" });
            cmbDeliveryMethod.Location = new Point(198, 115);
            cmbDeliveryMethod.Name = "cmbDeliveryMethod";
            cmbDeliveryMethod.Size = new Size(324, 28);
            cmbDeliveryMethod.TabIndex = 86;
            // 
            // dtpDeliveryDate
            // 
            dtpDeliveryDate.Location = new Point(272, 162);
            dtpDeliveryDate.Name = "dtpDeliveryDate";
            dtpDeliveryDate.Size = new Size(250, 27);
            dtpDeliveryDate.TabIndex = 87;
            // 
            // cmbOrderStatus
            // 
            cmbOrderStatus.FormattingEnabled = true;
            cmbOrderStatus.Items.AddRange(new object[] { "Pending", "Process", "Delivery" });
            cmbOrderStatus.Location = new Point(198, 421);
            cmbOrderStatus.Name = "cmbOrderStatus";
            cmbOrderStatus.Size = new Size(324, 28);
            cmbOrderStatus.TabIndex = 88;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(30, 471);
            label5.Name = "label5";
            label5.Size = new Size(162, 23);
            label5.TabIndex = 89;
            label5.Text = "Payment Status";
            // 
            // cmbPaymentStatus
            // 
            cmbPaymentStatus.FormattingEnabled = true;
            cmbPaymentStatus.Items.AddRange(new object[] { "Pending", "Paid", "Refunded" });
            cmbPaymentStatus.Location = new Point(198, 466);
            cmbPaymentStatus.Name = "cmbPaymentStatus";
            cmbPaymentStatus.Size = new Size(324, 28);
            cmbPaymentStatus.TabIndex = 90;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(100, 388);
            label10.Name = "label10";
            label10.Size = new Size(92, 23);
            label10.TabIndex = 91;
            label10.Text = "Order ID";
            // 
            // tb_order_id
            // 
            tb_order_id.BorderStyle = BorderStyle.FixedSingle;
            tb_order_id.Location = new Point(198, 384);
            tb_order_id.Name = "tb_order_id";
            tb_order_id.Size = new Size(324, 27);
            tb_order_id.TabIndex = 92;
            // 
            // btn_place_order
            // 
            btn_place_order.BackColor = Color.Navy;
            btn_place_order.FlatStyle = FlatStyle.Flat;
            btn_place_order.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_place_order.ForeColor = Color.White;
            btn_place_order.Location = new Point(346, 291);
            btn_place_order.Name = "btn_place_order";
            btn_place_order.Size = new Size(176, 37);
            btn_place_order.TabIndex = 93;
            btn_place_order.Text = "Place Order";
            btn_place_order.UseVisualStyleBackColor = false;
            btn_place_order.Click += btn_place_order_Click;
            // 
            // tb_search_order
            // 
            tb_search_order.BorderStyle = BorderStyle.FixedSingle;
            tb_search_order.Location = new Point(559, 26);
            tb_search_order.Name = "tb_search_order";
            tb_search_order.Size = new Size(226, 27);
            tb_search_order.TabIndex = 95;
            // 
            // dgvOrders
            // 
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Location = new Point(559, 72);
            dgvOrders.Name = "dgvOrders";
            dgvOrders.RowHeadersWidth = 51;
            dgvOrders.Size = new Size(400, 190);
            dgvOrders.TabIndex = 96;
            // 
            // tb_total_amount
            // 
            tb_total_amount.BorderStyle = BorderStyle.FixedSingle;
            tb_total_amount.Location = new Point(198, 253);
            tb_total_amount.Name = "tb_total_amount";
            tb_total_amount.Size = new Size(324, 27);
            tb_total_amount.TabIndex = 99;
            // 
            // UC_Order_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tb_total_amount);
            Controls.Add(dgvOrders);
            Controls.Add(tb_search_order);
            Controls.Add(btn_place_order);
            Controls.Add(tb_order_id);
            Controls.Add(label10);
            Controls.Add(cmbPaymentStatus);
            Controls.Add(label5);
            Controls.Add(cmbOrderStatus);
            Controls.Add(dtpDeliveryDate);
            Controls.Add(cmbDeliveryMethod);
            Controls.Add(label7);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvOrderCart);
            Controls.Add(btn_search_order);
            Controls.Add(btn_update_order);
            Controls.Add(tb_cus_id);
            Controls.Add(tb_delivery_address);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Order_Management";
            Size = new Size(988, 580);
            ((System.ComponentModel.ISupportInitialize)dgvOrderCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label7;
        private Label label9;
        private Label label8;
        private DataGridView dgvOrderCart;
        private Button btn_search_order;
        private Button btn_update_order;
        private TextBox tb_cus_id;
        private TextBox tb_delivery_address;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbDeliveryMethod;
        private DateTimePicker dtpDeliveryDate;
        private ComboBox cmbOrderStatus;
        private Label label5;
        private ComboBox cmbPaymentStatus;
        private Label label10;
        private TextBox tb_order_id;
        private Button btn_place_order;
        private TextBox tb_search_order;
        private DataGridView dgvOrders;
        private TextBox tb_total_amount;
    }
}
