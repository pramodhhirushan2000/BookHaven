namespace BookHaven.Forms
{
    partial class LoadForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoadForm));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label1 = new Label();
            panel3 = new Panel();
            timer1 = new System.Windows.Forms.Timer(components);
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(198, 97);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(349, 283);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(513, 383);
            label2.Name = "label2";
            label2.Size = new Size(287, 28);
            label2.TabIndex = 3;
            label2.Text = "Created By Pramodh Hirushan";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(12, 383);
            label3.Name = "label3";
            label3.Size = new Size(126, 27);
            label3.TabIndex = 4;
            label3.Text = "Loading....";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Navy;
            label1.Font = new Font("Century Gothic", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(23, 9);
            label1.Name = "label1";
            label1.Size = new Size(756, 56);
            label1.TabIndex = 1;
            label1.Text = "Bookstore Management System ";
            // 
            // panel3
            // 
            panel3.BackColor = Color.Navy;
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(800, 91);
            panel3.TabIndex = 5;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // progressBar1
            // 
            progressBar1.ForeColor = Color.Navy;
            progressBar1.Location = new Point(12, 414);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(776, 17);
            progressBar1.TabIndex = 6;
            // 
            // LoadForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(panel3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoadForm";
            Text = "Loading";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label1;
        private Panel panel3;
        private System.Windows.Forms.Timer timer1;
        private ProgressBar progressBar1;
    }
}