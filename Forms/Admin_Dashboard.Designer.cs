namespace BookHaven.Forms
{
    partial class Admin_Dashboard
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Dashboard));
            panelLeft = new Panel();
            btn_report = new Button();
            btn_supply_manage = new Button();
            btn_order_manage = new Button();
            btn_sale_pos = new Button();
            btn_cus_manage = new Button();
            btn_inventory = new Button();
            panelSide = new Panel();
            btn_dashboard = new Button();
            panel2 = new Panel();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            btn_logout = new Button();
            label1 = new Label();
            panel4 = new Panel();
            labelTime = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            panelControls = new Panel();
            timer2 = new System.Windows.Forms.Timer(components);
            panelLeft.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.Navy;
            panelLeft.Controls.Add(btn_report);
            panelLeft.Controls.Add(btn_supply_manage);
            panelLeft.Controls.Add(btn_order_manage);
            panelLeft.Controls.Add(btn_sale_pos);
            panelLeft.Controls.Add(btn_cus_manage);
            panelLeft.Controls.Add(btn_inventory);
            panelLeft.Controls.Add(panelSide);
            panelLeft.Controls.Add(btn_dashboard);
            panelLeft.Controls.Add(panel2);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(212, 720);
            panelLeft.TabIndex = 0;
            // 
            // btn_report
            // 
            btn_report.FlatAppearance.BorderSize = 0;
            btn_report.FlatStyle = FlatStyle.Flat;
            btn_report.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_report.ForeColor = Color.White;
            btn_report.Image = (Image)resources.GetObject("btn_report.Image");
            btn_report.ImageAlign = ContentAlignment.MiddleLeft;
            btn_report.Location = new Point(12, 562);
            btn_report.Name = "btn_report";
            btn_report.Size = new Size(200, 60);
            btn_report.TabIndex = 9;
            btn_report.Text = "Reports";
            btn_report.TextAlign = ContentAlignment.MiddleRight;
            btn_report.UseVisualStyleBackColor = true;
            btn_report.Click += btn_report_Click;
            // 
            // btn_supply_manage
            // 
            btn_supply_manage.FlatAppearance.BorderSize = 0;
            btn_supply_manage.FlatStyle = FlatStyle.Flat;
            btn_supply_manage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_supply_manage.ForeColor = Color.White;
            btn_supply_manage.Image = (Image)resources.GetObject("btn_supply_manage.Image");
            btn_supply_manage.ImageAlign = ContentAlignment.MiddleLeft;
            btn_supply_manage.Location = new Point(15, 496);
            btn_supply_manage.Name = "btn_supply_manage";
            btn_supply_manage.Size = new Size(200, 60);
            btn_supply_manage.TabIndex = 8;
            btn_supply_manage.Text = "Supplier Management ";
            btn_supply_manage.TextAlign = ContentAlignment.MiddleRight;
            btn_supply_manage.UseVisualStyleBackColor = true;
            btn_supply_manage.Click += btn_supply_manage_Click;
            // 
            // btn_order_manage
            // 
            btn_order_manage.FlatAppearance.BorderSize = 0;
            btn_order_manage.FlatStyle = FlatStyle.Flat;
            btn_order_manage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_manage.ForeColor = Color.White;
            btn_order_manage.Image = (Image)resources.GetObject("btn_order_manage.Image");
            btn_order_manage.ImageAlign = ContentAlignment.MiddleLeft;
            btn_order_manage.Location = new Point(15, 430);
            btn_order_manage.Name = "btn_order_manage";
            btn_order_manage.Size = new Size(200, 60);
            btn_order_manage.TabIndex = 7;
            btn_order_manage.Text = "Order Management ";
            btn_order_manage.TextAlign = ContentAlignment.MiddleRight;
            btn_order_manage.UseVisualStyleBackColor = true;
            btn_order_manage.Click += btn_order_manage_Click;
            // 
            // btn_sale_pos
            // 
            btn_sale_pos.FlatAppearance.BorderSize = 0;
            btn_sale_pos.FlatStyle = FlatStyle.Flat;
            btn_sale_pos.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_sale_pos.ForeColor = Color.White;
            btn_sale_pos.Image = (Image)resources.GetObject("btn_sale_pos.Image");
            btn_sale_pos.ImageAlign = ContentAlignment.MiddleLeft;
            btn_sale_pos.Location = new Point(12, 364);
            btn_sale_pos.Name = "btn_sale_pos";
            btn_sale_pos.Size = new Size(200, 60);
            btn_sale_pos.TabIndex = 6;
            btn_sale_pos.Text = "Sales POS ";
            btn_sale_pos.TextAlign = ContentAlignment.MiddleRight;
            btn_sale_pos.UseVisualStyleBackColor = true;
            btn_sale_pos.Click += btn_sale_pos_Click;
            // 
            // btn_cus_manage
            // 
            btn_cus_manage.FlatAppearance.BorderSize = 0;
            btn_cus_manage.FlatStyle = FlatStyle.Flat;
            btn_cus_manage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_cus_manage.ForeColor = Color.White;
            btn_cus_manage.Image = (Image)resources.GetObject("btn_cus_manage.Image");
            btn_cus_manage.ImageAlign = ContentAlignment.MiddleLeft;
            btn_cus_manage.Location = new Point(12, 298);
            btn_cus_manage.Name = "btn_cus_manage";
            btn_cus_manage.Size = new Size(200, 60);
            btn_cus_manage.TabIndex = 5;
            btn_cus_manage.Text = "Customer Management ";
            btn_cus_manage.TextAlign = ContentAlignment.MiddleRight;
            btn_cus_manage.UseVisualStyleBackColor = true;
            btn_cus_manage.Click += btn_cus_manage_Click;
            // 
            // btn_inventory
            // 
            btn_inventory.FlatAppearance.BorderSize = 0;
            btn_inventory.FlatStyle = FlatStyle.Flat;
            btn_inventory.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_inventory.ForeColor = Color.White;
            btn_inventory.Image = (Image)resources.GetObject("btn_inventory.Image");
            btn_inventory.ImageAlign = ContentAlignment.MiddleLeft;
            btn_inventory.Location = new Point(12, 232);
            btn_inventory.Name = "btn_inventory";
            btn_inventory.Size = new Size(203, 60);
            btn_inventory.TabIndex = 4;
            btn_inventory.Text = "Inventory Management ";
            btn_inventory.TextAlign = ContentAlignment.MiddleRight;
            btn_inventory.UseVisualStyleBackColor = true;
            btn_inventory.Click += btn_inventory_Click;
            // 
            // panelSide
            // 
            panelSide.BackColor = Color.White;
            panelSide.Location = new Point(3, 166);
            panelSide.Name = "panelSide";
            panelSide.Size = new Size(10, 60);
            panelSide.TabIndex = 3;
            // 
            // btn_dashboard
            // 
            btn_dashboard.FlatAppearance.BorderSize = 0;
            btn_dashboard.FlatStyle = FlatStyle.Flat;
            btn_dashboard.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_dashboard.ForeColor = Color.White;
            btn_dashboard.Image = (Image)resources.GetObject("btn_dashboard.Image");
            btn_dashboard.ImageAlign = ContentAlignment.MiddleLeft;
            btn_dashboard.Location = new Point(12, 166);
            btn_dashboard.Name = "btn_dashboard";
            btn_dashboard.Size = new Size(200, 60);
            btn_dashboard.TabIndex = 3;
            btn_dashboard.Text = "Dashboard";
            btn_dashboard.TextAlign = ContentAlignment.MiddleRight;
            btn_dashboard.UseVisualStyleBackColor = true;
            btn_dashboard.Click += btn_dashboard_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(button10);
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(212, 140);
            panel2.TabIndex = 1;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(162, 4);
            button10.Name = "button10";
            button10.Size = new Size(44, 41);
            button10.TabIndex = 4;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_logout);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(212, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(988, 45);
            panel3.TabIndex = 1;
            // 
            // btn_logout
            // 
            btn_logout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btn_logout.FlatAppearance.BorderSize = 0;
            btn_logout.FlatStyle = FlatStyle.Flat;
            btn_logout.Image = (Image)resources.GetObject("btn_logout.Image");
            btn_logout.Location = new Point(934, 0);
            btn_logout.Name = "btn_logout";
            btn_logout.Size = new Size(48, 45);
            btn_logout.TabIndex = 3;
            btn_logout.UseVisualStyleBackColor = true;
            btn_logout.Click += btn_logout_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(6, 9);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 3;
            label1.Text = "Book Haven - Books Store";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Navy;
            panel4.Controls.Add(labelTime);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(212, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(988, 95);
            panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(861, 46);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(112, 28);
            labelTime.TabIndex = 8;
            labelTime.Text = "HH:MM:SS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(178, 46);
            label5.Name = "label5";
            label5.Size = new Size(74, 28);
            label5.TabIndex = 7;
            label5.Text = "Admin";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(113, 46);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 6;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(178, 18);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 5;
            label3.Text = "Pramodh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(73, 18);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 4;
            label2.Text = "Welcome";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // panelControls
            // 
            panelControls.Dock = DockStyle.Fill;
            panelControls.Location = new Point(212, 140);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(988, 580);
            panelControls.TabIndex = 3;
            // 
            // timer2
            // 
            timer2.Tick += timer2_Tick;
            // 
            // Admin_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panelControls);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Dashboard";
            Text = "Admin_Dashboard";
            panelLeft.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Button btn_dashboard;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panelSide;
        private PictureBox pictureBox1;
        private Button btn_sale_pos;
        private Button btn_cus_manage;
        private Button btn_inventory;
        private Button btn_report;
        private Button btn_supply_manage;
        private Button btn_order_manage;
        private Label label1;
        private Button btn_logout;
        private Button button10;
        private Label labelTime;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Panel panelControls;
        private System.Windows.Forms.Timer timer2;
    }
}