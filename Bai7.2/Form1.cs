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
            LoadDirectories();
        }
        private void LoadDirectories()
        {
            treeViewDirectories.Nodes.Clear();
            string[] drives = Environment.GetLogicalDrives();
            foreach (string drive in drives)
            {
                TreeNode rootNode = new TreeNode(drive);
                rootNode.Tag = drive;
                rootNode.Nodes.Add("Loading...");
                treeViewDirectories.Nodes.Add(rootNode);
            }
        }
        private void treeViewDirectories_BeforeExpand(object sender, TreeViewCancelEventArgs e)
        {
            TreeNode node = e.Node;
            if (node.Nodes[0].Text == "Loading...")
            {
                node.Nodes.Clear();
                try
                {
                    string[] subDirs = Directory.GetDirectories(node.Tag.ToString());
                    foreach (string subDir in subDirs)
                    {
                        TreeNode subNode = new TreeNode(Path.GetFileName(subDir));
                        subNode.Tag = subDir;
                        subNode.Nodes.Add("Loading...");
                        node.Nodes.Add(subNode);
                    }
                }
                catch (UnauthorizedAccessException)
                {
                    MessageBox.Show("Không thể truy cập thư mục này.");
                }
            }
        }

        private void treeViewDirectories_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string selectedPath = e.Node.Tag.ToString();
            LoadImages(selectedPath);
        }
        private void LoadImages(string folderPath)
        {
            flowLayoutPanelImages.Controls.Clear();
            try
            {
                string[] imageFiles = Directory.GetFiles(folderPath, "*.*")
                                                .Where(f => f.EndsWith(".jpg") ||
                                                            f.EndsWith(".png") ||
                                                            f.EndsWith(".jpeg") ||
                                                            f.EndsWith(".bmp"))
                                                .ToArray();
                foreach (string file in imageFiles)
                {
                    PictureBox picBox = new PictureBox
                    {
                        Width = 100,
                        Height = 100,
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = CreateThumbnail(file, 100, 100),
                        Tag = file,
                        Margin = new Padding(5)
                    };
                    picBox.Click += PictureBox_Click;
                    flowLayoutPanelImages.Controls.Add(picBox);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi: {ex.Message}");
            }
        }

        private Image CreateThumbnail(string filePath, int width, int height)
        {
            using (var img = Image.FromFile(filePath))
            {
                return new Bitmap(img, new Size(width, height));
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox picBox && picBox.Tag is string filePath)
            {
                pictureBoxSelectedImage.Image = Image.FromFile(filePath);
            }
        }

    }
}
