using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKiemTraNgayHopLe_Click(object sender, EventArgs e)
        {
            if (txtNgay.Text == "" || txtThang.Text == "" || txtNam.Text == "")
            {
                MessageBox.Show("Vui long nhap day du thong tin!");
                return;
            }

            int ngay = int.Parse(txtNgay.Text);
            int thang = int.Parse(txtThang.Text);
            int nam = int.Parse(txtNam.Text);

            if (ngay < 1 || ngay > 31)
            {
                MessageBox.Show("Ngay khong hop le!");
                return;
            }
            if (thang < 1 || thang > 12)
            {
                MessageBox.Show("Thang khong hop le!");
                return;
            }
            if (nam < 1)
            {
                MessageBox.Show("Nam khong hop le!");
                return;
            }
            if (thang == 1 || thang == 3 || thang == 5 || thang == 7 || thang == 8 || thang == 10 || thang == 12)
            {
                if (ngay > 31)
                {
                    MessageBox.Show("Ngay khong hop le!");
                    return;
                }
            }
            else if (thang == 4 || thang == 6 || thang == 9 || thang == 11)
            {
                if (ngay > 30)
                {
                    MessageBox.Show("Ngay khong hop le!");
                    return;
                }
            }
            else
            {
                if (nam % 400 == 0 || (nam % 4 == 0 && nam % 100 != 0))
                {
                    if (ngay > 29)
                    {
                        MessageBox.Show("Ngay khong hop le!");
                        return;
                    }
                }
                else
                {
                    if (ngay > 28)
                    {
                        MessageBox.Show("Ngay khong hop le!");
                        return;
                    }
                }
            }
            MessageBox.Show("Ngay hop le!");
        }
    }
}
