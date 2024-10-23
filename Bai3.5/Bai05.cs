using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai05
{
    public partial class Bai05 : Form
    {
        public Bai05()
        {
            InitializeComponent();
        }

        private void btnTinhDiem_Click(object sender, EventArgs e)
        {
            double Toan = 0;
            double Ly = 0;
            double Hoa = 0;
            double Van = 0;
            double Su = 0;
            double Dia = 0;

            if (txtHoLot.Text == "" || txtTen.Text == "")
            {
                MessageBox.Show(Text = "Vui lòng nhập họ tên");
            }
            else
            {
                try
                {
                    Toan = double.Parse(txtToan.Text);
                    Ly = double.Parse(txtLy.Text);
                    Hoa = double.Parse(txtHoa.Text);
                    Van = double.Parse(txtVan.Text);
                    Su = double.Parse(txtSu.Text);
                    Dia = double.Parse(txtDia.Text);
                    if (Toan < 0 || Toan > 10 || Ly < 0 || Ly > 10 || Hoa < 0 || Hoa > 10 || Van < 0 || Van > 10 || Su < 0 || Su > 10 || Dia < 0 || Dia > 10)
                        MessageBox.Show(Text = "Điểm không hợp lệ");
                    else
                    {
                        double diemTB = (Toan * 2 + Van * 2 + Ly + Hoa + Su + Dia) / 8;
                        txtDiemTB.Text = diemTB.ToString();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show(Text = "Vui lòng nhập điểm");
                }
            }
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Bai05.ActiveForm.Close();
        }
    }
}
