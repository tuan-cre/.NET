using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[100];

        //private void rdMangRandom_CheckedChanged(object sender, EventArgs e)
        //{
        //    txtMangGoc.Text = "";
        //    txtKetQua.Text = "";
        //    Random random = new Random();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        a[i] = random.Next(1, 100);
        //        txtMangGoc.Text += a[i] + " ";
        //    }
        //}

        private void rdTimMin_CheckedChanged(object sender, EventArgs e)
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

        private void rdTongLe_CheckedChanged(object sender, EventArgs e)
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

        private void rdTongChan_CheckedChanged(object sender, EventArgs e)
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
                if (a[i] % 2 == 0)
                {
                    tong += a[i];
                }
            }
            txtKetQua.Text = tong.ToString();
        }

        private void rdDemChan_CheckedChanged(object sender, EventArgs e)
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
                if (a[i] % 2 == 0)
                {
                    dem++;
                }
            }
            txtKetQua.Text = dem.ToString();
        }

        private void rdDemLe_CheckedChanged(object sender, EventArgs e)
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

        private void rdLietKeChan_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";

            for (int i = 0; i < 10; i++)
            {
                if (a[i] % 2 == 0)
                {
                    txtKetQua.Text += a[i] + " ";
                }
            }
        }

        private void rdChanCuoiCung_CheckedChanged(object sender, EventArgs e)
        {
            if (txtMangGoc.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";

            for (int i = 9; i >= 0; i--)
            {
                if (a[i] % 2 == 0)
                {
                    txtKetQua.Text += a[i];
                    return;
                }
            }

        }

        private void rdMangRandom_MouseClick(object sender, MouseEventArgs e)
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
    }
}
