using System;
using System.Data.Entity;
using System.Windows.Forms;
using System.Linq;
using System.Drawing;

namespace PingPong
{
    public partial class Form1 : Form
    {
        private int speedVertical = 4;
        private int speedHorizontal = 4;
        private int speedHorizontal_panel = 15;
        private int speedVertical_panel = 15;
        private int score = 0;
        private int gamePanelTopCoord = 0;

        public Form1()
        {
            InitializeComponent();

            restartGame(true);
        }

        private void restartGame(bool onStart)
        {
            textScore.Visible = false;
            textScore.Enabled = false;
            buttonRestart.Visible = false;
            buttonExit.Visible = false;
            currentScore.Visible = true;
            bestScore.Visible = false;

            //textScore.Height = (background.Height / 2) - (textScore.Height / 2);
            //buttonRestart.Height = (background.Height / 2) - (buttonRestart.Height / 2);
            //buttonExit.Height = (background.Height / 2) - (buttonExit.Height / 2);
            //textScore.Left = (background.Width / 2) - (textScore.Width / 2);
            //buttonRestart.Left = (background.Width / 2) - (buttonRestart.Width / 2);
            //buttonExit.Left = (background.Width / 2) - (buttonExit.Width / 2);

            if (onStart)
            {             
                this.FormBorderStyle = FormBorderStyle.None;
                this.Bounds = Screen.PrimaryScreen.Bounds;
            }
            else
            {
                gameBall.Top = background.Top - (background.Top / 10);
            }
            Cursor.Hide();
            //this.TopMost = true;
            gamePanelTopCoord = background.Bottom - (background.Bottom / 10);
            gamePanel.Top = gamePanelTopCoord;
            timer.Enabled = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            if (e.KeyCode == Keys.W)
            {
                if (gamePanel.Top > background.Top)
                    gamePanel.Top -= speedHorizontal_panel;
            }
            if (e.KeyCode == Keys.S)
            {
                if (gamePanel.Top < gamePanelTopCoord)
                    gamePanel.Top += speedVertical_panel;
            }
            if (e.KeyCode == Keys.A)
            {
                if (gamePanel.Left > background.Left)
                    gamePanel.Left -= speedHorizontal_panel;

            }
            if (e.KeyCode == Keys.D)
            {
                if (gamePanel.Right < background.Right)
                    gamePanel.Left += speedHorizontal_panel;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            //gamePanel.Left = Cursor.Position.X - (gamePanel.Width / 2);
            gameBall.Left += speedHorizontal;
            gameBall.Top += speedVertical;

            if (gameBall.Left <= background.Left)
                speedHorizontal *= -1;
            if (gameBall.Right >= background.Right)
                speedHorizontal *= -1;
            if (gameBall.Top <= background.Top)
                speedVertical *= -1;
            if (gameBall.Bottom >= background.Bottom)
            {
                timer.Enabled = false;
                writeScoreToDB(score);
                textScore.Visible = true;
                bestScore.Visible = true;

                SampleContext context = new SampleContext();

                //var highscores = from hs in context.HighScores
                //                 join pl in context.Players
                //                 on hs.Player.PlayerId = pl.PlayerId
                //                 select new { highScore = hs.Score, playerName = pl.Name };

                var result = context.HighScores.Join(context.Players,
                                 hs => hs.Player.PlayerId,
                                 pl => pl.PlayerId,
                                 // результат, который будет храниться в переменной result
                                 (hs, pl) => new
                                 {
                                    // Имя страны
                                    highScore = hs.Score,
                                    // Имя столицы
                                    playerName = pl.Name
                                 }).OrderByDescending(hs => hs.highScore).First();
                bestScore.Text = $"Best score: {result.highScore}, player: {result.playerName}";

                textScore.Text = "Your score: " + score;
                buttonRestart.Visible = true;
                buttonExit.Visible = true;
                score = 0;
                Cursor.Show();
                this.TopMost = false;
                currentScore.Visible = false;
            }

            if (gameBall.Bottom >= gamePanel.Top && gameBall.Bottom <= gamePanel.Bottom
                && gameBall.Left >= gamePanel.Left && gameBall.Left <= gamePanel.Right)
            {
                speedVertical += 1;
                speedHorizontal += 1;
                speedVertical *= -1;
                score += 1;

                Random randColor = new Random();
                background.BackColor = Color.FromArgb(randColor.Next(100, 250), randColor.Next(100, 250), randColor.Next(100, 250));
            }

            currentScore.Text = "Score: " + score;
        }

        private static void writeScoreToDB(int score)
        {
            SampleContext context = new SampleContext();

            var player = context.Players.SingleOrDefault(pl => pl.Name == "KwygonJin");
            if (player == null)
            {
                player = new Player();
                player.Name = "KwygonJin";
                player.Age = 30;
                context.Players.Add(player);
            }

            HighScore highScore = new HighScore();
            highScore.Score = score;
            highScore.Player = player;
            highScore.Date = DateTime.Now;

            // Вставить данные в таблицу Customers с помощью LINQ
            context.HighScores.Add(highScore);

            // Сохранить изменения в БД
            context.SaveChanges();
        }

        private void buttonRestart_Click(object sender, EventArgs e)
        {
            restartGame(false);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
