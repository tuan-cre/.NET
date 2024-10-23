using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai03
{
    public partial class FormBai03 : Form
    {
        public FormBai03()
        {
            InitializeComponent();
        }

        private void btnTinhTong_Click(object sender, EventArgs e)
        {
            int N = 0;
            try
            {
                N = int.Parse(txtSoNguyen.Text);
                if (N < 0)
                {
                    MessageBox.Show("Nhập sai dữ liệu");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Nhập sai dữ liệu");
                return;
            }
            int S = 0;
            string x = "";
            for (int i = 1; i <= N; i++)
            {
                S += i;
                if (i == 1)
                    x += i.ToString();
                else
                    x += " + " + i.ToString();
            }
            txtKetQua1.Text = x;
            txtKetQua2.Text = S.ToString();
        }
    }
}
