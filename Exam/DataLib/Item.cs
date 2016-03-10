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
    public class Item
    {
        public Item() { }

        public Item(int id, string name, string price, int units)
        {
            this.Id = id;
            this.Name = name;
            this.Price = price;
            this.Units = units;
        }

        [Column(IsPrimaryKey = true)]
        public int Id;

        [Column]
        public string Name;

        [Column]
        public string Price;

        [Column]
        public int Units;

        private EntityRef<Aisle> _aisle = new EntityRef<Aisle>();
        [Column]
        private int Aisle;
        [Association(IsForeignKey = true, Storage = "_aisle", ThisKey = "Aisle")]
        public Aisle aisle
        {
            get { return _aisle.Entity; }
            set { _aisle.Entity = value; }
        }
    }
}
