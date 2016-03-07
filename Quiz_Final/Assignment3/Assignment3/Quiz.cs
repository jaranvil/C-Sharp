using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLib;

namespace Assignment3
{
    public partial class Quiz : Form
    {
        private int questionCount = 5;

        DBAccess db;
        List<Question> questions = new List<Question>();

        public Quiz(DBAccess db)
        {
            InitializeComponent();
            this.db = db;
        }

        private void Quiz_Load(object sender, EventArgs e)
        {
            // select random questions for this quiz
            Random r = new Random();
            for (int i = 0;i<questionCount;i++)
            {                
                questions.Add(db.questions[r.Next(db.questions.Count)]);
            }
        }
    }
}
