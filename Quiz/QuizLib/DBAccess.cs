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
        public List<Option> options = new List<Option>();

        private class DataHelper : DataContext
        {
            
            public DataHelper() :
                base("Data Source=(localdb)\\ProjectsV13; Initial Catalog=Quiz; Integrated Security=True"
                + "AttachDbFilename=C:\\Users\\s0739107\\Documents\\Repos\\C-Sharp\\Quiz.mdf ; Initial Catalog=Quiz; Integrated Security=True")
            { }

            public Table<Examinee> Examinees;
            public Table<Quiz> Quizes;
            public Table<Question> Questions;
            public Table<Option> Options;
        }

        private DataHelper data;

        public DBAccess()
        {
            data = new DataHelper();
            LoadModels();
        }

        public void LoadModels()
        {
            LoadExaminees();
            LoadOptions();
            LoadQuestions();
            LoadQuizes();
        }

        public void LoadExaminees()
        {
            IEnumerator<Examinee> person = data.GetTable<Examinee>().GetEnumerator();
            while (person.MoveNext())
            {
                examinees.Add(person.Current);
            }
        }

        public void LoadQuizes()
        {
            IEnumerator<Quiz> quiz = data.GetTable<Quiz>().GetEnumerator();
            while (quiz.MoveNext())
            {
                quizes.Add(quiz.Current);
            }
        }

        public void LoadQuestions()
        {
            IEnumerator<Question> question = data.GetTable<Question>().GetEnumerator();
            while (question.MoveNext())
            {
                questions.Add(question.Current);
            }
        }

        public void LoadOptions()
        {
            IEnumerator<Option> _option = data.GetTable<Option>().GetEnumerator();
            while (_option.MoveNext())
            {
                options.Add(_option.Current);
            }
        }

        public void ClearDatabase()
        {
            data.ExecuteCommand("DELETE FROM Examinee");


        }

    }
}
