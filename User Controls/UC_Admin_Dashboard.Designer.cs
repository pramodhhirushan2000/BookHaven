namespace BookHaven.User_Controls
{
    partial class UC_Admin_Dashboard
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
            label10 = new Label();
            dgvLowStockBooks = new DataGridView();
            label7 = new Label();
            label6 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            lblTotalSales = new Label();
            panel2 = new Panel();
            lblTotalCustomers = new Label();
            label9 = new Label();
            panel3 = new Panel();
            lblTotalBooks = new Label();
            label12 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLowStockBooks).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(764, 233);
            label10.Name = "label10";
            label10.Size = new Size(170, 23);
            label10.TabIndex = 108;
            label10.Text = "Low Stock Books";
            // 
            // dgvLowStockBooks
            // 
            dgvLowStockBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLowStockBooks.Location = new Point(29, 259);
            dgvLowStockBooks.Name = "dgvLowStockBooks";
            dgvLowStockBooks.RowHeadersWidth = 51;
            dgvLowStockBooks.Size = new Size(905, 186);
            dgvLowStockBooks.TabIndex = 107;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(50, 38);
            label7.Name = "label7";
            label7.Size = new Size(129, 27);
            label7.TabIndex = 104;
            label7.Text = "Total Sales";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(21, 324);
            label6.Name = "label6";
            label6.Size = new Size(0, 23);
            label6.TabIndex = 95;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(22, 20);
            label1.Name = "label1";
            label1.Size = new Size(260, 34);
            label1.TabIndex = 90;
            label1.Text = "Admin Dashboard";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Teal;
            panel1.Controls.Add(lblTotalSales);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(29, 84);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 125);
            panel1.TabIndex = 109;
            // 
            // lblTotalSales
            // 
            lblTotalSales.AutoSize = true;
            lblTotalSales.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalSales.ForeColor = Color.White;
            lblTotalSales.Location = new Point(50, 79);
            lblTotalSales.Name = "lblTotalSales";
            lblTotalSales.Size = new Size(32, 23);
            lblTotalSales.TabIndex = 105;
            lblTotalSales.Text = "00";
            lblTotalSales.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Tomato;
            panel2.Controls.Add(lblTotalCustomers);
            panel2.Controls.Add(label9);
            panel2.Location = new Point(351, 84);
            panel2.Name = "panel2";
            panel2.Size = new Size(272, 125);
            panel2.TabIndex = 110;
            // 
            // lblTotalCustomers
            // 
            lblTotalCustomers.AutoSize = true;
            lblTotalCustomers.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalCustomers.ForeColor = Color.White;
            lblTotalCustomers.Location = new Point(24, 79);
            lblTotalCustomers.Name = "lblTotalCustomers";
            lblTotalCustomers.Size = new Size(32, 23);
            lblTotalCustomers.TabIndex = 105;
            lblTotalCustomers.Text = "00";
            lblTotalCustomers.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(24, 33);
            label9.Name = "label9";
            label9.Size = new Size(189, 27);
            label9.TabIndex = 104;
            label9.Text = "Total Customers";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Orange;
            panel3.Controls.Add(lblTotalBooks);
            panel3.Controls.Add(label12);
            panel3.Location = new Point(673, 84);
            panel3.Name = "panel3";
            panel3.Size = new Size(261, 125);
            panel3.TabIndex = 111;
            // 
            // lblTotalBooks
            // 
            lblTotalBooks.AutoSize = true;
            lblTotalBooks.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalBooks.ForeColor = Color.White;
            lblTotalBooks.Location = new Point(42, 79);
            lblTotalBooks.Name = "lblTotalBooks";
            lblTotalBooks.Size = new Size(32, 23);
            lblTotalBooks.TabIndex = 105;
            lblTotalBooks.Text = "00";
            lblTotalBooks.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.White;
            label12.Location = new Point(42, 33);
            label12.Name = "label12";
            label12.Size = new Size(137, 27);
            label12.TabIndex = 104;
            label12.Text = "Total Books";
            // 
            // UC_Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label10);
            Controls.Add(dgvLowStockBooks);
            Controls.Add(label6);
            Controls.Add(label1);
            Name = "UC_Admin_Dashboard";
            Size = new Size(988, 580);
            Load += UC_Admin_Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dgvLowStockBooks).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label10;
        private DataGridView dgvLowStockBooks;
        private Label label7;
        private Label label6;
        private Label label1;
        private Panel panel1;
        private Label lblTotalSales;
        private Panel panel2;
        private Label lblTotalCustomers;
        private Label label9;
        private Panel panel3;
        private Label lblTotalBooks;
        private Label label12;
    }
}
