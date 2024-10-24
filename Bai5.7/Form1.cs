using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] a = new int[100];
        int n = 0;
        int status = 0;
        int[] temp = new int[100];
        private void btnTong_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            mangVao();
            int tong = 0;
            int tongle = 0;
            int tongchan = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] % 2 == 0)
                {
                    tongchan += a[i];
                }
                else
                {
                    tongle += a[i];
                }
                tong += a[i];
            }
            txtTong.Text = tong.ToString();
            txtTongChan.Text = tongchan.ToString();
            txtTongLe.Text = tongle.ToString();
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            mangVao();
            for (int i = 0; i < n; i++)
            {
                txtKetQua.Text += a[i] + " ";
            }
        }
        private void mangVao()
        {
            try
            {
                if (txtNhapMang.Text == "")
                {
                    MessageBox.Show("Chua co mang");
                    return;
                }
                string[] temp = txtNhapMang.Text.Split(' ');
                n = temp.Length;
                for (int i = 0; i < temp.Length; i++)
                {
                    a[i] = int.Parse(temp[i]);
                }
            }
            catch (Exception ex) {
                MessageBox.Show("Nhap sai dinh dang");
                reset();
                return;
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void reset()
        {
            a = new int[100];
            n = 0;
            txtNhapMang.Text = "";
            txtKetQua.Text = "";
            txtMax.Text = "";
            txtMin.Text = "";
            txtTong.Text = "";
            txtTongChan.Text = "";
            txtTongLe.Text = "";
            txtViTriThayThe.Text = "";
            txtSoThayThe.Text = "";
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            mangVao();
            int max = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] > max)
                {
                    max = a[i];
                }
            }
            txtMax.Text = max.ToString();

            int min = a[0];
            for (int i = 0; i < n; i++)
            {
                if (a[i] < min)
                {
                    min = a[i];
                }
            }
            txtMin.Text = min.ToString();
        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (status == 0)
            {
                MessageBox.Show("Chua chon cach sap xep");
                return;
            }

            if (txtNhapMang.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            txtKetQua.Text = "";
            mangVao();
            if (status == 1)
            {
                for (int i = 0; i < n; i++)
                {
                    temp[i] = a[i];
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (temp[i] > temp[j])
                        {
                            int t = temp[i];
                            temp[i] = temp[j];
                            temp[j] = t;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    txtKetQua.Text += temp[i] + " ";
                }
            }
            else if (status == 2)
            {
                for (int i = 0; i < n; i++)
                {
                    temp[i] = a[i];
                }

                for (int i = 0; i < n; i++)
                {
                    for (int j = i + 1; j < n; j++)
                    {
                        if (temp[i] < temp[j])
                        {
                            int t = temp[i];
                            temp[i] = temp[j];
                            temp[j] = t;
                        }
                    }
                }

                for (int i = 0; i < n; i++)
                {
                    txtKetQua.Text += temp[i] + " ";
                }
            }
        }

        private void rdSapXepTang_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
        }

        private void rdSapXepGiam_CheckedChanged(object sender, EventArgs e)
        {
            status = 2;
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            if (txtNhapMang.Text == "")
            {
                MessageBox.Show("Chua co mang");
                return;
            }
            mangVao();
            txtKetQua.Text = "";
            int viTriThayThe = int.Parse(txtViTriThayThe.Text);
            int soThayThe = int.Parse(txtSoThayThe.Text);

            a[viTriThayThe-1] = soThayThe;
            for (int i = 0; i < n; i++)
            {
                txtKetQua.Text += a[i] + " ";
            }
        }
    }
}
