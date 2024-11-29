using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_2._9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnChuVi_Click(object sender, EventArgs e)
        {
            txtResult.Text = (((int.Parse(txtA.Text) + int.Parse(txtB.Text)) * 2).ToString());
        }

        private void btnDienTich_Click(object sender, EventArgs e)
        {
            txtResult.Text = (int.Parse(txtA.Text) * int.Parse(txtB.Text)).ToString();
        }

        private void btnDuongCheo_Click(object sender, EventArgs e)
        {
            txtResult.Text = (Math.Sqrt(Math.Pow(int.Parse(txtA.Text), 2) + Math.Pow(int.Parse(txtB.Text), 2))).ToString();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Close();
        }
    }
}
