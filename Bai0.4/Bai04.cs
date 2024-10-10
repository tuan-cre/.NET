using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai04
{
    public partial class Bai04 : Form
    {
        public Bai04()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int N = 0;
            double X = 0;  
            try
            {
                N = int.Parse(txtSoNguyen.Text);
                X = double.Parse(txtSoThuc.Text);
                if (N < 0) {
                    MessageBox.Show("Nhập sai dữ liệu");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai dữ liệu");
                return;
            }

            double S = 0;
            string kq1 = "x";
            string kq2 = X.ToString();
            string kq3 = "";

            for (int i = 1; i <= N; i++)
            {
                if (i == 1)
                {
                    kq3 += X.ToString();
                    S = S + X;
                }
                else
                {
                    kq1 += " + x^" + i;
                    kq2 += " + " + X + "^" + i;
                    kq3 += " + " + Math.Pow(X, i).ToString();
                    S = S + (int)Math.Pow(X, i);
                }
            }
            txtKetQua1.Text = kq1; 
            txtKetQua2.Text = kq2;
            txtKetQua3.Text = kq3;
            txtKetQua4.Text = S.ToString();
        }
    }
}
