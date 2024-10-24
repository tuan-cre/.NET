﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai5._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void txtN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                int n;

                try
                {
                    n = int.Parse(txtN.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("Nhap so nguyen duong");
                    txtN.Text = "";
                    txtN.Focus();
                    return;
                }

                if (n < 2)
                {
                    txtSNT.Text = n.ToString() + " khong phai so nguyen to";
                    return;
                }

                txtSNTN.Text = "";
                if (n > 2)
                    txtSNTN.Text += "2 ";

                for (int i = 2; i < n; i++)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            break;
                        }
                        if (j == i - 1)
                        {
                            txtSNTN.Text += i.ToString() + " ";
                        }
                    }
                }

                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        txtSNT.Text = n.ToString() + " khong phai so nguyen to";
                        return;
                    }
                }

                txtSNT.Text = n.ToString() + " la so nguyen to";
                return;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSNTN.Text = "";
            txtSNT.Text = "";
            txtN.Text = "";
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
