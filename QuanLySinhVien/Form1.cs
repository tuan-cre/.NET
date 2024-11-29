using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien
{
    public partial class loginForm : Form
    {

        private string connectionString = @"Server=tcp:lhtuan.database.windows.net,1433;Initial Catalog=QLSINHVIEN;User ID=lhtuan;Password=Tuanle7924@;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim(); // Lấy tên đăng nhập
            string password = txtPassword.Text.Trim(); // Lấy mật khẩu

            // Kiểm tra tên đăng nhập và mật khẩu
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập và mật khẩu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Xác thực thông tin người dùng và lấy vai trò
            string userRole = AuthenticateUser(username, password);

            if (!string.IsNullOrEmpty(userRole))
            {
                MessageBox.Show($"Đăng nhập thành công với vai trò: {userRole}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Hiển thị vai trò người dùng và chuyển đến form chính
                // Ví dụ: 
                // MainForm mainForm = new MainForm(userRole);
                // mainForm.Show();
                mainForm mainForm = new mainForm();
                mainForm.Show();
                this.Hide();  // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Hàm xác thực người dùng
        private string AuthenticateUser(string username, string password)
        {
            string userRole = null;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    // SQL query để xác thực người dùng và lấy vai trò
                    string query = @"
                        SELECT r.RoleName 
                        FROM APP_USER u
                        JOIN USER_ROLE r ON u.RoleID = r.RoleID
                        WHERE u.Username = @Username AND u.Password = @Password";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Thêm tham số để bảo mật truy vấn SQL
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Password", password);

                        // Thực hiện truy vấn và lấy kết quả vai trò người dùng
                        userRole = cmd.ExecuteScalar() as string;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi kết nối cơ sở dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            return userRole;
        }
    }
}
