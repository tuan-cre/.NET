using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode node = trvImage.Nodes.Add("Root", "Root");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            String folderpath = "C:\\Users\\Tuan\\Downloads\\Image";
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                folderpath = fbd.SelectedPath;
            }
        }
    }
}
