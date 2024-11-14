using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txbHo.Text == "" || txbTen.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ họ và tên");
                return;
            }
            String ten = txbTen.Text;
            String ho = txbHo.Text;

            try 
            {
                TreeNode node = trvHoTen.Nodes.Find("nd" + ten[0], false)[0];
                node.Nodes.Add(ten + ", " + ho);
            }
            catch
            {
                MessageBox.Show("Nhập sai định dạng tên!"); 
            }
            
            txbHo.Text = "";
            txbTen.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
