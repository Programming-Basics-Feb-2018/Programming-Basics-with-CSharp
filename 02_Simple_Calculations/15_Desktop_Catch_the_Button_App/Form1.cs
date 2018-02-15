using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _15_Desktop_Catch_the_Button_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void catchMeButton_MouseEnter(object sender, EventArgs e)
        {
            Random rand = new Random();
            int maxWidth = this.ClientSize.Width - this.catchMeButton.ClientSize.Width;
            int maxHeight = this.ClientSize.Height - this.catchMeButton.ClientSize.Height;
            this.catchMeButton.Location = new Point(
                rand.Next(maxWidth), rand.Next(maxHeight));

        }

        private void catchMeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You win!", "Congratulations");
        }
    }
}
