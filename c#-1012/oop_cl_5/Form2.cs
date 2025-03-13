using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oop_cl_5
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonSum_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int sum = num1 + num2;
            labelResult.Text = sum.ToString();

        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int minus = num1 - num2;
            labelResult.Text = minus.ToString();

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
        }

        private void buttonDiv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBoxNum1.Text);
            double num2 = Convert.ToInt32(textBoxNum2.Text);
            double div = num1 / num2;
            labelResult.Text = div.ToString();
        }
    }
}
