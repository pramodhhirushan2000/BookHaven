namespace BookHaven.User_Controls
{
    partial class UC_Reports
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
            label1 = new Label();
            btn_export_to_pdf = new Button();
            label7 = new Label();
            label2 = new Label();
            label6 = new Label();
            dgvSalesReport = new DataGridView();
            label3 = new Label();
            label4 = new Label();
            lblDailySales = new Label();
            lblMonthlySales = new Label();
            lblWeeklySales = new Label();
            btnDailyReport = new Button();
            btnMonthlyReport = new Button();
            btnWeeklyReport = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(16, 24);
            label1.Name = "label1";
            label1.Size = new Size(114, 34);
            label1.TabIndex = 65;
            label1.Text = "Reports";
            // 
            // btn_export_to_pdf
            // 
            btn_export_to_pdf.BackColor = Color.Navy;
            btn_export_to_pdf.FlatStyle = FlatStyle.Flat;
            btn_export_to_pdf.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_export_to_pdf.ForeColor = Color.White;
            btn_export_to_pdf.Location = new Point(771, 327);
            btn_export_to_pdf.Name = "btn_export_to_pdf";
            btn_export_to_pdf.Size = new Size(201, 37);
            btn_export_to_pdf.TabIndex = 97;
            btn_export_to_pdf.Text = "Export to CSV/PDF";
            btn_export_to_pdf.UseVisualStyleBackColor = false;
            btn_export_to_pdf.Click += btn_export_to_pdf_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(3, 119);
            label7.Name = "label7";
            label7.Size = new Size(157, 23);
            label7.TabIndex = 96;
            label7.Text = "Sales Summary";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(28, 173);
            label2.Name = "label2";
            label2.Size = new Size(131, 23);
            label2.TabIndex = 88;
            label2.Text = "Daily Sales : ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(835, 140);
            label6.Name = "label6";
            label6.Size = new Size(137, 23);
            label6.TabIndex = 101;
            label6.Text = "Sales Report ";
            // 
            // dgvSalesReport
            // 
            dgvSalesReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSalesReport.Location = new Point(533, 166);
            dgvSalesReport.Name = "dgvSalesReport";
            dgvSalesReport.RowHeadersWidth = 51;
            dgvSalesReport.Size = new Size(439, 139);
            dgvSalesReport.TabIndex = 102;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(28, 282);
            label3.Name = "label3";
            label3.Size = new Size(160, 23);
            label3.TabIndex = 105;
            label3.Text = "Monthly Sales : ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(28, 223);
            label4.Name = "label4";
            label4.Size = new Size(152, 23);
            label4.TabIndex = 106;
            label4.Text = "Weekly Sales : ";
            // 
            // lblDailySales
            // 
            lblDailySales.AutoSize = true;
            lblDailySales.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDailySales.ForeColor = Color.Navy;
            lblDailySales.Location = new Point(165, 173);
            lblDailySales.Name = "lblDailySales";
            lblDailySales.Size = new Size(32, 23);
            lblDailySales.TabIndex = 107;
            lblDailySales.Text = "00";
            // 
            // lblMonthlySales
            // 
            lblMonthlySales.AutoSize = true;
            lblMonthlySales.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMonthlySales.ForeColor = Color.Navy;
            lblMonthlySales.Location = new Point(194, 282);
            lblMonthlySales.Name = "lblMonthlySales";
            lblMonthlySales.Size = new Size(32, 23);
            lblMonthlySales.TabIndex = 108;
            lblMonthlySales.Text = "00";
            // 
            // lblWeeklySales
            // 
            lblWeeklySales.AutoSize = true;
            lblWeeklySales.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWeeklySales.ForeColor = Color.Navy;
            lblWeeklySales.Location = new Point(177, 223);
            lblWeeklySales.Name = "lblWeeklySales";
            lblWeeklySales.Size = new Size(32, 23);
            lblWeeklySales.TabIndex = 109;
            lblWeeklySales.Text = "00";
            // 
            // btnDailyReport
            // 
            btnDailyReport.BackColor = Color.Navy;
            btnDailyReport.FlatStyle = FlatStyle.Flat;
            btnDailyReport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDailyReport.ForeColor = Color.White;
            btnDailyReport.Location = new Point(315, 166);
            btnDailyReport.Name = "btnDailyReport";
            btnDailyReport.Size = new Size(200, 37);
            btnDailyReport.TabIndex = 110;
            btnDailyReport.Text = "Daily Sales Report";
            btnDailyReport.UseVisualStyleBackColor = false;
            btnDailyReport.Click += btnDailyReport_Click;
            // 
            // btnMonthlyReport
            // 
            btnMonthlyReport.BackColor = Color.Navy;
            btnMonthlyReport.FlatStyle = FlatStyle.Flat;
            btnMonthlyReport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMonthlyReport.ForeColor = Color.White;
            btnMonthlyReport.Location = new Point(315, 268);
            btnMonthlyReport.Name = "btnMonthlyReport";
            btnMonthlyReport.Size = new Size(200, 37);
            btnMonthlyReport.TabIndex = 111;
            btnMonthlyReport.Text = "Monthly Sales Report";
            btnMonthlyReport.UseVisualStyleBackColor = false;
            btnMonthlyReport.Click += btnMonthlyReport_Click;
            // 
            // btnWeeklyReport
            // 
            btnWeeklyReport.BackColor = Color.Navy;
            btnWeeklyReport.FlatStyle = FlatStyle.Flat;
            btnWeeklyReport.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnWeeklyReport.ForeColor = Color.White;
            btnWeeklyReport.Location = new Point(315, 216);
            btnWeeklyReport.Name = "btnWeeklyReport";
            btnWeeklyReport.Size = new Size(200, 37);
            btnWeeklyReport.TabIndex = 112;
            btnWeeklyReport.Text = "Weekly Sales Report";
            btnWeeklyReport.UseVisualStyleBackColor = false;
            btnWeeklyReport.Click += btnWeeklyReport_Click;
            // 
            // UC_Reports
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(btnWeeklyReport);
            Controls.Add(btnMonthlyReport);
            Controls.Add(btnDailyReport);
            Controls.Add(lblWeeklySales);
            Controls.Add(lblMonthlySales);
            Controls.Add(lblDailySales);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dgvSalesReport);
            Controls.Add(label6);
            Controls.Add(btn_export_to_pdf);
            Controls.Add(label7);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Reports";
            Size = new Size(988, 580);
            Load += UC_Reports_Load;
            ((System.ComponentModel.ISupportInitialize)dgvSalesReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button btn_export_to_pdf;
        private Label label7;
        private Label label2;
        private Label label6;
        private DataGridView dgvSalesReport;
        private Label label3;
        private Label label4;
        private Label lblDailySales;
        private Label lblMonthlySales;
        private Label lblWeeklySales;
        private Button btnDailyReport;
        private Button btnMonthlyReport;
        private Button btnWeeklyReport;
    }
}
