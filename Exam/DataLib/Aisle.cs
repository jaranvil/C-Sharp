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
    public class Aisle
    {
        public Aisle() { }

        public Aisle(int id, string name, string location, string attendant)
        {
            this.Id = id;
            this.Name = name;
            this.Location = location;
            this.Attendant = attendant;
        }

        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Name;

        [Column]
        public string Location;

        [Column]
        public string Attendant;

        private EntitySet<Item> _items = new EntitySet<Item>();

        [Association(Storage = "_items", OtherKey = "Aisle", ThisKey = "Id")]
        public ICollection<Item> items
        {
            get { return _items; }
            set { _items.Assign(value); }
        }
    }
}
