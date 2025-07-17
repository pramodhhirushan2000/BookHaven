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
    public partial class UC_Customer_Manage : UserControl
    {
        public UC_Customer_Manage()
        {
            InitializeComponent();
            LoadCustomers();
        }

        private void btn_add_customer_Click(object sender, EventArgs e)
        {
            string fullName = tb_cus_name.Text;
            string email = tb_cus_email.Text;
            string phone = tb_cus_phone.Text;
            string nic = tb_cus_nic.Text;
            string address = tb_cus_address.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "INSERT INTO Customers (FullName, Email, Phone, Nic, Address) " +
                               "VALUES (@FullName, @Email, @Phone, @Nic, @Address)";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Nic", nic);
                    cmd.Parameters.AddWithValue("@Address", address);

                    try
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Customer added successfully!");
                        LoadCustomers(); // Refresh customer list
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }
        private void LoadCustomers()
        {
            using (SqlConnection con = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                con.Open();
                string query = "SELECT CustomerID, FullName, Email, Phone, Nic, Address FROM Customers";
                SqlDataAdapter adapter = new SqlDataAdapter(query, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                adapter.Fill(dt);
                dgvCustomers.DataSource = dt; // Display data in DataGridView
            }
        }

        private void btn_update_customer_Click(object sender, EventArgs e)
        {
            string fullName = tb_cus_name.Text;
            string email = tb_cus_email.Text;
            string phone = tb_cus_phone.Text;
            string nic = tb_cus_nic.Text;
            string address = tb_cus_address.Text;

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "UPDATE Customers SET FullName=@FullName, Email=@Email, " +
                               "Phone=@Phone, Address=@Address WHERE Nic=@Nic";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@FullName", fullName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Phone", phone);
                cmd.Parameters.AddWithValue("@Nic", nic);
                cmd.Parameters.AddWithValue("@Address", address);

                conn.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer updated successfully!");
                LoadCustomers();
            }
        }

        private void btn_delete_customer_Click(object sender, EventArgs e)
        {

            if (dgvCustomers.SelectedRows.Count > 0) // Check if a row is selected
            {
                int customerID = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["CustomerID"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this customer?",
                                                      "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        con.Open();
                        string query = "DELETE FROM Customers WHERE CustomerID = @CustomerID";
                        using (SqlCommand cmd = new SqlCommand(query, con))
                        {
                            cmd.Parameters.AddWithValue("@CustomerID", customerID);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    MessageBox.Show("Customer deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadCustomers(); // Refresh DataGridView after deletion
                }
            }
            else
            {
                MessageBox.Show("Please select a customer to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void btn_cus_search_Click(object sender, EventArgs e)
        {
            string searchValue = tb_cus_nic.Text; // Assuming NIC is used for search

            if (string.IsNullOrWhiteSpace(searchValue))
            {
                MessageBox.Show("Please enter a NIC or Phone number to search.");
                return;
            }

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "SELECT FullName, Email, Phone, Nic, Address FROM Customers WHERE Nic = @SearchValue OR Phone = @SearchValue";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@SearchValue", searchValue);

                conn.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // If a record is found
                {
                    tb_cus_name.Text = reader["FullName"].ToString();
                    tb_cus_email.Text = reader["Email"].ToString();
                    tb_cus_phone.Text = reader["Phone"].ToString();
                    tb_cus_nic.Text = reader["Nic"].ToString();
                    tb_cus_address.Text = reader["Address"].ToString();
                }
                else
                {
                    MessageBox.Show("Customer not found.");
                }

                reader.Close();
            }
        }


        private void btn_cus_vp_history_Click(object sender, EventArgs e)
        {
            // Validate if tb_cus_id is not empty and is a valid number
            if (string.IsNullOrWhiteSpace(tb_cus_id.Text) || !int.TryParse(tb_cus_id.Text.Trim(), out int customerID))
            {
                MessageBox.Show("Please enter a valid Customer ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // SQL Connection String (Ensure it's correct)
            string connectionString = @"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True";

            // Updated SQL Query to fetch purchase history from Sales and SaleItems
            string query = @"
            SELECT 
                b.Title, 
                si.Quantity, 
                s.SaleDate 
            FROM SaleItems si
            JOIN Sales s ON si.SaleID = s.SaleID
            JOIN Books b ON si.BookID = b.BookID
            WHERE s.CustomerID = @CustomerID
            ORDER BY s.SaleDate DESC";

            // Clear previous data in DataGridView
            dgvPurchaseHistory.DataSource = null;

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@CustomerID", SqlDbType.Int).Value = customerID;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dgvPurchaseHistory.DataSource = dt; // Bind data to DataGridView
                            }
                            else
                            {
                                MessageBox.Show("No purchase history found for this customer.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (SqlException sqlEx)
            {
                MessageBox.Show("SQL Error: " + sqlEx.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unexpected Error: " + ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
