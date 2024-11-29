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
    public partial class Form4 : Form
    {
        public Form4(int banKinh)
        {
            InitializeComponent();
            this.banKinh = banKinh;
        }
        int banKinh;

        private void btnDong_Click(object sender, EventArgs e)
        {
            Form4.ActiveForm.Close();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            txtDienTich.Text = Math.Round(Math.PI * banKinh * banKinh, 1).ToString();
            txtChuVi.Text = Math.Round(2 * Math.PI * banKinh, 1).ToString();
        }
    }
}
