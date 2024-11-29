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

namespace Bai10
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.NET\Bai10\QLNV.mdf;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }
        DataSet ds = new DataSet("dsQLNV");
        SqlDataAdapter daChucVu;
        SqlDataAdapter daNhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadNhanVienData();
        }
        private void LoadNhanVienData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                // Dữ liệu combobox Chức vụ 
                conn.Open();
                string sQueryChucVu = @"select * from chucvu";
                daChucVu = new SqlDataAdapter(sQueryChucVu, conn);
                daChucVu.Fill(ds, "tblChucVu");
                cboChucVu.DataSource = ds.Tables["tblChucVu"];
                cboChucVu.DisplayMember = "tencv";
                cboChucVu.ValueMember = "macv";

                // Dữ liệu datagrid Danh sách nhân viên 
                string sQueryNhanVien = @"select n.*, c.tencv from nhanvien n, chucvu c where n.macv=c.macv";
                daNhanVien = new SqlDataAdapter(sQueryNhanVien, conn);
                daNhanVien.Fill(ds, "tblDSNhanVien");
                dgDSNhanVien.DataSource = ds.Tables["tblDSNhanVien"];

                dgDSNhanVien.Columns["manv"].HeaderText = "Mã số";
                dgDSNhanVien.Columns["manv"].Width = 60;
                // … đặt tiêu đề tiếng Việt, định độ rộng cho các trường còn lại 
                dgDSNhanVien.Columns["macv"].Visible = false;

                // Command Thêm nhân viên 
                string sThemNV = @"insert into nhanvien values(@MaNV, @HoLot, @TenNV, @Phai, @NgaySinh, @MaCV)";
                SqlCommand cmThemNV = new SqlCommand(sThemNV, conn);
                cmThemNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
                cmThemNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmThemNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
                cmThemNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                cmThemNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                cmThemNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");

                daNhanVien.InsertCommand = cmThemNV;

                // Command Sửa nhân viên
                string sSuaNV = @"update nhanvien set holot=@HoLot, tennv=@TenNV, phai=@Phai, ngaysinh=@NgaySinh, macv=@MaCV where manv=@MaNV";
                SqlCommand cmSuaNV = new SqlCommand(sSuaNV, conn);
                cmSuaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");
                cmSuaNV.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                cmSuaNV.Parameters.Add("@TenNV", SqlDbType.NVarChar, 10, "tennv");
                cmSuaNV.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                cmSuaNV.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                cmSuaNV.Parameters.Add("@MaCV", SqlDbType.NVarChar, 5, "macv");

                daNhanVien.UpdateCommand = cmSuaNV;

                // Command Xóa nhân viên
                string sXoaNV = @"delete from nhanvien where manv=@MaNV";
                SqlCommand cmXoaNV = new SqlCommand(sXoaNV, conn);
                cmXoaNV.Parameters.Add("@MaNV", SqlDbType.NVarChar, 5, "manv");

                daNhanVien.DeleteCommand = cmXoaNV;

                conn.Close();
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    daNhanVien.InsertCommand.Connection = conn;
                    daNhanVien.UpdateCommand.Connection = conn;
                    daNhanVien.DeleteCommand.Connection = conn;

                    daNhanVien.Update(ds, "tblDSNhanVien");
                    MessageBox.Show("Data saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow row = ds.Tables["tblDSNhanVien"].NewRow();
            row["manv"] = txtMaNV.Text;
            row["holot"] = txtHoLot.Text;
            row["tennv"] = txtTen.Text;
            row["phai"] = radNu.Checked ? "Nữ" : "Nam";
            row["ngaysinh"] = dtpNgaySinh.Text;
            row["macv"] = cboChucVu.SelectedValue;

            DataRow[] selectedChucVu = ds.Tables["tblChucVu"].Select("macv = '" + cboChucVu.SelectedValue + "'");
            if (selectedChucVu.Length > 0)
            {
                row["tencv"] = selectedChucVu[0]["tencv"]; 
            }

            ds.Tables["tblDSNhanVien"].Rows.Add(row);
        }


        private void dgDSNhanVien_Click(object sender, EventArgs e)
        {
            DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
            txtMaNV.Text = dr.Cells["manv"].Value.ToString();
            txtHoLot.Text = dr.Cells["holot"].Value.ToString();
            txtTen.Text = dr.Cells["tennv"].Value.ToString();
            if (dr.Cells["phai"].Value.ToString() == "Nam")
            {
                radNam.Checked = true;
            }
            else
            {
                radNu.Checked = true;
            }
            dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
            cboChucVu.SelectedValue = dr.Cells["macv"].Value.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                DataRow[] rows = ds.Tables["tblDSNhanVien"].Select("manv = '" + dr.Cells["manv"].Value.ToString() + "'");

                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["holot"] = txtHoLot.Text;
                    row["tennv"] = txtTen.Text;
                    row["phai"] = radNam.Checked ? "Nam" : "Nữ";
                    row["ngaysinh"] = dtpNgaySinh.Value;
                    row["macv"] = cboChucVu.SelectedValue;
                }
            }
        }


        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblDSNhanVien"].RejectChanges();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSNhanVien.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSNhanVien.SelectedRows[0];
                dgDSNhanVien.Rows.Remove(dr);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
