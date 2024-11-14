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

namespace Bai6._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ListViewItem item = new ListViewItem(txbMaSV.Text);
            item.SubItems.Add(txbHoTen.Text);
            item.SubItems.Add(txbDiaChi.Text);
            item.SubItems.Add(dtNgaySinh.Text);
            item.SubItems.Add(cbLop.Text);
            lvThongTin.Items.Add(item);
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lvThongTin.Items.Clear();
        }
    }
}
