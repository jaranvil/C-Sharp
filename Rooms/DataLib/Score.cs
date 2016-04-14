using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace DataLib
{
    [Table]
    public class Score
    {
        public Score() { }

        public Score(string name, int score)
        {
            this.Name = name;
            this.ScoreVal = score;
        }

        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Name;

        [Column]
        public int ScoreVal;
    }
}
