using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Bai6._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int colorIndex = 0;
        int fontIndex = 0;

        private void btnFont_Click(object sender, EventArgs e)
        {
            switch (fontIndex)
            {
                case 0:
                    txbDialog.Font = new Font("Arial", 12, FontStyle.Bold);
                    fontIndex++;
                    break;
                case 1:
                    txbDialog.Font = new Font("Times New Roman", 12, FontStyle.Bold);
                    fontIndex++;
                    break;
                case 2:
                    txbDialog.Font = new Font("Comic Sans MS", 12, FontStyle.Bold);
                    fontIndex++;
                    break;
                case 3:
                    txbDialog.Font = new Font("Consolas", 12, FontStyle.Bold);
                    fontIndex++;
                    break;
                default:
                    txbDialog.Font = new Font("Consolas", 12, FontStyle.Bold);
                    fontIndex = 0;
                    break;
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            switch (colorIndex)
            {
                case 0:
                    txbDialog.ForeColor = Color.Red;
                    colorIndex++;
                    break;
                case 1:
                    txbDialog.ForeColor = Color.Orange;
                    colorIndex++;
                    break;
                case 2:
                    txbDialog.ForeColor = Color.Yellow;
                    colorIndex++;
                    break;
                case 3:
                    txbDialog.ForeColor = Color.Green;
                    colorIndex++;
                    break;
                case 4:
                    txbDialog.ForeColor = Color.Blue;
                    colorIndex++;
                    break;
                case 5:
                    txbDialog.ForeColor = Color.Gray;
                    colorIndex++;
                    break;
                case 6:
                    txbDialog.ForeColor = Color.Purple;
                    colorIndex++;
                    break;
                case 7:
                    txbDialog.ForeColor = Color.Black;
                    colorIndex++;
                    break;
                default:
                    txbDialog.ForeColor = Color.Black;
                    colorIndex = 0;
                    break;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            FileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                txbDialog.Text = System.IO.File.ReadAllText(fileDialog.FileName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txbDialog.Text == "")
            {
                MessageBox.Show("Có cái dell j đâu mà lưu!");
                return;
            }
            FileDialog fileDialog = new SaveFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.WriteAllText(fileDialog.FileName, txbDialog.Text);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
