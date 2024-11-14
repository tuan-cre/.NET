using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLySinhVien
{
    public partial class MAINFORM : Form
    {
        public MAINFORM()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //string connectionString = "Server=LHTUAN;Database=QLSINHVIEN;Uid=sa;Pwd=tuanzom12";

            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    try
            //    {
            //        connection.Open();
            //        SqlCommand command = new SqlCommand("SELECT * FROM SINHVIEN", connection);
            //        SqlDataReader reader = command.ExecuteReader();

            //        while (reader.Read())
            //        {
            //            Console.WriteLine(reader["MaSV"].ToString());

            //            lb_sinhvien.Items.Add(reader["MaSV"].ToString()+" "+ reader["HoDem"].ToString()+ reader["Ten"].ToString() +" "+ reader["NgaySinh"].ToString() + " " + reader["GioiTinh"].ToString() + " " + reader["Tinh"].ToString() + " " + reader["MaLop"].ToString());
            //        }
            //        reader.Close();
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("An error occurred: " + ex.Message);
            //    }
            //}
        }

        private void asdasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sadasdToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void chấtLiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabChatLieu;
        }

        private void nhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabNhanVien;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
