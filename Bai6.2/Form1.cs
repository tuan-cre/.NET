using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int LopIndex = 0;
        int BoxIndex = 0;

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbHoten.Text == "")
            {
                MessageBox.Show("Chưa nhập tên kìa ku!");
                return;
            }
            if (LopIndex == 1)
            {
                lbLopA.Items.Add(txbHoten.Text);
            }
            else if (LopIndex == 2)
            {
                lbLopB.Items.Add(txbHoten.Text);
            }
            else
                MessageBox.Show("Chưa chọn lớp kìa ku!");
        }

        private void rdLopA_CheckedChanged(object sender, EventArgs e)
        {
            LopIndex = 1;
        }

        private void rdLopB_CheckedChanged(object sender, EventArgs e)
        {
            LopIndex = 2;
        }

        private void btnA_B_Click(object sender, EventArgs e)
        {
            if (lbLopA.SelectedItem == null)
            {
                return;
            }
            else if (lbLopB.SelectedItem != null)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lbLopA.SelectedItems.Count; i++)
                {
                    lbLopB.Items.Add(lbLopA.SelectedItems[i]);
                    lbLopA.Items.Remove(lbLopA.SelectedItems[i]);
                    i--;
                }
            }    
        }

        private void btnB_A_Click(object sender, EventArgs e)
        {
            if (lbLopB.SelectedItem == null)
            {
                return;
            }
            else if (lbLopA.SelectedItem != null)
            {
                return;
            }
            else
            {
                for (int i = 0; i < lbLopB.SelectedItems.Count; i++)
                {
                    lbLopA.Items.Add(lbLopB.SelectedItems[i]);
                    lbLopB.Items.Remove(lbLopB.SelectedItems[i]);
                    i--;
                }
            }
        }

        private void btnA_B_All_Click(object sender, EventArgs e)
        {
            String[] temp = new String[lbLopA.Items.Count];
            lbLopA.Items.CopyTo(temp, 0);
            lbLopA.Items.Clear();
            lbLopB.Items.AddRange(temp);
        }

        private void btnB_A_All_Click(object sender, EventArgs e)
        {
            String[] temp = new String[lbLopB.Items.Count];
            lbLopB.Items.CopyTo(temp, 0);
            lbLopB.Items.Clear();
            lbLopA.Items.AddRange(temp);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int Tong = lbLopA.Items.Count + lbLopB.Items.Count;
            MessageBox.Show("Tổng số sinh viên 2 lớp là: " + Tong);
        }
    }
}
