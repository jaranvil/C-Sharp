using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleBiz.Model
{
	public class Score
	{
        public int id;
        public string player;
        public int score;

        public Score(int id, string player, int score)
        {
            this.id = id;
            this.player = player;
            this.score = score;
        }
	}
}
