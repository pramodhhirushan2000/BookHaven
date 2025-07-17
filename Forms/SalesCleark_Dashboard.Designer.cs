namespace BookHaven.Forms
{
    partial class SalesCleark_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesCleark_Dashboard));
            panel1 = new Panel();
            panelSide2 = new Panel();
            btn_order_manage = new Button();
            btn_sale_pos = new Button();
            btn_cus_manage = new Button();
            panelLeft2 = new Panel();
            button10 = new Button();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            button9 = new Button();
            label1 = new Label();
            panel4 = new Panel();
            labelTime = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            timerTime = new System.Windows.Forms.Timer(components);
            panel2Controls = new Panel();
            panel1.SuspendLayout();
            panelLeft2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(panelSide2);
            panel1.Controls.Add(btn_order_manage);
            panel1.Controls.Add(btn_sale_pos);
            panel1.Controls.Add(btn_cus_manage);
            panel1.Controls.Add(panelLeft2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(215, 720);
            panel1.TabIndex = 0;
            // 
            // panelSide2
            // 
            panelSide2.BackColor = Color.White;
            panelSide2.Location = new Point(3, 169);
            panelSide2.Name = "panelSide2";
            panelSide2.Size = new Size(10, 60);
            panelSide2.TabIndex = 4;
            // 
            // btn_order_manage
            // 
            btn_order_manage.FlatAppearance.BorderSize = 0;
            btn_order_manage.FlatStyle = FlatStyle.Flat;
            btn_order_manage.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_order_manage.ForeColor = Color.White;
            btn_order_manage.Image = (Image)resources.GetObject("btn_order_manage.Image");
            btn_order_manage.ImageAlign = ContentAlignment.MiddleLeft;
            btn_order_manage.Location = new Point(18, 301);
            btn_order_manage.Name = "btn_order_manage";
            btn_order_manage.Size = new Size(200, 60);
            btn_order_manage.TabIndex = 10;
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
            btn_sale_pos.Location = new Point(15, 235);
            btn_sale_pos.Name = "btn_sale_pos";
            btn_sale_pos.Size = new Size(200, 60);
            btn_sale_pos.TabIndex = 9;
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
            btn_cus_manage.Location = new Point(15, 169);
            btn_cus_manage.Name = "btn_cus_manage";
            btn_cus_manage.Size = new Size(200, 60);
            btn_cus_manage.TabIndex = 8;
            btn_cus_manage.Text = "Customer Management ";
            btn_cus_manage.TextAlign = ContentAlignment.MiddleRight;
            btn_cus_manage.UseVisualStyleBackColor = true;
            btn_cus_manage.Click += btn_cus_manage_Click;
            // 
            // panelLeft2
            // 
            panelLeft2.BackColor = Color.White;
            panelLeft2.Controls.Add(button10);
            panelLeft2.Controls.Add(pictureBox1);
            panelLeft2.Dock = DockStyle.Top;
            panelLeft2.Location = new Point(0, 0);
            panelLeft2.Name = "panelLeft2";
            panelLeft2.Size = new Size(215, 140);
            panelLeft2.TabIndex = 1;
            // 
            // button10
            // 
            button10.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.Location = new Point(165, 4);
            button10.Name = "button10";
            button10.Size = new Size(44, 41);
            button10.TabIndex = 6;
            button10.UseVisualStyleBackColor = true;
            button10.Click += button10_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(37, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(132, 125);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(button9);
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(215, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(985, 45);
            panel3.TabIndex = 1;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.Location = new Point(934, 0);
            button9.Name = "button9";
            button9.Size = new Size(48, 45);
            button9.TabIndex = 5;
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(21, 12);
            label1.Name = "label1";
            label1.Size = new Size(259, 28);
            label1.TabIndex = 4;
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
            panel4.Location = new Point(215, 45);
            panel4.Name = "panel4";
            panel4.Size = new Size(985, 95);
            panel4.TabIndex = 2;
            // 
            // labelTime
            // 
            labelTime.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelTime.AutoSize = true;
            labelTime.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTime.ForeColor = Color.White;
            labelTime.Location = new Point(861, 54);
            labelTime.Name = "labelTime";
            labelTime.Size = new Size(112, 28);
            labelTime.TabIndex = 12;
            labelTime.Text = "HH:MM:SS";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(183, 40);
            label5.Name = "label5";
            label5.Size = new Size(125, 28);
            label5.TabIndex = 11;
            label5.Text = "Sales Cleark";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(118, 40);
            label4.Name = "label4";
            label4.Size = new Size(59, 28);
            label4.TabIndex = 10;
            label4.Text = "Role:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(183, 12);
            label3.Name = "label3";
            label3.Size = new Size(97, 28);
            label3.TabIndex = 9;
            label3.Text = "Hirushan";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(78, 12);
            label2.Name = "label2";
            label2.Size = new Size(99, 28);
            label2.TabIndex = 8;
            label2.Text = "Welcome";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // timerTime
            // 
            timerTime.Tick += timerTime_Tick;
            // 
            // panel2Controls
            // 
            panel2Controls.Dock = DockStyle.Fill;
            panel2Controls.Location = new Point(215, 140);
            panel2Controls.Name = "panel2Controls";
            panel2Controls.Size = new Size(985, 580);
            panel2Controls.TabIndex = 3;
            // 
            // SalesCleark_Dashboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(panel2Controls);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SalesCleark_Dashboard";
            Text = "SalesCleark_Dashboard";
            panel1.ResumeLayout(false);
            panelLeft2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panelLeft2;
        private Panel panel3;
        private Panel panel4;
        private Button button10;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btn_order_manage;
        private Button btn_sale_pos;
        private Button btn_cus_manage;
        private Panel panelSide2;
        private Button button9;
        private System.Windows.Forms.Timer timer1;
        private Label labelTime;
        private System.Windows.Forms.Timer timerTime;
        private Panel panel2Controls;
    }
}