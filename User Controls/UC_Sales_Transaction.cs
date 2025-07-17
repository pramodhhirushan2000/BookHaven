using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Data.SqlClient;
using System.Drawing.Printing;

namespace BookHaven.User_Controls
{
    public partial class UC_Sales_Transaction : UserControl
    {

        public UC_Sales_Transaction()
        {
            InitializeComponent();

        }
        private string receiptToPrint = "";
        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void btn_add_to_cart_Click(object sender, EventArgs e)
        {
            int bookID = Convert.ToInt32(tb_book_id.Text);
            string title = tb_title.Text;
            int quantity = Convert.ToInt32(tb_quantity.Text);
            decimal price = Convert.ToDecimal(tb_price.Text);
            decimal total = quantity * price;

            // Ensure DataGridView has columns
            if (dgvCart.Columns.Count == 0)
            {
                dgvCart.Columns.Add("BookID", "BookID");
                dgvCart.Columns.Add("Title", "Title");
                dgvCart.Columns.Add("Quantity", "Quantity");
                dgvCart.Columns.Add("Price", "Price");
                dgvCart.Columns.Add("Total", "Total");
            }

            // Add book details to DataGridView (Cart)
            dgvCart.Rows.Add(bookID, title, quantity, price, total);

            CalculateTotal(); // Update total amount
        }
        private void CalculateTotal()
        {
            decimal total = 0;
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.Cells["Total"].Value != null && decimal.TryParse(row.Cells["Total"].Value.ToString(), out decimal rowTotal))
                {
                    total += rowTotal;
                }
            }
            lblTotalAmount.Text = total.ToString("C2"); // Display total in currency format
        }

        private void btn_apply_discount_Click(object sender, EventArgs e)
        {
            decimal discount = Convert.ToDecimal(tb_discount.Text);
            decimal totalAmount = Convert.ToDecimal(lblTotalAmount.Text.Trim('$'));
            decimal finalAmount = totalAmount - discount;

            lblFinalAmount.Text = finalAmount.ToString("C2"); // Update final price
        }

        private void btn_complete_sale_Click(object sender, EventArgs e)
        {

            if (dgvCart.Rows.Count == 0)
            {
                MessageBox.Show("Error: The cart is empty. Please add items before completing the sale.");
                return;
            }

            // Validate Customer ID
            if (string.IsNullOrWhiteSpace(tb_cus_id.Text) || !int.TryParse(tb_cus_id.Text, out int customerID))
            {
                MessageBox.Show("Error: Invalid Customer ID. Please enter a valid numeric ID.");
                return;
            }

            decimal totalAmount = Convert.ToDecimal(lblTotalAmount.Text.Trim('$'));
            decimal discount = Convert.ToDecimal(tb_discount.Text);
            decimal finalAmount = Convert.ToDecimal(lblFinalAmount.Text.Trim('$'));

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Check if Customer ID exists
                    string checkCustomerQuery = "SELECT COUNT(*) FROM Customers WHERE CustomerID = @CustomerID";
                    SqlCommand checkCustomerCmd = new SqlCommand(checkCustomerQuery, conn, transaction);
                    checkCustomerCmd.Parameters.AddWithValue("@CustomerID", customerID);

                    int customerExists = (int)checkCustomerCmd.ExecuteScalar();

                    if (customerExists == 0)
                    {
                        MessageBox.Show($"Error: Customer ID {customerID} does not exist.");
                        transaction.Rollback();
                        return;
                    }

                    // Insert sale record and get SaleID
                    string saleQuery = "INSERT INTO Sales (CustomerID, TotalAmount, Discount, FinalAmount) " +
                                       "OUTPUT INSERTED.SaleID VALUES (@CustomerID, @TotalAmount, @Discount, @FinalAmount)";
                    SqlCommand saleCmd = new SqlCommand(saleQuery, conn, transaction);
                    saleCmd.Parameters.AddWithValue("@CustomerID", customerID);
                    saleCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                    saleCmd.Parameters.AddWithValue("@Discount", discount);
                    saleCmd.Parameters.AddWithValue("@FinalAmount", finalAmount);

                    int saleID = (int)saleCmd.ExecuteScalar();

                    // Process each book in the cart
                    foreach (DataGridViewRow row in dgvCart.Rows)
                    {
                        if (row.IsNewRow) continue;

                        if (row.Cells["BookID"].Value == null || row.Cells["Quantity"].Value == null ||
                            string.IsNullOrWhiteSpace(row.Cells["BookID"].Value.ToString()) ||
                            string.IsNullOrWhiteSpace(row.Cells["Quantity"].Value.ToString()))
                        {
                            MessageBox.Show($"Error: Row {row.Index} has missing BookID or Quantity.");
                            transaction.Rollback();
                            return;
                        }

                        if (!int.TryParse(row.Cells["BookID"].Value.ToString(), out int bookID) ||
                            !int.TryParse(row.Cells["Quantity"].Value.ToString(), out int quantity) ||
                            quantity <= 0)
                        {
                            MessageBox.Show($"Error: Invalid data in row {row.Index}. Check BookID and Quantity.");
                            transaction.Rollback();
                            return;
                        }

                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        // Check if BookID exists
                        string checkBookQuery = "SELECT COUNT(*) FROM Books WHERE BookID = @BookID";
                        SqlCommand checkBookCmd = new SqlCommand(checkBookQuery, conn, transaction);
                        checkBookCmd.Parameters.AddWithValue("@BookID", bookID);
                        int bookExists = (int)checkBookCmd.ExecuteScalar();

                        if (bookExists == 0)
                        {
                            MessageBox.Show($"Error: BookID {bookID} does not exist in the Books table.");
                            transaction.Rollback();
                            return;
                        }

                        // Check stock availability
                        string checkStockQuery = "SELECT StockQuantity FROM Books WHERE BookID = @BookID";
                        SqlCommand checkStockCmd = new SqlCommand(checkStockQuery, conn, transaction);
                        checkStockCmd.Parameters.AddWithValue("@BookID", bookID);
                        object stockResult = checkStockCmd.ExecuteScalar();

                        if (stockResult == null || Convert.ToInt32(stockResult) < quantity)
                        {
                            MessageBox.Show($"Error: Not enough stock for BookID {bookID}.");
                            transaction.Rollback();
                            return;
                        }

                        // Insert into SaleItems
                        string saleItemQuery = "INSERT INTO SaleItems (SaleID, BookID, Quantity, Price) VALUES (@SaleID, @BookID, @Quantity, @Price)";
                        SqlCommand saleItemCmd = new SqlCommand(saleItemQuery, conn, transaction);
                        saleItemCmd.Parameters.AddWithValue("@SaleID", saleID);
                        saleItemCmd.Parameters.AddWithValue("@BookID", bookID);
                        saleItemCmd.Parameters.AddWithValue("@Quantity", quantity);
                        saleItemCmd.Parameters.AddWithValue("@Price", price);
                        saleItemCmd.ExecuteNonQuery();

                        // Update book stock
                        string updateStockQuery = "UPDATE Books SET StockQuantity = StockQuantity - @Quantity WHERE BookID = @BookID";
                        SqlCommand stockCmd = new SqlCommand(updateStockQuery, conn, transaction);
                        stockCmd.Parameters.AddWithValue("@Quantity", quantity);
                        stockCmd.Parameters.AddWithValue("@BookID", bookID);
                        stockCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Sale completed successfully!");
                    dgvCart.Rows.Clear();
                    CalculateTotal();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string searchKeyword = tb_book.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "SELECT * FROM Books WHERE Title LIKE @Search OR Author LIKE @Search OR ISBN LIKE @Search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchKeyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvBooks.DataSource = dt; // Display results in DataGridView
            }
        }

        private void btn_print_reciept_Click(object sender, EventArgs e)
        {

            StringBuilder receipt = new StringBuilder();

            // Header
            receipt.AppendLine("==========================================================");
            receipt.AppendLine("             📚 BookHaven - Sales Receipt 📚             ");
            receipt.AppendLine("==========================================================");
            receipt.AppendLine($"Customer ID: {tb_cus_id.Text}");
            receipt.AppendLine($"Date: {DateTime.Now:dd/MM/yyyy hh:mm tt}");
            receipt.AppendLine("===========================================================");

            // Column Headers
            receipt.AppendLine($"{"Item Name",-30} {"Qty",-6} {"Price",-12} {"Total",-12}");
            receipt.AppendLine("-----------------------------------------------------------");

            // Process Each Item in the Cart
            foreach (DataGridViewRow row in dgvCart.Rows)
            {
                if (row.IsNewRow || row.Cells["Title"].Value == null || row.Cells["Quantity"].Value == null || row.Cells["Price"].Value == null)
                    continue;

                string title = row.Cells["Title"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                decimal price = Convert.ToDecimal(row.Cells["Price"].Value);
                decimal total = quantity * price;

                // Ensure text alignment using `-` for left-align
                receipt.AppendLine($"{title,-30} {quantity,-6} {price.ToString("C"),-12} {total.ToString("C"),-12}");
            }

            // Summary Section
            receipt.AppendLine("------------------------------------------------------------");
            receipt.AppendLine($"{"Total Amount:",-30} {lblTotalAmount.Text,15}");
            receipt.AppendLine($"{"Discount:",-30} {tb_discount.Text,15}");
            receipt.AppendLine($"{"Final Amount:",-30} {lblFinalAmount.Text,15}");
            receipt.AppendLine("============================================================");
            receipt.AppendLine("      Thank you for shopping with BookHaven! 🎉           ");
            receipt.AppendLine("============================================================");

            // Store the receipt text for printing
            receiptToPrint = receipt.ToString();

            // Show Print Preview
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
        
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            int receiptWidth = 2480; // Fixed width for receipt in pixels
            int receiptHeight = 3508; // Fixed height for receipt in pixels
            Font font = new Font("Courier New", 14, FontStyle.Regular); // Compact font
            float x = 5;  // Left margin
            float y = 5;  // Top margin
            float lineSpacing = 20; // Line height

            RectangleF printArea = new RectangleF(x, y, receiptWidth, receiptHeight);
            e.Graphics.SetClip(printArea); // Ensures content stays within the fixed size

            // Split receipt into lines
            string[] lines = receiptToPrint.Split('\n');
            foreach (string line in lines)
            {
                if (y + lineSpacing > receiptHeight) // Prevent printing beyond fixed height
                {
                    e.HasMorePages = true; // Enable multi-page printing if needed
                    break;
                }

                e.Graphics.DrawString(line, font, Brushes.Black, x, y);
                y += lineSpacing; // Move down
            }
        }

        
    }
}
