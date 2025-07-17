using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookHaven.User_Controls
{
    public partial class UC_Inventory_Management : UserControl
    {
        public UC_Inventory_Management()
        {
            InitializeComponent();
            LoadBooks(); // Load books when the control is initialized
        }

        private void btn_add_books_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tb_book_title.Text;
                string author = tb_book_author.Text;
                string genre = tb_book_genre.Text;
                string isbn = tb_book_isbn.Text;
                decimal price = Convert.ToDecimal(tb_book_price.Text);
                int stock = Convert.ToInt32(tb_book_stock.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "INSERT INTO Books (Title, Author, Genre, ISBN, Price, StockQuantity) " +
                                   "VALUES (@Title, @Author, @Genre, @ISBN, @Price, @StockQuantity)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@StockQuantity", stock);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book added successfully!");
                    LoadBooks(); // Refresh book list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        void LoadBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "SELECT * FROM Books";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvBooks.DataSource = null; // Reset before updating
                    dgvBooks.DataSource = dt;
                    dgvBooks.Refresh(); // Ensure UI update
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void btn_update_books_Click(object sender, EventArgs e)
        {
            try
            {
                string title = tb_book_title.Text;
                string author = tb_book_author.Text;
                string genre = tb_book_genre.Text;
                string isbn = tb_book_isbn.Text;
                decimal price = Convert.ToDecimal(tb_book_price.Text);
                int stock = Convert.ToInt32(tb_book_stock.Text);

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "UPDATE Books SET Title=@Title, Author=@Author, Genre=@Genre, " +
                                   "Price=@Price, StockQuantity=@StockQuantity WHERE ISBN=@ISBN";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Title", title);
                    cmd.Parameters.AddWithValue("@Author", author);
                    cmd.Parameters.AddWithValue("@Genre", genre);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);
                    cmd.Parameters.AddWithValue("@Price", price);
                    cmd.Parameters.AddWithValue("@StockQuantity", stock);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book updated successfully!");
                    LoadBooks(); // Refresh book list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating book: " + ex.Message);
            }
        }

        private void btn_delete_books_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvBooks.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a book to delete.");
                    return;
                }

                int bookID = Convert.ToInt32(dgvBooks.SelectedRows[0].Cells["BookID"].Value);

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "DELETE FROM Books WHERE BookID=@BookID";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@BookID", bookID);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Book deleted successfully!");
                    LoadBooks(); // Refresh book list
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting book: " + ex.Message);
            }
        }


        private void btn_search__books_Click(object sender, EventArgs e)
        {
            try
            {
                string isbn = tb_book_isbn.Text.Trim();

                if (string.IsNullOrEmpty(isbn))
                {
                    MessageBox.Show("Please enter an ISBN to search.");
                    return;
                }

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "SELECT Title, Author, Genre, Price, StockQuantity FROM Books WHERE ISBN = @ISBN";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@ISBN", isbn);

                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read()) // If a book is found
                    {
                        tb_book_title.Text = reader["Title"].ToString();
                        tb_book_author.Text = reader["Author"].ToString();
                        tb_book_genre.Text = reader["Genre"].ToString();
                        tb_book_isbn.Text = isbn; // ISBN remains the same
                        tb_book_price.Text = reader["Price"].ToString();
                        tb_book_stock.Text = reader["StockQuantity"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Book not found!");
                    }
                    reader.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error searching book: " + ex.Message);
            }
        }
    }
}
