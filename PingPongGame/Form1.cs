using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        int ballTop = 5;
        int ballLeft = 5;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } else if (e.KeyCode == Keys.Space)
            {
                if (label1.Visible)
                {
                    label1.Hide();
                    textBox1.Enabled = true;
                    this.Focus();
                } else
                {
                    label1.Show();
                    textBox1.Enabled = false;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                textBox1.Left -= 10;
            } else if (e.KeyCode == Keys.Right)
            {
                textBox1.Left += 10;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            ball.Top += ballTop;
            ball.Left += ballLeft;

            if (ball.Bottom >= textBox1.Top && ball.Left >= textBox1.Left && ball.Right <= textBox1.Right)
            {
                ballTop = -ballTop;
                ballLeft = -ballLeft;
            }
        }
    }
}
