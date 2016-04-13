using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WindowsFormsApplication8
{
    class Student:Person
    {
        [Column()]
        public int StudentCode;
    }

}
