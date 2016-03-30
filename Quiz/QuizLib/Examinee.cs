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
    public class Examinee
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int Id;

        [Column]
        public string Name;

        // create the "quizes" list property using linq

        //private EntitySet<Quiz> _quizes = new EntitySet<Quiz>();

        //[Association(Storage = "_quizes", OtherKey = "ExamineeId", ThisKey = "Id")]
        //public ICollection<Quiz> quizes
        //{
        //    get { return _quizes; }
        //    set { _quizes.Assign(value); }
        //}
    }
}
 