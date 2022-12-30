namespace Trex_Endless_Runner
{
    public partial class Form1 : Form
    {
        bool jumping = false;
        int jumpSpeed;
        int force = 12;
        int score = 0;
        int obstacleSpeed = 10;
        Random rand = new Random();
        int position;
        bool isGameOver = false;
        public Form1()
        {
            InitializeComponent();
            GameReset();
        }

        private void MainGameEventTimer(object sender, EventArgs e)
        {
            Trex.Top += jumpSpeed;
            txtScore.Text = "Score :" + score;
            if (jumping == true && force < 0)
            {
                jumping = false;
            }
            if (jumping == true)
            {
                jumpSpeed = -12;
                force -= 1;
            }
            else
            {
                jumpSpeed = 12;
            }
            if (Trex.Top > 443 && jumping == false)
            {
                force = 12;
                Trex.Top = 444;
                jumpSpeed = 0;
            }
            foreach(Control x in this.Controls)
            {
                if(x is PictureBox &&(string)x.Tag =="obstacle")
                {
                    x.Left -= obstacleSpeed;`
                    if(x.Left<-100)
                    {
                        x.Left = this.ClientSize.Width + rand.Next(200, 700) + (x.Width * 15);
                        score++;
                    }
                    if (Trex.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameTimer.Stop();
                        Trex.Image = Properties.Resources.dead;
                        txtScore.Text += "    Press 'R' to restart the game";
                        isGameOver = true;
                    }
                }
            }

            if (score > 10)
            {
                obstacleSpeed = 15;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && jumping == false)
            {
                jumping = true;

            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if(jumping==true)
            {
                jumping = false;
            }
            if(e.KeyCode==Keys.R && isGameOver == true)
            {
                GameReset();
            }
         }
        private void GameReset()
        {
            force = 12;
            jumpSpeed = 0;
            jumping = false;
            score = 0;
            obstacleSpeed = 10;
            txtScore.Text = "Score :" + score;
            Trex.Image = Properties.Resources.running;
            isGameOver = false;
            Trex.Top = 444;

            foreach(Control x in this.Controls)
            {
                if(x is PictureBox && (string)x.Tag =="obstacle")
                {
                    position = this.ClientSize.Width + rand.Next(500,550) + (x.Width * 10);

                    x.Left = position;

                }
            }

            gameTimer.Start();
        }
    }
}