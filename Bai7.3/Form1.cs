using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7._3
{
    public partial class Form1 : Form
    {
        private string[] imageFiles;
        private int currentIndex = 0; 
        private Timer slideshowTimer;

        public Form1()
        {
            InitializeComponent();
            slideshowTimer = new Timer();
            slideshowTimer.Interval = 2000;
            slideshowTimer.Tick += SlideshowTimer_Tick;
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedPath = folderBrowserDialog1.SelectedPath;
                imageFiles = Directory.GetFiles(selectedPath, "*.*")
                                      .Where(f => f.EndsWith(".jpg", StringComparison.OrdinalIgnoreCase) ||
                                                  f.EndsWith(".png", StringComparison.OrdinalIgnoreCase) ||
                                                  f.EndsWith(".jpeg", StringComparison.OrdinalIgnoreCase) ||
                                                  f.EndsWith(".bmp", StringComparison.OrdinalIgnoreCase))
                                      .ToArray();

                if (imageFiles.Length > 0)
                {
                    currentIndex = 0;
                    DisplayImage();
                }
                else
                {
                    MessageBox.Show("Thư mục không chứa ảnh!");
                }
            }
        }
        private void DisplayImage()
        {
            if (imageFiles != null && imageFiles.Length > 0 && currentIndex >= 0 && currentIndex < imageFiles.Length)
            {
                pictureBoxMain.Image?.Dispose();
                pictureBoxMain.Image = Image.FromFile(imageFiles[currentIndex]);
            }
        }
        private void btnPrev_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex - 1 + imageFiles.Length) % imageFiles.Length;
                DisplayImage();
            }
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                currentIndex = (currentIndex + 1) % imageFiles.Length;
                DisplayImage();
            }
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (imageFiles != null && imageFiles.Length > 0)
            {
                slideshowTimer.Start();
            }
            else
            {
                MessageBox.Show("Vui lòng mở danh sách hình trước khi bắt đầu slideshow!");
            }
        }

        private void SlideshowTimer_Tick(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            slideshowTimer.Stop();
            Application.Exit();
        }
    }
}
