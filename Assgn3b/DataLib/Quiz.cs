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
    public class Quiz
    {
        public Quiz() { }

        public Quiz(int score, string name)
        {
            this.Name = name;
            this.Score = score;

            // This auto increment isnt working?
            // temp hack to give a unquie id
            Random r = new Random();
            this.Id = r.Next(1000);
        }

        [Column(IsPrimaryKey = true)] // IsDbGenerated = true
        public int Id;

        [Column]
        public int Score;

        [Column]
        public string Name;
    }
}
