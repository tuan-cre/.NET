using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCheckPerfectNumber_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                MessageBox.Show("Hãy Nhập N");
                return;
            }
            Form2 form2 = new Form2();
            form2.N = int.Parse(txtN.Text);
            form2.ShowDialog();
            btnReset.Enabled = true;
        }

        private void btnCreateArray_Click(object sender, EventArgs e)
        {
            if (txtN.Text == "")
            {
                MessageBox.Show("Hãy Nhập N");
                return;
            }
            Form3 form3 = new Form3();
            form3.N = int.Parse(txtN.Text);
            form3.ShowDialog();
            btnReset.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnReset.Enabled = false;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
            txtN.Focus();
            btnReset.Enabled = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void kiểmTraSốHoànHảoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCheckPerfectNumber_Click(sender, e);
        }

        private void tạoMảngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnCreateArray_Click(sender, e);
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);   
        }
    }
}
