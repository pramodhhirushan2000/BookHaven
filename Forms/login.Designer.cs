namespace BookHaven
{
    partial class login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            panel1 = new Panel();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            tb_uername = new TextBox();
            tb_password = new TextBox();
            label4 = new Label();
            btn_login = new Button();
            pictureBox2 = new PictureBox();
            label5 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Navy;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1200, 56);
            panel1.TabIndex = 0;
            // 
            // button2
            // 
            button2.BackColor = Color.Navy;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1134, 1);
            button2.Name = "button2";
            button2.Size = new Size(63, 52);
            button2.TabIndex = 9;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(172, 56);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(668, 256);
            label1.Name = "label1";
            label1.Size = new Size(108, 23);
            label1.TabIndex = 1;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.White;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(667, 323);
            label2.Name = "label2";
            label2.Size = new Size(103, 23);
            label2.TabIndex = 2;
            label2.Text = "Password";
            // 
            // tb_uername
            // 
            tb_uername.BorderStyle = BorderStyle.FixedSingle;
            tb_uername.Location = new Point(668, 282);
            tb_uername.Name = "tb_uername";
            tb_uername.Size = new Size(408, 27);
            tb_uername.TabIndex = 4;
            // 
            // tb_password
            // 
            tb_password.BorderStyle = BorderStyle.FixedSingle;
            tb_password.Location = new Point(668, 348);
            tb_password.Name = "tb_password";
            tb_password.PasswordChar = '*';
            tb_password.Size = new Size(408, 27);
            tb_password.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.White;
            label4.Font = new Font("Century Gothic", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(788, 155);
            label4.Name = "label4";
            label4.Size = new Size(217, 70);
            label4.TabIndex = 7;
            label4.Text = "LOGIN";
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.Navy;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(668, 423);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(409, 52);
            btn_login.TabIndex = 8;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            btn_login.Click += btn_login_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(28, 110);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(542, 508);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.White;
            label5.Font = new Font("Century Gothic", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(923, 378);
            label5.Name = "label5";
            label5.Size = new Size(153, 22);
            label5.TabIndex = 10;
            label5.Text = "Forgot Password";
            // 
            // login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 720);
            Controls.Add(label5);
            Controls.Add(pictureBox2);
            Controls.Add(btn_login);
            Controls.Add(label4);
            Controls.Add(tb_password);
            Controls.Add(tb_uername);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "login";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private TextBox tb_uername;
        private Button button2;
        private PictureBox pictureBox1;
        private TextBox tb_password;
        private Label label4;
        private Button btn_login;
        private PictureBox pictureBox2;
        private Label label5;
    }
}
