using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Point_in_Rectangle
{
    public partial class FormPointAndRectangle : System.Windows.Forms.Form
    {
        public FormPointAndRectangle()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Draw();
        }
        
        private void FormPointAndRectangle_Load(object sender, EventArgs e)
        {
            Draw();
        }

        private void FormPointAndRectangle_Resize(object sender, EventArgs e)
        {
            Draw();
        }

        private void Draw()
        {
            // Get the rectangle and point coordinates from the form
            decimal x1 = this.numericUpDownX1.Value;
            decimal y1 = this.numericUpDownY1.Value;
            decimal x2 = this.numericUpDownX2.Value;
            decimal y2 = this.numericUpDownY2.Value;
            decimal x = this.numericUpDownX.Value;
            decimal y = this.numericUpDownY.Value;

            // Display the location of the point: Inside / Border / Outside
            DisplayPointLocation(x1, y1, x2, y2, x, y);

            // Calculate the scale factor (ratio) for the diagram holding the
            // rectangle and point in order to fit them well in the picture box
            decimal minX = Min(x1, x2, x);
            decimal maxX = Max(x1, x2, x);
            decimal minY = Min(y1, y2, y);
            decimal maxY = Max(y1, y2, y);
            decimal diagramWidth = maxX - minX;
            decimal diagramHeight = maxY - minY;
            decimal ratio = 1.0m;
            int offset = 10;
            if (diagramWidth != 0 && diagramHeight != 0)
            {
                decimal ratioX = (pictureBox.Width - 2 * offset - 1) / diagramWidth;
                decimal ratioY = (pictureBox.Height - 2 * offset - 1) / diagramHeight;
                ratio = Math.Min(ratioX, ratioY);
            }

            // Calculate the scaled rectangle coordinates
            int rectLeft = offset + (int)Math.Round((Math.Min(x1, x2) - minX) * ratio);
            int rectTop = offset + (int)Math.Round((Math.Min(y1, y2) - minY) * ratio);
            int rectWidth = (int)Math.Round(Math.Abs(x2 - x1) * ratio);
            int rectHeight = (int)Math.Round(Math.Abs(y2 - y1) * ratio);
            Rectangle rect = new Rectangle(rectLeft, rectTop, rectWidth, rectHeight);

            // Calculate the scalled point coordinates
            int pointX = (int)Math.Round(offset + (x - minX) * ratio);
            int pointY = (int)Math.Round(offset + (y - minY) * ratio);
            Rectangle pointRect = new Rectangle(pointX - 2, pointY - 2, 5, 5);

            // Draw the rectangle and point
            pictureBox.Image = new Bitmap(pictureBox.Width, pictureBox.Height);
            using (Graphics g = Graphics.FromImage(pictureBox.Image))
            {
                // Draw diagram background (white area)
                g.Clear(Color.White);

                // Draw the rectangle (scalled to the picture box size)
                Pen pen = new Pen(Color.Blue, 3);
                g.DrawRectangle(pen, rect);

                // Draw the point (scalled to the picture box size)
                pen = new Pen(Color.DarkBlue, 5);
                g.DrawEllipse(pen, pointRect);
            }
        }

        private void DisplayPointLocation(decimal x1, decimal y1, decimal x2, decimal y2, decimal x, decimal y)
        {
            decimal left = Math.Min(x1, x2);
            decimal right = Math.Max(x1, x2);
            decimal top = Math.Min(y1, y2);
            decimal bottom = Math.Max(y1, y2);
            if (x > left && x < right && y > top && y < bottom)
            {
                this.labelLocation.Text = "Inside";
                this.labelLocation.BackColor = Color.LightGreen;
            }
            else if (x < left || x > right || y < top || y > bottom)
            {
                this.labelLocation.Text = "Outside";
                this.labelLocation.BackColor = Color.LightSalmon;
            }
            else
            {
                this.labelLocation.Text = "Border";
                this.labelLocation.BackColor = Color.Gold;
            }
        }

        private decimal Min(decimal val1, decimal val2, decimal val3)
        {
            return Math.Min(val1, Math.Min(val2, val3));
        }

        private decimal Max(decimal val1, decimal val2, decimal val3)
        {
            return Math.Max(val1, Math.Max(val2, val3));
        }
    }
}
