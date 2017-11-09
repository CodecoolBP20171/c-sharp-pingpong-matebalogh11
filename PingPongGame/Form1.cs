using System.Windows.Forms;
using System.Media;

namespace PingPongGame
{
    public partial class Form1 : Form
    {
        bool over = false;
        int ballTop = 3;
        int ballLeft = 3;
        int score;
        int gameLevel = 1;
        bool increased = false;
        int temp = 0;
        int slideLeft;
        string sound1 = @"C:\Users\bmate\Documents\work\.NET module\TW_assignmets\c-sharp-pingpong-matebalogh11\PingPongGame\sounds\boing.wav";
        string sound2 = @"C:\Users\bmate\Documents\work\.NET module\TW_assignmets\c-sharp-pingpong-matebalogh11\PingPongGame\sounds\game_over.wav";
        SoundPlayer player1;
        SoundPlayer overSound;

        public Form1()
        {
            InitializeComponent();
            this.TopMost = true;
            slideLeft = slide.Left;
            player1 = new SoundPlayer(sound1);
            overSound = new SoundPlayer(sound2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
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
                if (board.Left < slide.Left) slideLeft -= 7;
            } else if (e.KeyCode == Keys.Right)
            {
                if (board.Right > slide.Right) slideLeft += 7;
            }
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            ball.Top += ballTop;
            ball.Left += ballLeft;
            slide.Left = slideLeft;

            //slide.Left = Cursor.Position.X - (slide.Width / 2);

            if (ball.Bottom >= slide.Top && ball.Bottom <= slide.Bottom && ball.Left >= slide.Left && ball.Right <= slide.Right)
            {
                player1.Play();
                score += 10;
                progressBar1.Value++;
                scoreBoard.Text = $"Score: {score}";
                ballTop = -ballTop;
            }
            if (ball.Left <= board.Left || ball.Right >= board.Right)
            {
                player1.Play();
                ballLeft = -ballLeft;
            }
            if (ball.Top <= board.Top)
            {
                player1.Play();
                ballTop = -ballTop;
            }
            if (ball.Bottom >= board.Bottom)
            {
                slide.Enabled = false;
                ball.Hide();
                overSound.Play();
                gameOver.Show();
                over = true;
                timer1.Enabled = false;
            }
            if (score % 30 == 0 && !increased && score > 0)
            {
                increased = true;
                progressBar1.Value = 0;
                ballLeft = (ballLeft > 0) ? ballLeft + 5 : ballLeft - 5;
                ballTop = (ballTop > 0) ? ballTop + 5 : ballTop - 5;
                temp = score;
                level.Text = $"Level: {++gameLevel}";
            }
            if (temp != score && increased) increased = false;
        }
    }
}
