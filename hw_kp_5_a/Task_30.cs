using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace hw_kp_5_a
{
    public partial class Task_30 : Form
    {
        public Task_30()
        {
            InitializeComponent();
        }

        private void textBoxR_TextChanged(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(textBoxR.Text);
        }

        private void buttonS_calc_Click(object sender, EventArgs e)
        {
            double R = Convert.ToDouble(textBoxR.Text);
            labelS_answer.Text = Convert.ToString(Math.Round(Math.PI * R * R));
        }

        private void buttonCirc_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(Convert.ToInt32(textBoxR.Text), new Point(Convert.ToInt32(textBoxX.Text), Convert.ToInt32(textBoxY.Text)));
            listBoxCirc.Items.Add(circle);
        }

        private void buttonTest_drow_Click(object sender, EventArgs e)
        {
            Graphics graphics = panel3.CreateGraphics();
            for (int i = 0; i < 11; i++)
            {
                Random random = new Random();
                int x = random.Next(50);
                int y = random.Next(50);
                int h = random.Next(500);
                int w = random.Next(500);
                int cl1 = random.Next(255);
                int cl2 = random.Next(255);
                int cl3 = random.Next(255);
                Color color = Color.FromArgb(cl1, cl2, cl3);
                graphics.DrawRectangle(new Pen(color, 5), x, y, h, w);
            }
            
        }
    }
}
