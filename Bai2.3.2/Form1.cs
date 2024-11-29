using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTimThang_Click(object sender, EventArgs e)
        {
            int month = int.Parse(txtThang.Text);

            if (month >= 1 && month <= 3)
            {
                MessageBox.Show("Mùa xuân");
            }
            else if (month >= 4 && month <= 6)
            {
                MessageBox.Show("Mùa hạ");
            }
            else if (month >= 7 && month <= 9)
            {
                MessageBox.Show("Mùa thu");
            }
            else if (month >= 10 && month <= 12)
            {
                MessageBox.Show("Mùa đông");
            }
            else
            {
                MessageBox.Show("Tháng không hợp lệ");
            }
        }
    }
}
