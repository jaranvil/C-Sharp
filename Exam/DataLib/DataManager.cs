using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.IO;

namespace DataLib
{
    public class DataManager
    {
        Random r = new Random();
        public List<Aisle> aisles = new List<Aisle>();
        public List<Item> items = new List<Item>();        
        public bool loaded = false;

        private class DataHelper : DataContext
        {            
            public DataHelper() :
                base("Data Source=(localdb)\\Projects; Initial Catalog=ExamData; Integrated Security=True"
                + "AttachDbFilename=H:\\Repos\\C-Sharp\\ExamData.mdf ; Initial Catalog=ExamData; Integrated Security=True")
            { }

            public Table<Aisle> Aisles;
            public Table<Item> Items;            
        }

        private DataHelper data;

        public DataManager()
        {
            data = new DataHelper();
        }

        public void ClearDatabase()
        {
            data.ExecuteCommand("DELETE FROM Item");
            data.ExecuteCommand("DELETE FROM Aisle");
            
            items.Clear();
            aisles.Clear();         
        }

        public void saveToDatabase()
        {
            data.Aisles.InsertAllOnSubmit(aisles);
            data.SubmitChanges();

            data.Items.InsertAllOnSubmit(items);
            data.SubmitChanges();
        }

        public void loadDataFromFile(string path)
        {
            using (StreamReader sr = new StreamReader(path))
            {
                // Aisle id, name, location, attendant, 
                // item id,name,unit price, no_of_units, aisle
                string line;
                Item item;
                Aisle aisle;
                
                while ((line = sr.ReadLine()) != null)
                {
                    if (!line.StartsWith("//"))
                    {
                        string[] inputs = line.Split(',');

                        aisle = GetAisle(inputs[0]);                        
                        if (aisle == null)
                        {                           

                            aisle = new Aisle(r.Next(1000), inputs[0], inputs[1], inputs[2]);
                            aisles.Add(aisle);
                        }
                        
                        item = GetItem(inputs[4]);
                        if (item == null)
                        {                            
                            item = new Item(Int32.Parse(inputs[3]), inputs[4], inputs[5], Int32.Parse(inputs[6]));
                            item.aisle = aisle;
                            aisle.items.Add(item);

                            items.Add(item);
                        }

                    }
                }
            }
        }
        public Item GetItem(string name)
        {
            foreach (Item i in items)
            {
                if (i.Name == name)
                {
                    return i;
                }
            }
            return null;
        }
        public Aisle GetAisle(string name)
        {
            foreach (Aisle a in aisles)
            {
                if (a.Name == name)
                {
                    return a;
                }
            }
            return null;
        }
    }
}
