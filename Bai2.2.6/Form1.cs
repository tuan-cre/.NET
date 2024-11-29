using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "Tong la: " + (int.Parse(txtA.Text) + int.Parse(txtB.Text)));
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "Hieu la: " + (int.Parse(txtA.Text) - int.Parse(txtB.Text)));
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "Tich la: " + (int.Parse(txtA.Text) * int.Parse(txtB.Text)));
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Text = "Thuong la: " + (int.Parse(txtA.Text) / int.Parse(txtB.Text)));
        }
    }
}
