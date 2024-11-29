using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Bai11
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\.NET\Bai11\QLHS.mdf;Integrated Security=True";
        private DataSet ds = new DataSet("dsQLHS");
        private SqlDataAdapter daQueQuan;
        private SqlDataAdapter daHocSinh;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void LoadData()
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                // Load dữ liệu bảng quequan
                string queryQueQuan = "SELECT * FROM quequan";
                daQueQuan = new SqlDataAdapter(queryQueQuan, conn);
                daQueQuan.Fill(ds, "tblQueQuan");
                cboQueQuan.DataSource = ds.Tables["tblQueQuan"];
                cboQueQuan.DisplayMember = "tenqq";
                cboQueQuan.ValueMember = "maqq";

                // Load dữ liệu bảng hocsinh
                string queryHocSinh = "SELECT h.*, q.tenqq FROM hocsinh h INNER JOIN quequan q ON h.maqq = q.maqq";
                daHocSinh = new SqlDataAdapter(queryHocSinh, conn);
                daHocSinh.Fill(ds, "tblHocSinh");
                dgDSHocSinh.DataSource = ds.Tables["tblHocSinh"];

                dgDSHocSinh.Columns["mahs"].HeaderText = "Mã HS";
                dgDSHocSinh.Columns["holot"].HeaderText = "Họ lót";
                dgDSHocSinh.Columns["tenhs"].HeaderText = "Tên HS";
                dgDSHocSinh.Columns["phai"].HeaderText = "Phái";
                dgDSHocSinh.Columns["ngaysinh"].HeaderText = "Ngày sinh";
                dgDSHocSinh.Columns["maqq"].Visible = false;
                dgDSHocSinh.Columns["tenqq"].HeaderText = "Quê quán";

                // Command thêm
                string insertQuery = "INSERT INTO hocsinh VALUES (@MaHS, @HoLot, @TenHS, @Phai, @NgaySinh, @MaQQ)";
                SqlCommand insertCommand = new SqlCommand(insertQuery, conn);
                insertCommand.Parameters.Add("@MaHS", SqlDbType.NVarChar, 5, "mahs");
                insertCommand.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                insertCommand.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50, "tenhs");
                insertCommand.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                insertCommand.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                insertCommand.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 5, "maqq");
                daHocSinh.InsertCommand = insertCommand;

                // Command sửa
                string updateQuery = "UPDATE hocsinh SET holot = @HoLot, tenhs = @TenHS, phai = @Phai, ngaysinh = @NgaySinh, maqq = @MaQQ WHERE mahs = @MaHS";
                SqlCommand updateCommand = new SqlCommand(updateQuery, conn);
                updateCommand.Parameters.Add("@MaHS", SqlDbType.NVarChar, 5, "mahs");
                updateCommand.Parameters.Add("@HoLot", SqlDbType.NVarChar, 50, "holot");
                updateCommand.Parameters.Add("@TenHS", SqlDbType.NVarChar, 50, "tenhs");
                updateCommand.Parameters.Add("@Phai", SqlDbType.NVarChar, 3, "phai");
                updateCommand.Parameters.Add("@NgaySinh", SqlDbType.SmallDateTime, 10, "ngaysinh");
                updateCommand.Parameters.Add("@MaQQ", SqlDbType.NVarChar, 5, "maqq");
                daHocSinh.UpdateCommand = updateCommand;

                // Command xóa
                string deleteQuery = "DELETE FROM hocsinh WHERE mahs = @MaHS";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, conn);
                deleteCommand.Parameters.Add("@MaHS", SqlDbType.NVarChar, 5, "mahs");
                daHocSinh.DeleteCommand = deleteCommand;

                conn.Close();
            }
        }

        private void dgDSHocSinh_Click(object sender, EventArgs e)
        {
            if (dgDSHocSinh.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSHocSinh.SelectedRows[0];
                txtMaHS.Text = dr.Cells["mahs"].Value.ToString();
                txtHoLot.Text = dr.Cells["holot"].Value.ToString();
                txtTen.Text = dr.Cells["tenhs"].Value.ToString();
                radNam.Checked = dr.Cells["phai"].Value.ToString() == "Nam";
                radNu.Checked = !radNam.Checked;
                dtpNgaySinh.Text = dr.Cells["ngaysinh"].Value.ToString();
                cboQueQuan.SelectedValue = dr.Cells["maqq"].Value.ToString();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            DataRow newRow = ds.Tables["tblHocSinh"].NewRow();
            newRow["mahs"] = txtMaHS.Text;
            newRow["holot"] = txtHoLot.Text;
            newRow["tenhs"] = txtTen.Text;
            newRow["phai"] = radNam.Checked ? "Nam" : "Nữ";
            newRow["ngaysinh"] = dtpNgaySinh.Value;
            newRow["maqq"] = cboQueQuan.SelectedValue;
            ds.Tables["tblHocSinh"].Rows.Add(newRow);

            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (dgDSHocSinh.SelectedRows.Count > 0)
            {
                DataGridViewRow dr = dgDSHocSinh.SelectedRows[0];
                DataRow[] rows = ds.Tables["tblHocSinh"].Select("mahs = '" + dr.Cells["mahs"].Value.ToString() + "'");

                if (rows.Length > 0)
                {
                    DataRow row = rows[0];
                    row["holot"] = txtHoLot.Text;
                    row["tenhs"] = txtTen.Text;
                    row["phai"] = radNam.Checked ? "Nam" : "Nữ";
                    row["ngaysinh"] = dtpNgaySinh.Value;
                    row["maqq"] = cboQueQuan.SelectedValue;
                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgDSHocSinh.SelectedRows.Count > 0)
            {
                DialogResult confirm = MessageBox.Show("Bạn có chắc muốn xóa không?", "Xác nhận", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    DataGridViewRow dr = dgDSHocSinh.SelectedRows[0];
                    dgDSHocSinh.Rows.Remove(dr);

                    btnLuu.Enabled = true;
                    btnHuy.Enabled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            ds.Tables["tblHocSinh"].RejectChanges();
            btnLuu.Enabled = false;
            btnHuy.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    daHocSinh.InsertCommand.Connection = conn;
                    daHocSinh.UpdateCommand.Connection = conn;
                    daHocSinh.DeleteCommand.Connection = conn;

                    daHocSinh.Update(ds, "tblHocSinh");
                    MessageBox.Show("Dữ liệu đã được lưu vào cơ sở dữ liệu.");
                    btnLuu.Enabled = false;
                    btnHuy.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu: " + ex.Message);
                }
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show("Bạn có chắc muốn thoát không?", "Xác nhận", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
