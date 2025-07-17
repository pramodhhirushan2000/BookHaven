namespace BookHaven.User_Controls
{
    partial class UC_Customer_Manage
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
            dgvCustomers = new DataGridView();
            btn_delete_customer = new Button();
            btn_update_customer = new Button();
            btn_add_customer = new Button();
            btn_cus_search = new Button();
            tb_cus_address = new TextBox();
            tb_cus_nic = new TextBox();
            tb_cus_phone = new TextBox();
            tb_cus_email = new TextBox();
            tb_cus_name = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label7 = new Label();
            dgvPurchaseHistory = new DataGridView();
            btn_cus_vp_history = new Button();
            tb_cus_id = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).BeginInit();
            SuspendLayout();
            // 
            // dgvCustomers
            // 
            dgvCustomers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCustomers.Location = new Point(481, 128);
            dgvCustomers.Name = "dgvCustomers";
            dgvCustomers.RowHeadersWidth = 51;
            dgvCustomers.Size = new Size(486, 188);
            dgvCustomers.TabIndex = 37;
            // 
            // btn_delete_customer
            // 
            btn_delete_customer.BackColor = Color.Navy;
            btn_delete_customer.FlatStyle = FlatStyle.Flat;
            btn_delete_customer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_customer.ForeColor = Color.White;
            btn_delete_customer.Location = new Point(347, 333);
            btn_delete_customer.Name = "btn_delete_customer";
            btn_delete_customer.Size = new Size(94, 37);
            btn_delete_customer.TabIndex = 36;
            btn_delete_customer.Text = "Delete";
            btn_delete_customer.UseVisualStyleBackColor = false;
            btn_delete_customer.Click += btn_delete_customer_Click;
            // 
            // btn_update_customer
            // 
            btn_update_customer.BackColor = Color.Navy;
            btn_update_customer.FlatStyle = FlatStyle.Flat;
            btn_update_customer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_customer.ForeColor = Color.White;
            btn_update_customer.Location = new Point(228, 333);
            btn_update_customer.Name = "btn_update_customer";
            btn_update_customer.Size = new Size(94, 37);
            btn_update_customer.TabIndex = 35;
            btn_update_customer.Text = "Update";
            btn_update_customer.UseVisualStyleBackColor = false;
            btn_update_customer.Click += btn_update_customer_Click;
            // 
            // btn_add_customer
            // 
            btn_add_customer.BackColor = Color.Navy;
            btn_add_customer.FlatStyle = FlatStyle.Flat;
            btn_add_customer.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_customer.ForeColor = Color.White;
            btn_add_customer.Location = new Point(102, 333);
            btn_add_customer.Name = "btn_add_customer";
            btn_add_customer.Size = new Size(94, 37);
            btn_add_customer.TabIndex = 34;
            btn_add_customer.Text = "Add";
            btn_add_customer.UseVisualStyleBackColor = false;
            btn_add_customer.Click += btn_add_customer_Click;
            // 
            // btn_cus_search
            // 
            btn_cus_search.BackColor = Color.Navy;
            btn_cus_search.FlatStyle = FlatStyle.Flat;
            btn_cus_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cus_search.ForeColor = Color.White;
            btn_cus_search.Location = new Point(442, 83);
            btn_cus_search.Name = "btn_cus_search";
            btn_cus_search.Size = new Size(94, 37);
            btn_cus_search.TabIndex = 33;
            btn_cus_search.Text = "Search";
            btn_cus_search.UseVisualStyleBackColor = false;
            btn_cus_search.Click += btn_cus_search_Click;
            // 
            // tb_cus_address
            // 
            tb_cus_address.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_address.Location = new Point(135, 266);
            tb_cus_address.Name = "tb_cus_address";
            tb_cus_address.Size = new Size(287, 27);
            tb_cus_address.TabIndex = 30;
            // 
            // tb_cus_nic
            // 
            tb_cus_nic.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_nic.Location = new Point(135, 86);
            tb_cus_nic.Name = "tb_cus_nic";
            tb_cus_nic.Size = new Size(287, 27);
            tb_cus_nic.TabIndex = 29;
            // 
            // tb_cus_phone
            // 
            tb_cus_phone.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_phone.Location = new Point(135, 212);
            tb_cus_phone.Name = "tb_cus_phone";
            tb_cus_phone.Size = new Size(287, 27);
            tb_cus_phone.TabIndex = 28;
            // 
            // tb_cus_email
            // 
            tb_cus_email.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_email.Location = new Point(135, 174);
            tb_cus_email.Name = "tb_cus_email";
            tb_cus_email.Size = new Size(287, 27);
            tb_cus_email.TabIndex = 27;
            // 
            // tb_cus_name
            // 
            tb_cus_name.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_name.Location = new Point(135, 128);
            tb_cus_name.Name = "tb_cus_name";
            tb_cus_name.Size = new Size(287, 27);
            tb_cus_name.TabIndex = 26;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(41, 265);
            label6.Name = "label6";
            label6.Size = new Size(88, 23);
            label6.TabIndex = 24;
            label6.Text = "Address";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(78, 90);
            label5.Name = "label5";
            label5.Size = new Size(46, 23);
            label5.TabIndex = 23;
            label5.Text = "NIC";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(52, 211);
            label4.Name = "label4";
            label4.Size = new Size(72, 23);
            label4.TabIndex = 22;
            label4.Text = "Phone";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(62, 173);
            label3.Name = "label3";
            label3.Size = new Size(62, 23);
            label3.TabIndex = 21;
            label3.Text = "Email";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(58, 132);
            label2.Name = "label2";
            label2.Size = new Size(71, 23);
            label2.TabIndex = 20;
            label2.Text = "Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(8, 28);
            label1.Name = "label1";
            label1.Size = new Size(344, 34);
            label1.TabIndex = 19;
            label1.Text = "Customer Management ";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(590, 372);
            label7.Name = "label7";
            label7.Size = new Size(377, 23);
            label7.TabIndex = 38;
            label7.Text = "Selected Customer’s Purchase History";
            // 
            // dgvPurchaseHistory
            // 
            dgvPurchaseHistory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPurchaseHistory.Location = new Point(481, 398);
            dgvPurchaseHistory.Name = "dgvPurchaseHistory";
            dgvPurchaseHistory.RowHeadersWidth = 51;
            dgvPurchaseHistory.Size = new Size(486, 168);
            dgvPurchaseHistory.TabIndex = 39;
            // 
            // btn_cus_vp_history
            // 
            btn_cus_vp_history.BackColor = Color.Navy;
            btn_cus_vp_history.FlatStyle = FlatStyle.Flat;
            btn_cus_vp_history.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cus_vp_history.ForeColor = Color.White;
            btn_cus_vp_history.Location = new Point(712, 332);
            btn_cus_vp_history.Name = "btn_cus_vp_history";
            btn_cus_vp_history.Size = new Size(255, 37);
            btn_cus_vp_history.TabIndex = 40;
            btn_cus_vp_history.Text = "View Purchase History";
            btn_cus_vp_history.UseVisualStyleBackColor = false;
            btn_cus_vp_history.Click += btn_cus_vp_history_Click;
            // 
            // tb_cus_id
            // 
            tb_cus_id.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_id.Location = new Point(481, 340);
            tb_cus_id.Name = "tb_cus_id";
            tb_cus_id.Size = new Size(225, 27);
            tb_cus_id.TabIndex = 41;
            // 
            // UC_Customer_Manage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(tb_cus_id);
            Controls.Add(btn_cus_vp_history);
            Controls.Add(dgvPurchaseHistory);
            Controls.Add(label7);
            Controls.Add(dgvCustomers);
            Controls.Add(btn_delete_customer);
            Controls.Add(btn_update_customer);
            Controls.Add(btn_add_customer);
            Controls.Add(btn_cus_search);
            Controls.Add(tb_cus_address);
            Controls.Add(tb_cus_nic);
            Controls.Add(tb_cus_phone);
            Controls.Add(tb_cus_email);
            Controls.Add(tb_cus_name);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Customer_Manage";
            Size = new Size(988, 580);
            ((System.ComponentModel.ISupportInitialize)dgvCustomers).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPurchaseHistory).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCustomers;
        private Button btn_delete_customer;
        private Button btn_update_customer;
        private Button btn_add_customer;
        private Button btn_cus_search;
        private TextBox tb_cus_address;
        private TextBox tb_cus_nic;
        private TextBox tb_cus_phone;
        private TextBox tb_cus_email;
        private TextBox tb_cus_name;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label7;
        private DataGridView dgvPurchaseHistory;
        private Button btn_cus_vp_history;
        private TextBox tb_cus_id;
    }
}
