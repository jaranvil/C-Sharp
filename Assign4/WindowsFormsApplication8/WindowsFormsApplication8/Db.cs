using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;
using System.Data.Linq;


namespace WindowsFormsApplication8
{
    class Db:DataContext
    {
        public Table<Person> people;
      public  Db() : base(@"Data Source=(localdb)\ProjectsV12;Initial Catalog=TPH;Integrated Security=True"){

    }
    }
}
