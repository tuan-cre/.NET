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

namespace Bai_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCal_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int result;
            if (x >= 2)
            {
                result = -8 * x * x * x - 12 * x - 1;
            }
            else if (1 < x && x < 2)
            {
                result = x * x - 6 * x - 10;
            }
            else
            {
                result = 7 * x;
            }
            txtF.Text = result.ToString();
        }
    }
}
