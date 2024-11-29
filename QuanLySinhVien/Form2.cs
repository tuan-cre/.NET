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
    public partial class mainForm : Form
    {
        private string connectionString = @"Server=tcp:lhtuan.database.windows.net,1433;Initial Catalog=QLSINHVIEN;User ID=lhtuan;Password=Tuanle7924@;Encrypt=True;TrustServerCertificate=True;Connection Timeout=30;";
        public mainForm()
        {
            InitializeComponent();
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            LoadSinhVienData();
        }

        private void LoadSinhVienData()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT MaSV, HoSV, TenSV, GioiTinh, NgaySinh, MaLop, MaKhoa FROM SINHVIEN";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridViewSinhVien.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Check if MaLop exists in LOP table
                    string checkQuery = "SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop";
                    using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                    {
                        checkCommand.Parameters.AddWithValue("@MaLop", MaLop.Text);
                        int count = (int)checkCommand.ExecuteScalar();
                        if (count == 0)
                        {
                            MessageBox.Show("MaLop does not exist in the LOP table.");
                            return;
                        }
                    }

                    string query = "INSERT INTO SINHVIEN (MaSV, HoSV, TenSV, GioiTinh, NgaySinh, MaLop, MaKhoa) VALUES (@MaSV, @HoSV, @TenSV, @GioiTinh, @NgaySinh, @MaLop, @MaKhoa)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Add parameters here
                        command.Parameters.AddWithValue("@MaSV", MaSV.Text);
                        command.Parameters.AddWithValue("@HoSV", HoSV.Text);
                        command.Parameters.AddWithValue("@TenSV", TenSV.Text);
                        command.Parameters.AddWithValue("@GioiTinh", rdNam.Checked);
                        command.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                        command.Parameters.AddWithValue("@MaLop", MaLop.Text);
                        command.Parameters.AddWithValue("@MaKhoa", MaKhoa.Text);

                        command.ExecuteNonQuery();
                    }
                    LoadSinhVienData();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewSinhVien.SelectedRows[0].Index;
                string maSV = dataGridViewSinhVien.Rows[selectedRowIndex].Cells["MaSV"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();
                        string query = "DELETE FROM SINHVIEN WHERE MaSV = @MaSV";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@MaSV", maSV);
                            command.ExecuteNonQuery();
                        }
                        LoadSinhVienData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dataGridViewSinhVien.SelectedRows.Count > 0)
            {
                int selectedRowIndex = dataGridViewSinhVien.SelectedRows[0].Index;
                string maSV = dataGridViewSinhVien.Rows[selectedRowIndex].Cells["MaSV"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    try
                    {
                        connection.Open();

                        // Check if MaLop exists in LOP table
                        string checkQuery = "SELECT COUNT(*) FROM LOP WHERE MaLop = @MaLop";
                        using (SqlCommand checkCommand = new SqlCommand(checkQuery, connection))
                        {
                            checkCommand.Parameters.AddWithValue("@MaLop", MaLop.Text);
                            int count = (int)checkCommand.ExecuteScalar();
                            if (count == 0)
                            {
                                MessageBox.Show("MaLop does not exist in the LOP table.");
                                return;
                            }
                        }

                        string query = "UPDATE SINHVIEN SET HoSV = @HoSV, TenSV = @TenSV, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, MaLop = @MaLop, MaKhoa = @MaKhoa WHERE MaSV = @MaSV";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            // Add parameters here
                            command.Parameters.AddWithValue("@MaSV", maSV);
                            command.Parameters.AddWithValue("@HoSV", HoSV.Text);
                            command.Parameters.AddWithValue("@TenSV", TenSV.Text);
                            command.Parameters.AddWithValue("@GioiTinh", rdNam.Checked);
                            command.Parameters.AddWithValue("@NgaySinh", dtNgaySinh.Value);
                            command.Parameters.AddWithValue("@MaLop", MaLop.Text);
                            command.Parameters.AddWithValue("@MaKhoa", MaKhoa.Text);

                            command.ExecuteNonQuery();
                        }
                        LoadSinhVienData();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }

        private void btnLamMoi_Click(object sender, EventArgs e)
        {
            LoadSinhVienData();
        }
    }
}
