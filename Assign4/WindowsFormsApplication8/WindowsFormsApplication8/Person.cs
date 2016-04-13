using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace WindowsFormsApplication8
{
    //to have class person abstract, do the following
    //add abstract modifier before keyword class
   // remove InheritanceMapping line below that is related to class person
    // add isdefault=true to one of the concrete subtypes
    //Table per inheritance

    [Table]
    [InheritanceMapping(Code = "S", Type = typeof(Student))]
    [InheritanceMapping(Code = "T", Type = typeof(Teacher))]
    [InheritanceMapping(Code = "P", Type = typeof(Person),IsDefault = true)]
     class Person
    {
         [Column (IsPrimaryKey=true,IsDbGenerated=true)]
         public int id;
         [Column]
        public string name;
         [Column(IsDiscriminator = true)]
        public string type;
    }
}
