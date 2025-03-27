using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hw_kp_5_a
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void textBoxA_TextChanged(object sender, EventArgs e)
        {
            double A = Convert.ToDouble(textBoxA.Text);
        }

        private void textBoxB_TextChanged(object sender, EventArgs e)
        {
            double B = Convert.ToDouble(textBoxB.Text);
        }

        private void textBoxC_TextChanged(object sender, EventArgs e)
        {
            double C = Convert.ToDouble(textBoxC.Text);
        }

        private void buttonDisc_Click(object sender, EventArgs e)
        {
            //di = b*b - 4*a*c = 
            //x = (-b + Math.Sqrt(di)) / (2 * a)
            //x = (-b - Math.Sqrt(di)) / (2 * a)
            double a = Convert.ToDouble(textBoxA.Text);
            double b = Convert.ToDouble(textBoxB.Text);
            double c = Convert.ToDouble(textBoxC.Text);
            double x1, x2;
            double d = b * b - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                labelX1.Text = Convert.ToString(x1);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);
                labelX2.Text = Convert.ToString(x2);
            }
            else if (d == 0)
            {
                x1 = (-b) / (2 * a);
                labelX1.Text = Convert.ToString(x1);
            }
            else
            {
                labelX1.Text = "нэт корней";
            }
        }
    }
}
