using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai8
{
    public partial class Form3 : Form
    {
        public Form3(int dai, int rong)
        {
            InitializeComponent();
            this.dai = dai;
            this.rong = rong;
        }
        int dai, rong;

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = (dai * rong).ToString();
            txtChuVi.Text = ((dai + rong) * 2).ToString();
        }
    }
}
