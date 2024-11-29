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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtCanh.Focus();
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            rb1.Checked = true;
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Text = "";
            txtDai.Text = "";
            txtRong.Text = "";
            txtBanKinh.Text = "";
            txtCanh.Enabled = true;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Enabled = false;
            txtCanh.Focus();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Text = "";
            txtDai.Text = "";
            txtRong.Text = "";
            txtBanKinh.Text = "";
            txtDai.Enabled = true;
            txtRong.Enabled = true;
            txtCanh.Enabled = false;
            txtBanKinh.Enabled = false;
            txtDai.Focus();

        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            txtCanh.Text = "";
            txtDai.Text = "";
            txtRong.Text = "";
            txtBanKinh.Text = "";
            txtBanKinh.Enabled = true;
            txtCanh.Enabled = false;
            txtDai.Enabled = false;
            txtRong.Enabled = false;
            txtBanKinh.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rb1.Checked)
            {
                if (txtCanh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập cạnh", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtCanh.Focus();
                    return;
                }
                int canh = int.Parse(txtCanh.Text);
                Form2 form2 = new Form2(canh);
                form2.ShowDialog();
            }
            else if (rb2.Checked) {
                if (txtDai.Text == "" || txtRong.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập chiều dài hoặc chiều rộng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtDai.Focus();
                    return;
                }
                int dai = int.Parse(txtDai.Text);
                int rong = int.Parse(txtRong.Text);
                Form3 form3 = new Form3(dai, rong);
                form3.ShowDialog();
            }
            else if (rb3.Checked)
            {
                if (txtBanKinh.Text == "")
                {
                    MessageBox.Show("Bạn chưa nhập bán kính", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtBanKinh.Focus();
                    return;
                }
                int banKinh = int.Parse(txtBanKinh.Text);
                Form4 form4 = new Form4(banKinh);
                form4.ShowDialog();
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            btnThucHien_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnThoat_Click(sender, e);
        }
    }
}
