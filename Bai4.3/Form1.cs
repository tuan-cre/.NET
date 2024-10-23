using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //khai báo biến  
        int[] a;
        int n;

        public int[] A { get => a; set => a = value; }
        public int N { get => n; set => n = value; }

        //phuong thuc tao mang  
        public void TaoMang(int n)
        {
            //khai báo mảng có n phần tử nhập từ Textbox  
            A = new int[n];
            //khởi tạo giá tri ngẫu nhiên cho mảng  
            int num1;
            Random rd = new Random();
            for (int i = 0; i < A.Length; i++)
            {
                //tạo số ngẫu nhiên nằm giữa so1 và so2  
                num1 = rd.Next(-10, 100);
                A[i] = num1;
            }
        }
        public String InMang()
        {
            String chuoi = "";
            for (int i = 0; i < N; i++)
                chuoi += A[i] + "  ";
            return chuoi;
        }

        private void btnTaoMang_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
            {
                MessageBox.Show("Hãy nhập số phần tử mảng", "Thông báo");
                txtNhap.Focus();
            }
            else
            {
                N = Convert.ToInt32(txtNhap.Text);
                if (N < 0)
                {
                    MessageBox.Show("Bạn vừa nhập n = " + N + ". Số phần tử mảng phải >0", "Thông  báo");
                    txtNhap.Focus();
                }
                else
                {
                    TaoMang(N);
                    MessageBox.Show("Mảng với các phần tử phát sinh ngẫu nhiên vừa tạo xong:\n\r" + InMang(), "Thông báo");
                }
            }
        }

        private void btnTongMang_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Các phần tử của mảng: " + InMang() +
                ", bạn có muốn tiếp tục tính tổng mảng không?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Form2 form2 = new Form2(A, N);
                form2.Show();
            }
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Các phần tử của mảng: " + InMang() +
                " , bạn có muốn tìm giá trị lớn nhất?", "Trả lời", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traloi == DialogResult.Yes)
            {
                Form3 form3 = new Form3(A, N);
                form3.Show();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traloi;
            traloi = MessageBox.Show("Chắc không?", "Trả lời", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (traloi == DialogResult.OK) Application.Exit();
        }
    }
}
