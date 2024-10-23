using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[1000];
        int sopt = 0;
        public int[] A { get => a; set => a = value; }
        public int Sopt { get => sopt; set => sopt = value; }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < Sopt; i++)
                chuoi += A[i] + "  ";
            return chuoi;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            sopt = int.Parse(txtNhap.Text);
            Random rd = new Random();
            for (int i = 0; i < sopt; i++)
                A[i] = rd.Next(10, 100);
            lblKQ.Text = "Đã tạo mảng Random với " + sopt + " phần tử!";
        }

        private void btnInMang_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
