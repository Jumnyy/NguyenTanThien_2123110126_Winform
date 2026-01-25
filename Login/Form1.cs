using System;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using ExampleSQL;
namespace Login
{
    public partial class Form1 : Form
    {
        string connectionString = "Data Source=Localhost,1433; Initial Catalog=sale; User Id=sa; Password=sa;TrustServerCertificate=True;";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbEmail.Text.Trim();
            string password = tbPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ Email và Mật khẩu!");
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    // Sử dụng Parameterized Query để tránh lỗi SQL Injection
                    string sql = "SELECT COUNT(*) FROM Users WHERE Email = @email AND Password = @password";

                    using (SqlCommand cmd = new SqlCommand(sql, conn))
                    {
                        cmd.Parameters.AddWithValue("@email", email);
                        cmd.Parameters.AddWithValue("@password", password);

                        int count = (int)cmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show("Đăng nhập thành công!");
                            // 1. Khởi tạo Form mới (CustomerGUI là tên file/class bạn đang có)
                            CustomerGUI mainForm = new CustomerGUI();

                            // 2. Hiển thị Form mới lên
                            mainForm.Show();

                            // 3. Ẩn Form đăng nhập hiện tại đi (tùy chọn)
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Sai Email hoặc Mật khẩu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message);
            }
        }
    }
}
