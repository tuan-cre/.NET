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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public int N;
        public int[] A;

        private void Form3_Load(object sender, EventArgs e)
        {
            createRandomArray();
            for (int i = 0; i < N; i++)
            {
                txtArray.Text += A[i] + " ";
            }

            for (int i = 0; i < N; i++)
            {
                if (A[i] % 2 == 0)
                {
                    txtEven.Text += A[i] + " ";
                }
            }


        }

        private void createRandomArray()
        {
            Random random = new Random();
            A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = random.Next(N, N+12);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form3.ActiveForm.Close();
        }
    }
}
