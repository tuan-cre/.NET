using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._1
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }
        //khai bao báo biến  
        int[] a = new int[10];
        int sopt = 0;

        public int[] A { get => a; set => a = value; }
        public int Sopt { get => sopt; set => sopt = value; }

        //CAC PHUONG THUC  
        //phuong thuc in mang  
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < Sopt; i++)
                chuoi += A[i] + "  ";
            return chuoi;
        }
        //phuong thuc tim max  
        public int TimMax()
        {
            int max = A[0];
            for (int i = 1; i < Sopt; i++)
                if (A[i] > max)
                    max = A[i];
            return max;
        }
        //phuong thuc tim min
        public int TimMin()
        {
            int min = A[0];
            for (int i = 1; i < Sopt; i++)
                if (A[i] < min)
                    min = A[i];
            return min;
        }

        //phuong thuc tinh trung binh  
        public double TrungBinhMang()
        {
            int sum = 0;
            double tb;
            for (int i = 0; i < Sopt; i++)
                sum += A[i];
            tb = (double)sum / (double)Sopt;
            return tb;
        }
        //phuong thuc sap xep tang  
        public void SapXepTang()
        {
            Array.Sort(A, 0, Sopt);
        }
        //phuong thuc tim UCLN cua 2 so  
        public int timUCLN(int a, int b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);
            while (a != b)
            {
                if (a > b) a = a - b;
                else b = b - a;
            }
            return a;
        }
        //phuong thuc kiem tra so nguyen to  
        public Boolean kiemTraSNT(int so)
        {
            if (so <= 0)
                return false;
            else
            {
                for (int i = 2; i <= so / 2; i++)
                {
                    if (so % i == 0)
                        return false;
                }
            }
            return true;
        }

        public Boolean kiemTraSHH(int so)
        {
            if (so <= 0) return false;
            int tong = 0;
            for (int i = 1; i <= so / 2; i++)
            {
                if (so % i == 0)
                    tong += i;
            }
            if (tong == so)
                return true;
            else
                return false;
        }

        //phuong thuc dem SNT  
        public int demSNT()
        {
            int dem = 0;
            for (int i = 0; i < Sopt; i++)
            {
                if (kiemTraSNT(A[i]))
                    dem++;
            }
            return dem;
        }

        //phuong thuc dem SHH
        public int demSHH()
        {
            int dem = 0;
            for (int i = 0; i < Sopt; i++)
            {
                if (kiemTraSHH(A[i]))
                    dem++;
            }
            return dem;
        }

        //phuong thuc in SNT  
        public String inSNT()
        {
            String chuoi = "";
            for (int i = 0; i < Sopt; i++)
            {
                if (kiemTraSNT(A[i]))
                    chuoi += A[i] + " ";
            }
            return chuoi;

        }

        //phuong thuc in SHH
        public String inSHH()
        {
            String chuoi = "";
            for (int i = 0; i < Sopt; i++)
            {
                if (kiemTraSHH(A[i]))
                    chuoi += A[i] + " ";
            }
            return chuoi;

        }

        //SINH VIÊN XÂY DỰNG THÊM CÁC PHƯƠNG THỨC KHÁC  
        //CAC SU KIEN  
        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (this.Sopt == this.A.Length)
            {
                this.txtNhap.Text = "";
                MessageBox.Show("Mảng đầy", "Thông báo");
            }
            else
            {
                if (this.txtNhap.Text == "")
                    MessageBox.Show("Hãy nhập phần tử nảng", "Thông báo");
                else
                {
                    A[Sopt] = int.Parse(this.txtNhap.Text);
                    Sopt++;
                    this.lblKQ.Text += this.txtNhap.Text + " ";
                    this.txtNhap.Clear();
                    this.txtNhap.Focus();
                }
                if (Sopt > 0)
                    this.btnIn.Enabled = true;
            }

        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            //xuat cac phan tu co trong mnag  
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Các phần tử trong mảng là: \n\r" + InMang();
        }
        private void btnSXTang_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                SapXepTang();
                this.lblKQ.Text = "Đã sắp xếp mảng tăng dần";
            }
        }
        private void btnTrungBinh_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Trung bình cộng các phần tử trong mảng là: " + TrungBinhMang().ToString();
        }
        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
            {
                Array.Sort(A, 0, Sopt);
                Array.Reverse(A, 0, Sopt);
                lblKQ.Text = "Đã sắp xếp mảng giảm dần";
            }
        }

        private void btnSoNguyenTo_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSNT().ToString() + " số nguyên tố là " + inSNT();
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            lblKQ.Text = "Ước chung lớn nhất 2 phần tử đầu " + A[0] + " và " + A[1] + " là " +
            timUCLN(A[0], A[1]).ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Sopt = 0;
            lblKQ.Text = "";
            txtNhap.Clear();
            txtNhap.Focus();
            btnIn.Enabled = false;
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử lớn nhất trong mảng là: " + TimMax().ToString();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Phần tử lớn nhỏ trong mảng là: " + TimMin().ToString();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }

        private void btnDemSoChan_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < Sopt; i++)
            {
                if (A[i] % 2 == 0)
                    dem++;
            }
            lblKQ.Text = "Số phần tử chẵn trong mảng là: " + dem.ToString();
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            int dem = 0;
            for (int i = 0; i < Sopt; i++)
            {
                if (A[i] % 2 != 0)
                    dem++;
            }
            lblKQ.Text = "Số phần tử lẻ trong mảng là: " + dem.ToString();

        }
        private void btnSoHoanHao_Click(object sender, EventArgs e)
        {
            if (Sopt == 0)
                lblKQ.Text = "Mảng rỗng!";
            else
                lblKQ.Text = "Mảng có " + demSHH().ToString() + " số hoàn hảo là " + inSHH();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0;
            for (int i = 0; i < Sopt; i++)
                tong += A[i];
            lblKQ.Text = "Tổng các phần tử trong mảng là: " + tong.ToString();
        }
    }
}
