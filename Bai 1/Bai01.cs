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

namespace Bai01
{
    public partial class FormBai01 : Form
    {
        public FormBai01()
        {
            InitializeComponent();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int c = 0;

            try
            {
                a = int.Parse(txtA.Text);
                b = int.Parse(txtB.Text);
                c = int.Parse(txtC.Text);
            }
            catch (Exception)
            {
                MessageBox.Show("Vui long nhap so nguyen", "Loi gia tri", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (a > b)
            {
                if (a > c)
                {
                    txtSoLonNhat.Text = a.ToString();
                    if (b > c)
                    {
                        txtSoNhoNhat.Text = c.ToString();
                    }
                    else
                    {
                        txtSoNhoNhat.Text = b.ToString();
                    }
                }
                else
                {
                    txtSoLonNhat.Text = c.ToString();
                    txtSoNhoNhat.Text = b.ToString();
                }

            }
            else
            {
                if (b > c)
                {
                    txtSoLonNhat.Text = b.ToString();
                    if (a > c)
                    {
                        txtSoNhoNhat.Text = c.ToString();
                    }
                    else
                    {
                        txtSoNhoNhat.Text = a.ToString();
                    }
                }
                else
                {
                    txtSoLonNhat.Text = c.ToString();
                    txtSoNhoNhat.Text = a.ToString();
                }
            }

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
