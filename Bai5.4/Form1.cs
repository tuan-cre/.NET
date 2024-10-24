using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int status = 3;
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            switch (status) {
                case 1:
                    tinhHinhTron();
                    break;
                case 2:
                    tinhHinhTamGiac();
                    break;
                case 3:
                    tinhHinhVuong();
                    break;
                case 4:
                    tinhHinhChuNhat();
                    break;
            }
        }

        private void tinhHinhVuong()
        {
            try
            {
                int A = int.Parse(txtVuongA.Text);
                if (A <= 0)
                {
                    MessageBox.Show("Cạnh phải lớn hơn 0");
                    return;
                }
                int CV = A * 4;
                int DT = A * A;
                txtVuongCV.Text = CV.ToString();
                txtVuongDT.Text = DT.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void tinhHinhTron()
        {
            try
            {
                double R = double.Parse(txtTronR.Text);
                if (R <= 0)
                {
                    MessageBox.Show("Ban kinh phải lớn hơn 0");
                    return;
                }
                double CV = Math.Round(2 * R * Math.PI, 4);
                double DT = Math.Round(R * R * Math.PI, 4);

                txtTronCV.Text = CV.ToString();
                txtTronDT.Text = DT.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void tinhHinhTamGiac()
        {
            try
            {
                double A = double.Parse(txtTamGiacA.Text);
                double B = double.Parse(txtTamGiacB.Text);
                double C = double.Parse(txtTamGiacC.Text);
                if (A <= 0 || B <= 0 || C <= 0)
                {
                    MessageBox.Show("Cạnh phải lớn hơn 0");
                    return;
                }
                if (A + B <= C || A + C <= B || B + C <= A)
                {
                    MessageBox.Show("Không phải tam giác");
                    return;
                }
                double CV = A + B + C;
                double p = CV / 2;
                double DT = Math.Round(Math.Sqrt(p * (p - A) * (p - B) * (p - C)), 4);
                txtTamGiacCV.Text = CV.ToString();
                txtTamGiacDT.Text = DT.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void tinhHinhChuNhat()
        {
            try
            {
                double A = double.Parse(txtChuNhatA.Text);
                double B = double.Parse(txtChuNhatB.Text);
                if (A <= 0 || B <= 0)
                {
                    MessageBox.Show("Cạnh phải lớn hơn 0");
                    return;
                }
                double CV = (A + B) * 2;
                double DT = A * B;
                txtChuNhatCV.Text = CV.ToString();
                txtChuNhatDT.Text = DT.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void rdTron_CheckedChanged(object sender, EventArgs e)
        {
            status = 1;
            gbHinhTron.Visible = true;
            gbHinhTamGiac.Visible = false;
            gbHinhVuong.Visible = false;
            gbHinhChuNhat.Visible = false;
        }

        private void rdTamGiac_CheckedChanged(object sender, EventArgs e)
        {
            status = 2;
            gbHinhTron.Visible = false;
            gbHinhTamGiac.Visible = true;
            gbHinhVuong.Visible = false;
            gbHinhChuNhat.Visible = false;
        }

        private void rdVuong_CheckedChanged(object sender, EventArgs e)
        {
            status = 3;
            gbHinhTron.Visible = false;
            gbHinhTamGiac.Visible = false;
            gbHinhVuong.Visible = true;
            gbHinhChuNhat.Visible = false;
        }

        private void rdChuNhat_CheckedChanged(object sender, EventArgs e)
        {
            status = 4;
            gbHinhTron.Visible = false;
            gbHinhTamGiac.Visible = false;
            gbHinhVuong.Visible = false;
            gbHinhChuNhat.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtTronR.Text = "";
            txtTronCV.Text = "";
            txtTronDT.Text = "";
            txtVuongA.Text = "";
            txtVuongCV.Text = "";
            txtVuongDT.Text = "";
            txtTamGiacA.Text = "";
            txtTamGiacB.Text = "";
            txtTamGiacC.Text = "";
            txtTamGiacCV.Text = "";
            txtTamGiacDT.Text = "";
            txtChuNhatA.Text = "";
            txtChuNhatB.Text = "";
            txtChuNhatCV.Text = "";
            txtChuNhatDT.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
