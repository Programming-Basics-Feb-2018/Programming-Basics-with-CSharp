using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _14_Desktop_BGN_to_EUR_Convertor_App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void numericUpDown1_KeyUp(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            ConvertCurrency();
        }

        private void ConvertCurrency()
        {
            var amountBGN = this.numericUpDownNumeric.Value;
            var amountEUR = amountBGN / 1.95583m;
            this.labelResult.Text =
              amountBGN + " BGN = " +
              Math.Round(amountEUR, 2) + " EUR";
        }
    }
}
