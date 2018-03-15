using Nakov.TurtleGraphics;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_GraphicalTurtleApp
{
    public partial class FormTurtleGraphics : Form
    {
        private int delay = 200;
        private int spiralMove = 10;

        public FormTurtleGraphics()
        {
            InitializeComponent();
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Blue;
            
            // Draw a equilateral triangle
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);

            // Draw a line in the triangle
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(50);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(150);
            Turtle.PenDown();
            Turtle.Rotate(30);
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
            this.spiralMove = 10;
        }

        private void buttonShowHideTurtle_Click(object sender, EventArgs e)
        {
            string currentText = string.Empty;
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle = false;
                currentText = "Show Turtle";
            }
            else
            {
                Turtle.ShowTurtle = true;
                currentText = "Hide Turtle";
            }

            this.buttonShowHideTurtle.Text = currentText;
        }

        private void buttonDrawHexagon_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Blue;

            for (int i = 1; i <= 6; i++)
            {
                Turtle.Rotate(60);
                Turtle.Forward(100);
            }
        }

        private void buttonDrawStar_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Green;

            for (int i = 1; i <= 5; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(144);
            }
        }

        private void buttonDrawSpiral_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Blue;

            for (int i = 0; i < 8; i++)
            {
                Turtle.Forward(this.spiralMove);
                Turtle.Rotate(60);
                this.spiralMove += 10;
            }
        }

        private void buttonDrawSun_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Blue;

            for (int i = 1; i <= 36; i++)
            {
                Turtle.Forward(200);
                Turtle.Rotate(170);
                Turtle.Forward(200);
            }
        }

        private void buttonDrawSpiralTriangle_Click(object sender, EventArgs e)
        {
            // Assign a delay to visualize the drawing process
            Turtle.Delay = this.delay;
            Turtle.PenColor = Color.Red;
            int spiralTriangleMove = 10;

            for (int i = 1; i <= 22; i++, spiralTriangleMove += 10)
            {
                Turtle.Forward(spiralTriangleMove);
                Turtle.Rotate(120);
            }
        }
    }
}
