using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[100];
        int[] kq = new int[100];
        int[] temp = new int[100];
        private void btnXuatMangRandom_Click(object sender, EventArgs e)
        {
            txtMangGoc.Text = "";
            txtKetQua.Text = "";
            Random random = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = random.Next(1, 100);
                txtMangGoc.Text += a[i] + " ";
            }
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            int tong = 0;
            for (int i = 0; i < 10; i++) {
                tong += a[i];
            }
            txtKetQua.Text = tong.ToString();
        }

        private void btnTimMin_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            int min = a[0];
            for (int i = 0; i < 10; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            txtKetQua.Text = min.ToString();
        }

        private void btnIncreaseAllBy2_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            
            for (int i = 0; i < 10; i++)
            {
                temp[i] += a[i]+2;
                txtKetQua.Text += temp[i] + " ";
            }
        }

        private void btnDemSoLe_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";

            int dem = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 2 != 0)
                {
                    dem++;
                }
            }
            txtKetQua.Text = dem.ToString();
        }

        private void btnSapXepTang_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";

            for (int i = 0; i < 10; i++)
            {
                temp[i] = a[i];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (temp[i] > temp[j])
                    {
                        int t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            for(int i = 0; i < 10; i++)
            {
                txtKetQua.Text += temp[i] + " ";
            }
        }

        private void btnTongSoLe_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            int tong = 0;
            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 2 != 0)
                {
                    tong += a[i];
                }
            }
            txtKetQua.Text = tong.ToString();
        }

        private void btnSapXepGiam_Click(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";

            for (int i = 0; i < 10; i++)
            {
                temp[i] = a[i];
            }

            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (temp[i] < temp[j])
                    {
                        int t = temp[i];
                        temp[i] = temp[j];
                        temp[j] = t;
                    }
                }
            }

            for (int i = 0; i < 10; i++)
            {
                txtKetQua.Text += temp[i] + " ";
            }
        }
    }
}
