using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4._3
{
    public partial class Form2 : Form
    {
        public Form2(int[] array, int size)
        {
            InitializeComponent();
            TaoMang(array, size);
        }

        int[] b;
        int k;

        public int[] B { get => b; set => b = value; }
        public int K { get => k; set => k = value; }

        public void TaoMang(int[] array, int size)
        {
            B = array;
            K = size;
        }

        public void TongMang(int[] array, int size) {
            int sum = 0;
            for (int i = 0; i < size; i++)
            {
                sum += array[i];
            }
            lblKQ.Text = "Tổng các phần tử trong mảng = " + sum;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            TaoMang(B, K);
            TongMang(B, K);
        }
    }
}