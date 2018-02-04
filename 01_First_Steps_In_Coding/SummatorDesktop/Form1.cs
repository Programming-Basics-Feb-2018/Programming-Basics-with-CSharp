using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SummatorDesktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculate_Click(object sender, EventArgs e)
        {
            var numA = this.numA.Text;
            var numB = this.numB.Text;

            try
            {
                var parsedNumA = decimal.Parse(numA);
                var parsedNumB = decimal.Parse(numB);
                this.sum.Text = (parsedNumA + parsedNumB).ToString();
            }
            catch (Exception)
            {
                this.sum.Text = "Извинявай, пробвай пак!";
            }
        }
    }
}
