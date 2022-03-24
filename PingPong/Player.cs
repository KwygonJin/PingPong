using System;
using System.Collections.Generic;

namespace PingPong
{
    public class Player
    {
        public int PlayerId { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual List<HighScore> HighScores { get; set; }
    }
}
