using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._4
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
            item.SubItems.Add(dtNgaySinh.Text);
            if (rdNam.Checked)
            {
                item.SubItems.Add("Nam");
            }
            else
            {
                item.SubItems.Add("Nữ");
            }
            item.SubItems.Add(txbDienThoai.Text);
            item.SubItems.Add(cbQueQuan.Text);
            lvThongTin.Items.Add(item);
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            lvThongTin.Items.Remove(lvThongTin.SelectedItems[0]);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
           

        }
        private void lvThongTin_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            try
            {
                txbMaSV.Text = lvThongTin.SelectedItems[0].SubItems[0].Text;
                txbHoTen.Text = lvThongTin.SelectedItems[0].SubItems[1].Text;
                dtNgaySinh.Text = lvThongTin.SelectedItems[0].SubItems[2].Text;
                if (lvThongTin.SelectedItems[0].SubItems[3].Text == "Nam")
                {
                    rdNam.Checked = true;
                }
                else
                {
                    rdNu.Checked = true;
                }
                txbDienThoai.Text = lvThongTin.SelectedItems[0].SubItems[4].Text;
                cbQueQuan.Text = lvThongTin.SelectedItems[0].SubItems[5].Text;
            }
            catch { }
        }
    }
}
