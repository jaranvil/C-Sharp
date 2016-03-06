using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Data.Linq.Mapping;

namespace QuizLib
{
    public class DBAccess
    {
        public List<Examinee> examinees = new List<Examinee>();
        public List<Quiz> quizes = new List<Quiz>();
        public List<Question> questions = new List<Question>();

        private class DataHelper : DataContext
        {
            
            public DataHelper() :
                base("Data Source=(localdb)\\ProjectsV13; Initial Catalog=Quiz; Integrated Security=True"
                + "AttachDbFilename=C:\\Users\\s0739107\\Documents\\Repos\\C-Sharp\\Quiz.mdf ; Initial Catalog=Quiz; Integrated Security=True")
            { }

            public Table<Examinee> Examinees;
            public Table<Quiz> Quizes;
            public Table<Question> Questions;
        }

        private DataHelper data;

        public DBAccess()
        {
            data = new DataHelper();
            LoadExaminees();
        }

        public void LoadExaminees()
        {
            IEnumerator<Examinee> player = data.GetTable<Examinee>().GetEnumerator();
            while (player.MoveNext())
            {
                examinees.Add(player.Current);
            }
        }

        public void ClearDatabase()
        {
            data.ExecuteCommand("DELETE FROM Examinee");


        }

    }
}
