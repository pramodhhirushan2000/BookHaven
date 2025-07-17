namespace BookHaven.User_Controls
{
    partial class UC_Inventory_Management
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            tb_book_title = new TextBox();
            tb_book_author = new TextBox();
            tb_book_genre = new TextBox();
            tb_book_isbn = new TextBox();
            tb_book_price = new TextBox();
            tb_book_stock = new TextBox();
            btn_search__books = new Button();
            btn_add_books = new Button();
            btn_update_books = new Button();
            btn_delete_books = new Button();
            dgvBooks = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvBooks).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(17, 17);
            label1.Name = "label1";
            label1.Size = new Size(417, 34);
            label1.TabIndex = 0;
            label1.Text = "Book Inventory Management ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Navy;
            label2.Location = new Point(82, 124);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 1;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Navy;
            label3.Location = new Point(53, 165);
            label3.Name = "label3";
            label3.Size = new Size(75, 23);
            label3.TabIndex = 2;
            label3.Text = "Author";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Navy;
            label4.Location = new Point(57, 203);
            label4.Name = "label4";
            label4.Size = new Size(71, 23);
            label4.TabIndex = 3;
            label4.Text = "Genre";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Navy;
            label5.Location = new Point(77, 80);
            label5.Name = "label5";
            label5.Size = new Size(51, 23);
            label5.TabIndex = 4;
            label5.Text = "ISBN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Navy;
            label6.Location = new Point(71, 252);
            label6.Name = "label6";
            label6.Size = new Size(57, 23);
            label6.TabIndex = 5;
            label6.Text = "Price";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Century Gothic", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Navy;
            label7.Location = new Point(65, 291);
            label7.Name = "label7";
            label7.Size = new Size(63, 23);
            label7.TabIndex = 6;
            label7.Text = "Stock";
            // 
            // tb_book_title
            // 
            tb_book_title.BorderStyle = BorderStyle.FixedSingle;
            tb_book_title.Location = new Point(134, 120);
            tb_book_title.Name = "tb_book_title";
            tb_book_title.Size = new Size(287, 27);
            tb_book_title.TabIndex = 7;
            // 
            // tb_book_author
            // 
            tb_book_author.BorderStyle = BorderStyle.FixedSingle;
            tb_book_author.Location = new Point(134, 166);
            tb_book_author.Name = "tb_book_author";
            tb_book_author.Size = new Size(287, 27);
            tb_book_author.TabIndex = 8;
            // 
            // tb_book_genre
            // 
            tb_book_genre.BorderStyle = BorderStyle.FixedSingle;
            tb_book_genre.Location = new Point(134, 204);
            tb_book_genre.Name = "tb_book_genre";
            tb_book_genre.Size = new Size(287, 27);
            tb_book_genre.TabIndex = 9;
            // 
            // tb_book_isbn
            // 
            tb_book_isbn.BorderStyle = BorderStyle.FixedSingle;
            tb_book_isbn.Location = new Point(134, 76);
            tb_book_isbn.Name = "tb_book_isbn";
            tb_book_isbn.Size = new Size(287, 27);
            tb_book_isbn.TabIndex = 10;
            // 
            // tb_book_price
            // 
            tb_book_price.BorderStyle = BorderStyle.FixedSingle;
            tb_book_price.Location = new Point(134, 248);
            tb_book_price.Name = "tb_book_price";
            tb_book_price.Size = new Size(287, 27);
            tb_book_price.TabIndex = 11;
            // 
            // tb_book_stock
            // 
            tb_book_stock.BorderStyle = BorderStyle.FixedSingle;
            tb_book_stock.Location = new Point(134, 287);
            tb_book_stock.Name = "tb_book_stock";
            tb_book_stock.Size = new Size(287, 27);
            tb_book_stock.TabIndex = 12;
            // 
            // btn_search__books
            // 
            btn_search__books.BackColor = Color.Navy;
            btn_search__books.FlatStyle = FlatStyle.Flat;
            btn_search__books.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_search__books.ForeColor = Color.White;
            btn_search__books.Location = new Point(427, 72);
            btn_search__books.Name = "btn_search__books";
            btn_search__books.Size = new Size(94, 37);
            btn_search__books.TabIndex = 14;
            btn_search__books.Text = "Search";
            btn_search__books.UseVisualStyleBackColor = false;
            btn_search__books.Click += btn_search__books_Click;
            // 
            // btn_add_books
            // 
            btn_add_books.BackColor = Color.Navy;
            btn_add_books.FlatStyle = FlatStyle.Flat;
            btn_add_books.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_add_books.ForeColor = Color.White;
            btn_add_books.Location = new Point(109, 357);
            btn_add_books.Name = "btn_add_books";
            btn_add_books.Size = new Size(94, 37);
            btn_add_books.TabIndex = 15;
            btn_add_books.Text = "Add";
            btn_add_books.UseVisualStyleBackColor = false;
            btn_add_books.Click += btn_add_books_Click;
            // 
            // btn_update_books
            // 
            btn_update_books.BackColor = Color.Navy;
            btn_update_books.FlatStyle = FlatStyle.Flat;
            btn_update_books.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_update_books.ForeColor = Color.White;
            btn_update_books.Location = new Point(235, 357);
            btn_update_books.Name = "btn_update_books";
            btn_update_books.Size = new Size(94, 37);
            btn_update_books.TabIndex = 16;
            btn_update_books.Text = "Update";
            btn_update_books.UseVisualStyleBackColor = false;
            btn_update_books.Click += btn_update_books_Click;
            // 
            // btn_delete_books
            // 
            btn_delete_books.BackColor = Color.Navy;
            btn_delete_books.FlatStyle = FlatStyle.Flat;
            btn_delete_books.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_delete_books.ForeColor = Color.White;
            btn_delete_books.Location = new Point(354, 357);
            btn_delete_books.Name = "btn_delete_books";
            btn_delete_books.Size = new Size(94, 37);
            btn_delete_books.TabIndex = 17;
            btn_delete_books.Text = "Delete";
            btn_delete_books.UseVisualStyleBackColor = false;
            btn_delete_books.Click += btn_delete_books_Click;
            // 
            // dgvBooks
            // 
            dgvBooks.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBooks.Location = new Point(478, 148);
            dgvBooks.Name = "dgvBooks";
            dgvBooks.RowHeadersWidth = 51;
            dgvBooks.Size = new Size(486, 227);
            dgvBooks.TabIndex = 18;
            // 
            // UC_Inventory_Management
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            Controls.Add(dgvBooks);
            Controls.Add(btn_delete_books);
            Controls.Add(btn_update_books);
            Controls.Add(btn_add_books);
            Controls.Add(btn_search__books);
            Controls.Add(tb_book_stock);
            Controls.Add(tb_book_price);
            Controls.Add(tb_book_isbn);
            Controls.Add(tb_book_genre);
            Controls.Add(tb_book_author);
            Controls.Add(tb_book_title);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Inventory_Management";
            Size = new Size(988, 580);
            ((System.ComponentModel.ISupportInitialize)dgvBooks).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox tb_book_title;
        private TextBox tb_book_author;
        private TextBox tb_book_genre;
        private TextBox tb_book_isbn;
        private TextBox tb_book_price;
        private TextBox tb_book_stock;
        private Button btn_search__books;
        private Button btn_add_books;
        private Button btn_update_books;
        private Button btn_delete_books;
        private DataGridView dgvBooks;
    }
}
