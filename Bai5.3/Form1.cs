using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            double ts1=1;
            double ms1=1;

            double ts2=1;
            double ms2=1;

            try
            {
                ts1 = double.Parse(txt1t.Text);
                ms1 = double.Parse(txt1m.Text);

                ts2 = double.Parse(txt2t.Text);
                ms2 = double.Parse(txt2m.Text);

                if (ms1 == 0 || ms2 == 0)
                {
                    MessageBox.Show("Mẫu số phải khác 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }

            double ts = ts1 * ms2 + ts2 * ms1;
            double ms = ms1 * ms2;

            if (ts == 0)
            {
                txtkqt.Text = "0";
                txtkqm.Text = "1";
            }
            else
            { 
                rutGonPS(ts, ms);
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            double ts1 = 1;
            double ms1 = 1;

            double ts2 = 1;
            double ms2 = 1;

            try
            {
                ts1 = double.Parse(txt1t.Text);
                ms1 = double.Parse(txt1m.Text);

                ts2 = double.Parse(txt2t.Text);
                ms2 = double.Parse(txt2m.Text);

                if (ms1 == 0 || ms2 == 0)
                {
                    MessageBox.Show("Mẫu số phải khác 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }

            double ts = ts1 * ms2 - ts2 * ms1;
            double ms = ms1 * ms2;

            if (ts == 0)
            {
                txtkqt.Text = "0";
                txtkqm.Text = "1";
            }
            else
            {
                rutGonPS(ts, ms);
            }
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double ts1 = 1;
            double ms1 = 1;

            double ts2 = 1;
            double ms2 = 1;

            try
            {
                ts1 = double.Parse(txt1t.Text);
                ms1 = double.Parse(txt1m.Text);

                ts2 = double.Parse(txt2t.Text);
                ms2 = double.Parse(txt2m.Text);

                if (ms1 == 0 || ms2 == 0)
                {
                    MessageBox.Show("Mẫu số phải khác 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }

            double ts = ts1 * ts2;
            double ms = ms1 * ms2;

            if (ts == 0)
            {
                txtkqt.Text = "0";
                txtkqm.Text = "1";
            }
            else
            {
                rutGonPS(ts, ms);
            }
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double ts1 = 1;
            double ms1 = 1;

            double ts2 = 1;
            double ms2 = 1;

            try
            {
                ts1 = double.Parse(txt1t.Text);
                ms1 = double.Parse(txt1m.Text);

                ts2 = double.Parse(txt2t.Text);
                ms2 = double.Parse(txt2m.Text);

                if (ms1 == 0 || ms2 == 0)
                {
                    MessageBox.Show("Mẫu số phải khác 0");
                    return;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Nhập sai dữ liệu");
            }

            double ts = ts1 * ms2;
            double ms = ms1 * ts2;

            if (ts == 0)
            {
                txtkqt.Text = "0";
                txtkqm.Text = "1";
            }
            else
            {
                rutGonPS(ts, ms);
            }
        }

        private void btnTiepTuc_Click(object sender, EventArgs e)
        {
            txt1t.Text = "";
            txt1m.Text = "";
            txt2t.Text = "";
            txt2m.Text = "";
            txtkqt.Text = "";
            txtkqm.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void rutGonPS(double ts, double ms)
        {
            //rut gon phan so
            double a = ts;
            double b = ms;
            while (a != b)
            {
                if (a > b)
                    a = a - b;
                else
                    b = b - a;
            }
            ts = ts / a;
            ms = ms / a;
            txtkqt.Text = ts.ToString();
            txtkqm.Text = ms.ToString();
        }
    }
}
