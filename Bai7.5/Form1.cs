using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7._5
{
    public partial class Form1 : Form
    {
        private bool isDrawing = false;
        private Point startPoint;
        private Point endPoint;
        private Color borderColor = Color.Black;
        private Color fillColor = Color.Transparent;
        private int borderSize = 1;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnBorderColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    borderColor = colorDialog.Color;
                    btnBorderColor.BackColor = borderColor;
                }
            }
        }
        private void btnFillColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    fillColor = colorDialog.Color;
                    btnFillColor.BackColor = fillColor;
                }
            }
        }

        private void DrawShape()
        {
            using (Graphics g = pnlCanvas.CreateGraphics())
            {
                int x = Math.Min(startPoint.X, endPoint.X);
                int y = Math.Min(startPoint.Y, endPoint.Y);
                int width = Math.Abs(startPoint.X - endPoint.X);
                int height = Math.Abs(startPoint.Y - endPoint.Y);

                Pen pen = new Pen(borderColor, borderSize);

                switch (cbShapeType.SelectedItem.ToString())
                {
                    case "Rectangle":
                        g.DrawRectangle(pen, x, y, width, height);
                        break;

                    case "Ellipse":
                        g.DrawEllipse(pen, x, y, width, height);
                        break;

                    case "Filled Rectangle":
                        g.FillRectangle(new SolidBrush(fillColor), x, y, width, height);
                        g.DrawRectangle(pen, x, y, width, height);
                        break;

                    case "Filled Ellipse":
                        g.FillEllipse(new SolidBrush(fillColor), x, y, width, height);
                        g.DrawEllipse(pen, x, y, width, height);
                        break;
                }
            }
        }
        private void nudBorderSize_ValueChanged(object sender, EventArgs e)
        {
            borderSize = (int)nudBorderSize.Value;
        }
        private void pnlCanvas_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDrawing = true;
                startPoint = e.Location;
            }
        }
        private void pnlCanvas_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && isDrawing)
            {
                isDrawing = false;
                endPoint = e.Location;

                DrawShape();
            }
        }
    }
}
