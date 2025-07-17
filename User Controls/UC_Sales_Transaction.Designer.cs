namespace BookHaven.User_Controls
{
    partial class UC_Sales_Transaction
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Sales_Transaction));
            dgvCart = new DataGridView();
            btn_complete_sale = new Button();
            btn_apply_discount = new Button();
            btn_add_to_cart = new Button();
            btn_search = new Button();
            tb_book = new TextBox();
            tb_quantity = new TextBox();
            tb_price = new TextBox();
            tb_title = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label8 = new Label();
            label9 = new Label();
            btn_print_reciept = new Button();
            label7 = new Label();
            lblTotalAmount = new Label();
            lblFinalAmount = new Label();
            tb_discount = new TextBox();
            dgvBooks = new DataGridView();
            tb_cus_id = new TextBox();
            tb_book_id = new TextBox();
            label10 = new Label();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog1 = new PrintPreviewDialog();
            ((System.ComponentModel.ISupportInitialize)dgvCart).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // dgvCart
            // 
            dgvCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCart.Location = new Point(462, 238);
            dgvCart.Name = "dgvCart";
            dgvCart.RowHeadersWidth = 51;
            dgvCart.Size = new Size(523, 189);
            dgvCart.TabIndex = 56;
            // 
            // btn_complete_sale
            // 
            btn_complete_sale.BackColor = Color.Navy;
            btn_complete_sale.FlatStyle = FlatStyle.Flat;
            btn_complete_sale.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_complete_sale.ForeColor = Color.White;
            btn_complete_sale.Location = new Point(89, 462);
            btn_complete_sale.Name = "btn_complete_sale";
            btn_complete_sale.Size = new Size(168, 37);
            btn_complete_sale.TabIndex = 55;
            btn_complete_sale.Text = "Complete Sale";
            btn_complete_sale.UseVisualStyleBackColor = false;
            btn_complete_sale.Click += btn_complete_sale_Click;
            // 
            // btn_apply_discount
            // 
            btn_apply_discount.BackColor = Color.Navy;
            btn_apply_discount.FlatStyle = FlatStyle.Flat;
            btn_apply_discount.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_apply_discount.ForeColor = Color.White;
            btn_apply_discount.Location = new Point(263, 351);
            btn_apply_discount.Name = "btn_apply_discount";
            btn_apply_discount.Size = new Size(175, 37);
            btn_apply_discount.TabIndex = 54;
            btn_apply_discount.Text = "Apply Discount";
            btn_apply_discount.UseVisualStyleBackColor = false;
            btn_apply_discount.Click += btn_apply_discount_Click;
            // 
            // btn_add_to_cart
            // 
            btn_add_to_cart.BackColor = Color.Navy;
            btn_add_to_cart.FlatStyle = FlatStyle.Flat;
            btn_add_to_cart.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_to_cart.ForeColor = Color.White;
            btn_add_to_cart.Location = new Point(299, 260);
            btn_add_to_cart.Name = "btn_add_to_cart";
            btn_add_to_cart.Size = new Size(139, 37);
            btn_add_to_cart.TabIndex = 53;
            btn_add_to_cart.Text = "Add To Cart";
            btn_add_to_cart.UseVisualStyleBackColor = false;
            btn_add_to_cart.Click += btn_add_to_cart_Click;
            // 
            // btn_search
            // 
            btn_search.BackColor = Color.Navy;
            btn_search.FlatStyle = FlatStyle.Flat;
            btn_search.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search.ForeColor = Color.White;
            btn_search.Location = new Point(888, 10);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 37);
            btn_search.TabIndex = 52;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = false;
            btn_search.Click += btn_search_Click;
            // 
            // tb_book
            // 
            tb_book.BorderStyle = BorderStyle.FixedSingle;
            tb_book.Location = new Point(595, 17);
            tb_book.Name = "tb_book";
            tb_book.Size = new Size(287, 27);
            tb_book.TabIndex = 51;
            // 
            // tb_quantity
            // 
            tb_quantity.BorderStyle = BorderStyle.FixedSingle;
            tb_quantity.Location = new Point(151, 227);
            tb_quantity.Name = "tb_quantity";
            tb_quantity.Size = new Size(287, 27);
            tb_quantity.TabIndex = 48;
            // 
            // tb_price
            // 
            tb_price.BorderStyle = BorderStyle.FixedSingle;
            tb_price.Location = new Point(151, 189);
            tb_price.Name = "tb_price";
            tb_price.Size = new Size(287, 27);
            tb_price.TabIndex = 47;
            // 
            // tb_title
            // 
            tb_title.BorderStyle = BorderStyle.FixedSingle;
            tb_title.Location = new Point(151, 143);
            tb_title.Name = "tb_title";
            tb_title.Size = new Size(287, 27);
            tb_title.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(13, 317);
            label6.Name = "label6";
            label6.Size = new Size(152, 23);
            label6.TabIndex = 45;
            label6.Text = "Total Amount :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(835, 212);
            label5.Name = "label5";
            label5.Size = new Size(150, 23);
            label5.TabIndex = 44;
            label5.Text = "Shopping Cart";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(42, 226);
            label4.Name = "label4";
            label4.Size = new Size(93, 23);
            label4.TabIndex = 43;
            label4.Text = "Quantity";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(78, 188);
            label3.Name = "label3";
            label3.Size = new Size(57, 23);
            label3.TabIndex = 42;
            label3.Text = "Price";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(89, 147);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 41;
            label2.Text = "Title";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(14, 13);
            label1.Name = "label1";
            label1.Size = new Size(255, 34);
            label1.TabIndex = 40;
            label1.Text = "Sales Transaction ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Navy;
            label8.Location = new Point(61, 358);
            label8.Name = "label8";
            label8.Size = new Size(110, 23);
            label8.TabIndex = 59;
            label8.Text = "Discount : ";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Navy;
            label9.Location = new Point(16, 404);
            label9.Name = "label9";
            label9.Size = new Size(155, 23);
            label9.TabIndex = 60;
            label9.Text = "Final Amount : ";
            // 
            // btn_print_reciept
            // 
            btn_print_reciept.BackColor = Color.Navy;
            btn_print_reciept.FlatStyle = FlatStyle.Flat;
            btn_print_reciept.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_print_reciept.ForeColor = Color.White;
            btn_print_reciept.Location = new Point(291, 462);
            btn_print_reciept.Name = "btn_print_reciept";
            btn_print_reciept.Size = new Size(147, 37);
            btn_print_reciept.TabIndex = 62;
            btn_print_reciept.Text = "Print Receipt";
            btn_print_reciept.UseVisualStyleBackColor = false;
            btn_print_reciept.Click += btn_print_reciept_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(52, 68);
            label7.Name = "label7";
            label7.Size = new Size(83, 23);
            label7.TabIndex = 63;
            label7.Text = "Book ID";
            // 
            // lblTotalAmount
            // 
            lblTotalAmount.AutoSize = true;
            lblTotalAmount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotalAmount.ForeColor = Color.Navy;
            lblTotalAmount.Location = new Point(171, 317);
            lblTotalAmount.Name = "lblTotalAmount";
            lblTotalAmount.Size = new Size(32, 23);
            lblTotalAmount.TabIndex = 64;
            lblTotalAmount.Text = "00";
            // 
            // lblFinalAmount
            // 
            lblFinalAmount.AutoSize = true;
            lblFinalAmount.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFinalAmount.ForeColor = Color.Navy;
            lblFinalAmount.Location = new Point(171, 404);
            lblFinalAmount.Name = "lblFinalAmount";
            lblFinalAmount.Size = new Size(32, 23);
            lblFinalAmount.TabIndex = 66;
            lblFinalAmount.Text = "00";
            // 
            // tb_discount
            // 
            tb_discount.BorderStyle = BorderStyle.FixedSingle;
            tb_discount.Location = new Point(171, 359);
            tb_discount.Name = "tb_discount";
            tb_discount.Size = new Size(76, 27);
            tb_discount.TabIndex = 67;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(462, 66);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(523, 119);
            dgvBooks.TabIndex = 69;
            // 
            // tb_cus_id
            // 
            tb_cus_id.BorderStyle = BorderStyle.FixedSingle;
            tb_cus_id.Location = new Point(151, 110);
            tb_cus_id.Name = "tb_cus_id";
            tb_cus_id.Size = new Size(287, 27);
            tb_cus_id.TabIndex = 70;
            // 
            // tb_book_id
            // 
            tb_book_id.BorderStyle = BorderStyle.FixedSingle;
            tb_book_id.Location = new Point(151, 68);
            tb_book_id.Name = "tb_book_id";
            tb_book_id.Size = new Size(287, 27);
            tb_book_id.TabIndex = 71;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Navy;
            label10.Location = new Point(5, 110);
            label10.Name = "label10";
            label10.Size = new Size(130, 23);
            label10.TabIndex = 72;
            label10.Text = "Customer ID";
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // UC_Sales_Transaction
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(label10);
            Controls.Add(tb_book_id);
            Controls.Add(tb_cus_id);
            Controls.Add(dgvBooks);
            Controls.Add(tb_discount);
            Controls.Add(lblFinalAmount);
            Controls.Add(lblTotalAmount);
            Controls.Add(label7);
            Controls.Add(btn_print_reciept);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(dgvCart);
            Controls.Add(btn_complete_sale);
            Controls.Add(btn_apply_discount);
            Controls.Add(btn_add_to_cart);
            Controls.Add(btn_search);
            Controls.Add(tb_book);
            Controls.Add(tb_quantity);
            Controls.Add(tb_price);
            Controls.Add(tb_title);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Sales_Transaction";
            Size = new Size(988, 580);
            ((System.ComponentModel.ISupportInitialize)dgvCart).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvCart;
        private Button btn_complete_sale;
        private Button btn_apply_discount;
        private Button btn_add_to_cart;
        private Button btn_search;
        private TextBox tb_book;
        private TextBox tb_quantity;
        private TextBox tb_price;
        private TextBox tb_title;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label8;
        private Label label9;
        private Button btn_print_reciept;
        private Label label7;
        private Label lblTotalAmount;
        private Label lblFinalAmount;
        private TextBox tb_discount;
        private DataGridView dgvBooks;
        private TextBox tb_cus_id;
        private TextBox tb_book_id;
        private Label label10;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintPreviewDialog printPreviewDialog1;
    }
}
