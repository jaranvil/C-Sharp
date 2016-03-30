using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace QuizLib
{
    [Table]
    public class Option
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;

        [Column]
        public int QuestionId;

        [Column]
        public bool CorrectAnswer;

        [Column]
        public string Text;
    }
}
