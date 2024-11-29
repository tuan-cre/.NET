using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHieu_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtA.Text) - int.Parse(txtB.Text)).ToString();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtA.Text) + int.Parse(txtB.Text)).ToString();
        }

        private void btnTich_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtA.Text) * int.Parse(txtB.Text)).ToString();
        }

        private void btnThuong_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtA.Text) / int.Parse(txtB.Text)).ToString();
        }
    }
}
