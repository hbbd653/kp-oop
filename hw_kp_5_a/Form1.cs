namespace hw_kp_5_a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int sum = num1 + num2;
            labelResult.Text = sum.ToString();
        }

        private void buttonMInus_Click(object sender, EventArgs e)
        {
            int num1 = Convert.ToInt32(textBoxNum1.Text);
            int num2 = Convert.ToInt32(textBoxNum2.Text);
            int minus = num1 - num2;
            labelResult.Text = minus.ToString();
        }

        private void buttonDIv_Click(object sender, EventArgs e)
        {
            double num1 = Convert.ToInt32(textBoxNum1.Text);
            double num2 = Convert.ToInt32(textBoxNum2.Text);
            double div = num1 / num2;
            labelResult.Text = div.ToString();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            labelResult.Text = "";
            textBoxNum1.Text = "";
            textBoxNum2.Text = "";
        }

        private void buttonColor_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            this.BackColor = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
        }

        private void panelMouse_MouseEnter(object sender, EventArgs e)
        {
            label1.Text = "мышка";
        }

        private void panelMouse_MouseLeave(object sender, EventArgs e)
        {
            label1.Text = "";
        }
    }
}
