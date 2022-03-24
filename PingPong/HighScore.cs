using System;

namespace PingPong
{
    public class HighScore
    {
        public int HighScoreId { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }

        public Player Player { get; set; }
    }
}
