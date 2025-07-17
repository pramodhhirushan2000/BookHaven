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
using System.Globalization;

namespace BookHaven.User_Controls
{
    public partial class UC_Order_Management : UserControl
    {
        public UC_Order_Management()
        {
            InitializeComponent();
            LoadOrderData();


        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {
            try
            {
                int customerID = int.Parse(tb_cus_id.Text);
                string deliveryMethod = cmbDeliveryMethod.SelectedItem?.ToString() ?? "Pickup";
                string deliveryAddress = tb_delivery_address.Text;
                decimal totalAmount = decimal.Parse(tb_total_amount.Text, NumberStyles.Currency, CultureInfo.CurrentCulture);
                DateTime expectedDeliveryDate = dtpDeliveryDate.Value;

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=False"))
                {
                    conn.Open();
                    SqlTransaction transaction = conn.BeginTransaction();

                    try
                    {
                        string orderQuery = "INSERT INTO Orders (CustomerID, TotalAmount, DeliveryMethod, DeliveryAddress, ExpectedDeliveryDate) " +
                                            "OUTPUT INSERTED.OrderID VALUES (@CustomerID, @TotalAmount, @DeliveryMethod, @DeliveryAddress, @ExpectedDeliveryDate)";
                        SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                        orderCmd.Parameters.AddWithValue("@CustomerID", customerID);
                        orderCmd.Parameters.AddWithValue("@TotalAmount", totalAmount);
                        orderCmd.Parameters.AddWithValue("@DeliveryMethod", deliveryMethod);
                        orderCmd.Parameters.AddWithValue("@DeliveryAddress", deliveryMethod == "Delivery" ? deliveryAddress : (object)DBNull.Value);
                        orderCmd.Parameters.AddWithValue("@ExpectedDeliveryDate", deliveryMethod == "Delivery" ? expectedDeliveryDate : (object)DBNull.Value);

                        object result = orderCmd.ExecuteScalar();
                        if (result == null || result == DBNull.Value)
                            throw new Exception("Order insertion failed.");

                        int orderID = Convert.ToInt32(result);

                        foreach (DataGridViewRow row in dgvOrderCart.Rows)
                        {
                            if (row.IsNewRow) continue;
                            if (row.Cells["BookID"].Value == null || row.Cells["Quantity"].Value == null || row.Cells["Price"].Value == null)
                                continue;

                            int bookID = Convert.ToInt32(row.Cells["BookID"].Value);
                            int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                            decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                            string orderItemQuery = "INSERT INTO OrderItems (OrderID, BookID, Quantity, Price) " +
                                                    "VALUES (@OrderID, @BookID, @Quantity, @Price)";
                            SqlCommand orderItemCmd = new SqlCommand(orderItemQuery, conn, transaction);
                            orderItemCmd.Parameters.AddWithValue("@OrderID", orderID);
                            orderItemCmd.Parameters.AddWithValue("@BookID", bookID);
                            orderItemCmd.Parameters.AddWithValue("@Quantity", quantity);
                            orderItemCmd.Parameters.AddWithValue("@Price", price);
                            orderItemCmd.ExecuteNonQuery();
                        }

                        transaction.Commit();
                        MessageBox.Show("Order placed successfully!");
                        dgvOrderCart.Rows.Clear();
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        MessageBox.Show("Error: " + ex.Message);
                        Console.WriteLine(ex.ToString()); // Debugging
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Input error: " + ex.Message);
            }
        }
        private void LoadOrderData()
        {
            // Create a connection to the database
            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=False"))
            {
                conn.Open();

                // Example query to load order data (you can adjust it to fit your needs)
                string query = "SELECT OrderID, CustomerID, TotalAmount, DeliveryMethod, DeliveryAddress, ExpectedDeliveryDate FROM Orders";
                SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                // Bind the data to your DataGridView
                dgvOrderCart.DataSource = dt;
            }
        }

        private void btn_update_order_Click(object sender, EventArgs e)
        {
            int orderID = Convert.ToInt32(tb_order_id.Text);
            string orderStatus = cmbOrderStatus.SelectedItem.ToString();
            string paymentStatus = cmbPaymentStatus.SelectedItem.ToString();

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "UPDATE Orders SET OrderStatus=@OrderStatus, PaymentStatus=@PaymentStatus WHERE OrderID=@OrderID";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@OrderID", orderID);
                cmd.Parameters.AddWithValue("@OrderStatus", orderStatus);
                cmd.Parameters.AddWithValue("@PaymentStatus", paymentStatus);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Order updated successfully!");
                //LoadOrders(); // Refresh order list
            }
        }

        private void btn_search_order_Click(object sender, EventArgs e)
        {
            string searchKeyword = tb_search_order.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
            {
                string query = "SELECT * FROM Orders WHERE OrderID LIKE @Search OR CustomerID LIKE @Search OR OrderStatus LIKE @Search";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", "%" + searchKeyword + "%");

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvOrders.DataSource = dt; // Display results in DataGridView
            }
        }

        

        
    }
}
