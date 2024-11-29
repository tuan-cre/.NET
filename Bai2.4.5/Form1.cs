using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_4._5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtN.Text);

            int tong = 0;
            for (int i = 1; i <= 2*n; i++)
            {
                if (i % 2 == 0)
                {
                    tong += i;
                }
            }
            txtS.Text = tong.ToString();
        }
    }
}
