using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGiaiPhuongTrinhBac2_Click(object sender, EventArgs e)
        {
            double a = 0;
            double b = 0;
            double c = 0;

            try
            {
                a = double.Parse(txtHeSoA.Text);
                b = double.Parse(txtHeSoB.Text);
                c = double.Parse(txtHeSoC.Text);
            }
            catch (FormatException)
            {
                MessageBox.Show("So khong hop le!");
                return;
            }

            if (a == 0 && b == 0 && c == 0)
            {
                txtKetQua.Text = "Vo so nghiem";
            }
            else if (a == 0 && b == 0)
            {
                txtKetQua.Text = "Vo nghiem";
            }
            else if (a == 0)
            {
                txtKetQua.Text = (-c / b).ToString();
            }
            else
            {
                double delta= b * b - 4 * a * c;

                if (delta > 0)
                {
                    txtKetQua.Text = ((-b + Math.Sqrt(delta)) / (2 * a)).ToString() + ", " + ((-b - Math.Sqrt(delta)) / (2 * a)).ToString();
                }
                else if (delta == 0)
                {
                    txtKetQua.Text = (-b / (2 * a)).ToString();
                }
                else
                {
                    txtKetQua.Text = "Vo nghiem";
                }
            }
        }
    }
}
