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
    public class Question
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;

        [Column]
        public int QuizId;

        [Column]
        public string Text;
    }
}
