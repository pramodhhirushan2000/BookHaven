using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace BookHaven.User_Controls
{
    public partial class UC_Admin_Dashboard : UserControl
    {
        public UC_Admin_Dashboard()
        {
            InitializeComponent();
        }

        private void LoadDashboardStats()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open();

                    // Load Total Sales (Last 30 Days)
                    string salesQuery = "SELECT SUM(TotalAmount) FROM Sales WHERE SaleDate >= DATEADD(DAY, -30, GETDATE())";
                    SqlCommand salesCmd = new SqlCommand(salesQuery, conn);
                    object salesResult = salesCmd.ExecuteScalar();
                    decimal totalSales = (salesResult != DBNull.Value && salesResult != null) ? Convert.ToDecimal(salesResult) : 0;

                    // Load Total Customers
                    string customersQuery = "SELECT COUNT(*) FROM Customers";
                    SqlCommand customersCmd = new SqlCommand(customersQuery, conn);
                    int totalCustomers = Convert.ToInt32(customersCmd.ExecuteScalar());

                    // Load Total Books
                    string booksQuery = "SELECT COUNT(*) FROM Books";
                    SqlCommand booksCmd = new SqlCommand(booksQuery, conn);
                    int totalBooks = Convert.ToInt32(booksCmd.ExecuteScalar());



                    // Update UI Labels Safely
                    if (lblTotalSales.InvokeRequired)
                    {
                        lblTotalSales.Invoke(new Action(() => lblTotalSales.Text = $"Total Sales (Last 30 Days): {totalSales:C}"));
                        lblTotalCustomers.Invoke(new Action(() => lblTotalCustomers.Text = $"Total Customers: {totalCustomers}"));
                        lblTotalBooks.Invoke(new Action(() => lblTotalBooks.Text = $"Total Books: {totalBooks}"));

                    }
                    else
                    {
                        lblTotalSales.Text = $"{totalSales:C}";
                        lblTotalCustomers.Text = $"{totalCustomers}";
                        lblTotalBooks.Text = $"{totalBooks}";

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading dashboard stats: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadLowStockBooks()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    conn.Open(); // Open the connection

                    string query = @"
                SELECT B.Title AS 'Book Title', I.StockQuantity AS 'Stock' 
                FROM Books I 
                JOIN Books B ON I.BookID = B.BookID 
                WHERE I.StockQuantity < 5";

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    // Update DataGridView safely
                    if (dgvLowStockBooks.InvokeRequired)
                    {
                        dgvLowStockBooks.Invoke(new Action(() =>
                        {
                            dgvLowStockBooks.DataSource = dt;
                            dgvLowStockBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        }));
                    }
                    else
                    {
                        dgvLowStockBooks.DataSource = dt;
                        dgvLowStockBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }

                    // Show message only if no low-stock books exist
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("No books are low in stock.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading low stock books: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void UC_Admin_Dashboard_Load(object sender, EventArgs e)
        {
            LoadDashboardStats();
            LoadLowStockBooks();
        }

        private void btn_manage_users_Click(object sender, EventArgs e)
        {

        }
    }
}
