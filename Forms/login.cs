using System;
using BookHaven.Forms;
using System.Data;
using Microsoft.Data.SqlClient;
using System.Text;
using System.Security.Cryptography;


namespace BookHaven
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = tb_uername.Text;
            string password = tb_password.Text; // Hash input password

            string hashedPassword = ComputeSha256Hash(password);

            using (SqlConnection conn = new SqlConnection(@"Data Source=ACER\SQLEXPRESS;Initial Catalog=BookHaven;Integrated Security=True;Trust Server Certificate=True"))
            {
                string query = "SELECT Role FROM Users WHERE Username = @username AND PasswordHash = @password";
                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                conn.Open();
                object role = cmd.ExecuteScalar();

                if (role != null)
                {
                    string userRole = role.ToString();
                    MessageBox.Show("Login Successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (userRole == "Admin")
                    {
                        new Admin_Dashboard().Show();
                    }
                    else if (userRole == "Sales Clerk")
                    {
                        new SalesCleark_Dashboard().Show();
                    }
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private string ComputeSha256Hash(string rawData)
        {
            using (SHA256 sha256Hash = SHA256.Create())
            {
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                    builder.Append(b.ToString("x2"));
                return builder.ToString();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
