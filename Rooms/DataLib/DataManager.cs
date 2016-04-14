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
        int lastScore = 0;

        private class DataHelper : DataContext
        {
            // TODO - setup proper database
            public DataHelper() :
                base("Data Source=(localdb)\\Projects; Initial Catalog=HighScores; Integrated Security=True"
                + "AttachDbFilename=H:\\Repos\\C-Sharp\\HighScores.mdf ; Initial Catalog=HighScores; Integrated Security=True")
            { }

            public Table<Score> Scores;            
        }

        private DataHelper data;

        public DataManager()
        {
            data = new DataHelper();
            LoadScores();
        }

        public void LoadScores()
        {
            IEnumerator<Score> score = data.GetTable<Score>().GetEnumerator();
            while (score.MoveNext())
            {
                scores.Add(score.Current);
            }
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

        public void CreateScore(string name, int score)
        {
            int id;
            if (lastScore > 0)
                id = lastScore += 1;
            else
                id = GetId();
            lastScore = id;
            Score newscore = new Score(id, name, score);
            AddScore(newscore);
        }

        public void AddScore(Score score)
        {
            data.GetTable<Score>().InsertOnSubmit(score);
            data.SubmitChanges();

            scores.Add(score);
        }

        public int GetId()
        {
            int id = 1;
            foreach (Score score in scores)
            {
                if (score.Id > id)
                    id = score.Id;
            }
            return id += 1;
        }
        
    }
}
