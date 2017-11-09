namespace PingPongGame
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.slide = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.board = new System.Windows.Forms.Panel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.gameOver = new System.Windows.Forms.Label();
            this.level = new System.Windows.Forms.Label();
            this.scoreBoard = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.board.SuspendLayout();
            this.SuspendLayout();
            // 
            // slide
            // 
            this.slide.BackColor = System.Drawing.Color.Black;
            this.slide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.slide.Location = new System.Drawing.Point(257, 558);
            this.slide.Name = "slide";
            this.slide.Size = new System.Drawing.Size(150, 13);
            this.slide.TabIndex = 0;
            this.slide.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label1.Location = new System.Drawing.Point(276, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Paused";
            this.label1.Visible = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ball.Location = new System.Drawing.Point(145, 139);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(15, 15);
            this.ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ball.TabIndex = 2;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // board
            // 
            this.board.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("board.BackgroundImage")));
            this.board.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.board.Controls.Add(this.progressBar1);
            this.board.Controls.Add(this.gameOver);
            this.board.Controls.Add(this.label1);
            this.board.Controls.Add(this.level);
            this.board.Controls.Add(this.scoreBoard);
            this.board.Dock = System.Windows.Forms.DockStyle.Fill;
            this.board.Location = new System.Drawing.Point(0, 0);
            this.board.Name = "board";
            this.board.Size = new System.Drawing.Size(709, 602);
            this.board.TabIndex = 3;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(602, 39);
            this.progressBar1.Maximum = 3;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(100, 13);
            this.progressBar1.TabIndex = 3;
            // 
            // gameOver
            // 
            this.gameOver.AutoSize = true;
            this.gameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gameOver.Location = new System.Drawing.Point(234, 85);
            this.gameOver.Name = "gameOver";
            this.gameOver.Size = new System.Drawing.Size(235, 46);
            this.gameOver.TabIndex = 2;
            this.gameOver.Text = "Game Over!";
            this.gameOver.Visible = false;
            // 
            // level
            // 
            this.level.AutoSize = true;
            this.level.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.level.Location = new System.Drawing.Point(614, 11);
            this.level.Name = "level";
            this.level.Size = new System.Drawing.Size(81, 25);
            this.level.TabIndex = 1;
            this.level.Text = "Level: 1";
            // 
            // scoreBoard
            // 
            this.scoreBoard.AutoSize = true;
            this.scoreBoard.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreBoard.Location = new System.Drawing.Point(11, 11);
            this.scoreBoard.Name = "scoreBoard";
            this.scoreBoard.Size = new System.Drawing.Size(86, 25);
            this.scoreBoard.TabIndex = 0;
            this.scoreBoard.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(709, 602);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.slide);
            this.Controls.Add(this.board);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "PingPong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.board.ResumeLayout(false);
            this.board.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox slide;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel board;
        private System.Windows.Forms.Label scoreBoard;
        private System.Windows.Forms.Label level;
        private System.Windows.Forms.Label gameOver;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

