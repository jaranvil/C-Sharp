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
        public List<Score> scores = new List<Score>();
        
        public bool loaded = false;

        private class DataHelper : DataContext
        {
            // TODO - setup proper database
            public DataHelper() :
                base("Data Source=(localdb)\\Projects; Initial Catalog=ExamData; Integrated Security=True"
                + "AttachDbFilename=H:\\Repos\\C-Sharp\\ExamData.mdf ; Initial Catalog=ExamData; Integrated Security=True")
            { }

            public Table<Score> Scores;            
        }

        private DataHelper data;

        public DataManager()
        {
            data = new DataHelper();
        }

        public void ClearDatabase()
        {
            data.ExecuteCommand("DELETE FROM Score");

            scores.Clear();
        }

        public void saveToDatabase()
        {
            data.Scores.InsertAllOnSubmit(scores);
            data.SubmitChanges();            
        }

        
    }
}
