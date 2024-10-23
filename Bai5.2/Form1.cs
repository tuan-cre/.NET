using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int n;
                try
                {
                    n = int.Parse(txtN.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhap so nguyen duong");
                    txtN.Text = "";
                    txtN.Focus();
                    return;
                }
                //Kiem Tra so hoan hao
                int sum = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == n)
                {
                    txtSHH.Text = n.ToString() + " la so hoan hao";
                }
                else
                {
                    txtSHH.Text = n.ToString() + " khong phai so hoan hao";
                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtSHH.Text = "";
        }
        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
