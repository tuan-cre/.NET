using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai02
{
    public partial class Bai02 : Form
    {
        public Bai02()
        {
            InitializeComponent();
        }

        private void txtSoNguyen_KeyPress(object sender, KeyPressEventArgs e)
        {
            int n = 0;
            if (e.KeyChar == (char)Keys.Enter)
            {
                txtKetQua.ForeColor = Color.Black;
                try
                {
                    n = int.Parse(txtSoNguyen.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Vui lòng nhập số nguyên", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtSoNguyen.Focus();
                    return;
                }

                switch (n)
                {
                    case 0:
                        txtKetQua.Text = "Không";
                        break;
                    case 1:
                        txtKetQua.Text = "Một";
                        break;
                    case 2:
                        txtKetQua.Text = "Hai";
                        break;
                    case 3:
                        txtKetQua.Text = "Ba";
                        break;
                    case 4:
                        txtKetQua.Text = "Bốn";
                        break;
                    case 5:
                        txtKetQua.Text = "Năm";
                        break;
                    case 6:
                        txtKetQua.Text = "Sáu";
                        break;
                    case 7:
                        txtKetQua.Text = "Bảy";
                        break;
                    case 8:
                        txtKetQua.Text = "Tám";
                        break;
                    case 9:
                        txtKetQua.Text = "Chín";
                        break;
                    default:
                        txtKetQua.Text = "Không phải số nguyên từ 0 đến 9";
                        txtKetQua.ForeColor = Color.Red;
                        break;
                }
            }
        }
    }
}
