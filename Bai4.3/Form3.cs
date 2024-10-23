using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form3 : Form
    {
        public Form3(int[] array, int size)
        {
            InitializeComponent();
            TaoMang(array, size);
        }

        int[] c;
        int l;

        public int[] C { get => c; set => c = value; }
        public int L { get => l; set => l = value; }

        public void TaoMang(int[] array, int size)
        {
            C = array;
            L = size;
        }

        public void TimMax(int[] array, int size)
        {
            int max = c.Max();
            lblKQ.Text = "Phần tử lớn nhất của mảng = " + max;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            TaoMang(C, L);
            TimMax(C, L);
        }
    }
}
