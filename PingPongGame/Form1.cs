using System.Windows.Forms;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        bool over = false;
        int ballTop = 5;
        int ballLeft = 5;
        int score;
        int gameLevel = 1;
        bool increased = false;
        int temp = 0;
        int slideLeft;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            slideLeft = slide.Left;
        }
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            } else if (e.KeyCode == Keys.Space && !over)
            {
                if (label1.Visible)
                {
                    label1.Hide();
                    timer1.Enabled = true;
                    this.Focus();
                } else
                {
                    label1.Show();
                    timer1.Enabled = false;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                slideLeft -= 10;
            } else if (e.KeyCode == Keys.Right)
            {
                slideLeft += 10;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {

            ball.Top += ballTop;
            ball.Left += ballLeft;
            slide.Left = slideLeft;

            if (ball.Bottom >= slide.Top && ball.Bottom <= slide.Bottom && ball.Left >= slide.Left && ball.Right <= slide.Right)
            {
                score += 10;
                scoreBoard.Text = $"Score: {score}"; 
                ballTop = -ballTop;
            }
            if (ball.Left <= board.Left || ball.Right >= board.Right)
            {
                ballLeft = -ballLeft;
            }
            if (ball.Top <= board.Top)
            {
                ballTop = -ballTop;
            }
            if (ball.Bottom >= board.Bottom)
            {
                slide.Enabled = false;
                ball.Hide();
                gameOver.Show();
                over = true;
            }
            if (score % 30 == 0 && !increased && score > 0)
            {
                increased = true;
                ballLeft = (ballLeft > 0) ? ballLeft + 5 : ballLeft - 5;
                ballTop = (ballTop > 0) ? ballTop + 5 : ballTop - 5;
                temp = score;
                level.Text = $"Level: {++gameLevel}";
            }
            if (temp != score && increased) increased = false;
        }
    }
}
