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
    public partial class Form2 : Form
    {
        public Form2(int canh)
        {
            InitializeComponent();
            this.canh = canh;
        }
        int canh;

        private void Form2_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = (canh * canh).ToString();
            txtChuVi.Text = (canh * 4).ToString();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form2.ActiveForm.Close();
        }
    }
}
