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
    public partial class UC_Supplier_Management : UserControl
    {
        public UC_Supplier_Management()
        {
            InitializeComponent();
            LoadSuppliers();
        }

        private void btn_add_supplier_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_supplier_name.Text;
                string email = tb_supplier_email.Text;
                string phone = tb_supplier_phone.Text;
                string address = tb_supplier_address.Text;

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "INSERT INTO Suppliers (Name, Email, Phone, Address) " +
                                   "VALUES (@Name, @Email, @Phone, @Address)";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier added successfully!");
                        //LoadSuppliers(); // Refresh supplier list
                    }
                    else
                    {
                        MessageBox.Show("Supplier addition failed. No rows affected.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        
        private void btn_update_supplier_Click(object sender, EventArgs e)
        {
            try
            {
                string name = tb_supplier_name.Text;
                string email = tb_supplier_email.Text;
                string phone = tb_supplier_phone.Text;
                string address = tb_supplier_address.Text;

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "UPDATE Suppliers SET Name=@Name, Email=@Email, " +
                                   "Phone=@Phone, Address=@Address WHERE SupplierID=@SupplierID";

                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Phone", phone);
                    cmd.Parameters.AddWithValue("@Address", address);

                    // Ensure SupplierID exists in the update query
                    if (!int.TryParse(tb_supplier_id.Text, out int supplierID))
                    {
                        MessageBox.Show("Invalid Supplier ID. Please enter a valid number.");
                        return;
                    }

                    cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                    conn.Open();
                    int rowsAffected = cmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Supplier updated successfully!");
                        //LoadSuppliers(); // Refresh supplier list
                    }
                    else
                    {
                        MessageBox.Show("No supplier found with the given ID.");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = "SELECT SupplierID, Name, Email, Phone, Address FROM Suppliers";
                    SqlDataAdapter da = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgvSupplierList.DataSource = dt; // Bind data to DataGridView
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btn_place_order_Click(object sender, EventArgs e)
        {
            int supplierID = Convert.ToInt32(tb_supplier_id.Text);
            decimal totalCost = Convert.ToDecimal(tb_total_cost.Text.Trim('$'));

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                conn.Open();
                SqlTransaction transaction = conn.BeginTransaction();

                try
                {
                    // Insert new purchase order
                    string orderQuery = "INSERT INTO PurchaseOrders (SupplierID, TotalCost) OUTPUT INSERTED.OrderID VALUES (@SupplierID, @TotalCost)";
                    SqlCommand orderCmd = new SqlCommand(orderQuery, conn, transaction);
                    orderCmd.Parameters.AddWithValue("@SupplierID", supplierID);
                    orderCmd.Parameters.AddWithValue("@TotalCost", totalCost);

                    int orderID = (int)orderCmd.ExecuteScalar();

                    // Insert ordered books
                    foreach (DataGridViewRow row in dgvOrderCart.Rows)
                    {
                        int bookID = Convert.ToInt32(row.Cells["BookID"].Value);
                        int quantity = Convert.ToInt32(row.Cells["Quantity"].Value);
                        decimal price = Convert.ToDecimal(row.Cells["Price"].Value);

                        string orderItemQuery = "INSERT INTO PurchaseOrderItems (OrderID, BookID, Quantity, Price) " +
                                                "VALUES (@OrderID, @BookID, @Quantity, @Price)";
                        SqlCommand orderItemCmd = new SqlCommand(orderItemQuery, conn, transaction);
                        orderItemCmd.Parameters.AddWithValue("@OrderID", orderID);
                        orderItemCmd.Parameters.AddWithValue("@BookID", bookID);
                        orderItemCmd.Parameters.AddWithValue("@Quantity", quantity);
                        orderItemCmd.Parameters.AddWithValue("@Price", price);
                        orderItemCmd.ExecuteNonQuery();
                    }

                    transaction.Commit();
                    MessageBox.Show("Purchase order placed successfully!");
                    dgvOrderCart.Rows.Clear();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btn_delete_supplier_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate SupplierID
                if (!int.TryParse(tb_supplier_id.Text, out int supplierID))
                {
                    MessageBox.Show("Invalid Supplier ID. Please enter a valid number.");
                    return;
                }

                // Confirm deletion
                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this supplier?",
                                                       "Confirm Deletion",
                                                       MessageBoxButtons.YesNo,
                                                       MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                    {
                        string query = "DELETE FROM Suppliers WHERE SupplierID=@SupplierID";
                        SqlCommand cmd = new SqlCommand(query, conn);
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Supplier deleted successfully!");
                            //LoadSuppliers(); // Refresh supplier list
                        }
                        else
                        {
                            MessageBox.Show("No supplier found with the given ID.");
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void btn_view_order_history_Click(object sender, EventArgs e)
        {
            try
            {
                // Ensure Supplier ID is not empty
                if (string.IsNullOrWhiteSpace(tb_supplier_id.Text))
                {
                    MessageBox.Show("Please enter a Supplier ID.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Validate and convert Supplier ID
                if (!int.TryParse(tb_supplier_id.Text, out int supplierID))
                {
                    MessageBox.Show("Invalid Supplier ID. Please enter a valid number.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
                {
                    string query = @"SELECT OrderID, OrderDate, TotalCost 
                             FROM PurchaseOrders 
                             WHERE SupplierID = @SupplierID 
                             ORDER BY OrderDate DESC"; // Ensures latest orders appear first

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@SupplierID", supplierID);
                        conn.Open();

                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            da.Fill(dt);

                            if (dt.Rows.Count > 0)
                            {
                                dgv_order_history.DataSource = dt; // Ensure DataGridView exists in your form
                            }
                            else
                            {
                                MessageBox.Show("No order history found for this supplier.", "No Data", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Database error: " + ex.Message, "SQL Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        
    }
}
