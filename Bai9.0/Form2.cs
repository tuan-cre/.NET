using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public int N;

        private void Form2_Load(object sender, EventArgs e)
        {
            lbKetQua.Text = N + (IsPerfectNumber(N) ? " " : " không ") + "là số hoàn hảo";
        }

        private bool IsPerfectNumber(int n)
        {
            if (n == 0) {
                return false;
            }
            int sum = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                {
                    sum += i;
                }
            }
            return sum == n;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
