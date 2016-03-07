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

namespace Assgn3b
{
    public partial class Quiz : Form
    {
        DBAccess db;
        const int numOfQ = 5;
        List<Question> Qs = new List<Question>();
        List<Option> answers = new List<Option>();

        public Quiz(DBAccess db)
        {
            InitializeComponent();
            this.db = db;

            ChooseQuestions();
            LoadAnswers();
        }

        // submit button
        private void button1_Click(object sender, EventArgs e)
        {
            string name = NamePrompt();
            int score = 0;

            // mark question 1
            string answer = "";
            if (choice11.Checked)
                answer = choice11.Text;
            if (choice12.Checked)
                answer = choice12.Text;
            if (choice13.Checked)
                answer = choice13.Text;
            if (answers[0].Text.Equals(answer))
                score++;

            // mark question 2
            answer = "";
            if (choice21.Checked)
                answer = choice21.Text;
            if (choice22.Checked)
                answer = choice22.Text;
            if (choice23.Checked)
                answer = choice23.Text;
            if (answers[1].Text.Equals(answer))
                score++;

            // mark question 3
            answer = "";
            if (choice31.Checked)
                answer = choice31.Text;
            if (choice32.Checked)
                answer = choice32.Text;
            if (choice33.Checked)
                answer = choice33.Text;
            if (answers[2].Text.Equals(answer))
                score++;

            // mark question 4
            answer = "";
            if (choice41.Checked)
                answer = choice41.Text;
            if (choice42.Checked)
                answer = choice42.Text;
            if (choice43.Checked)
                answer = choice43.Text;
            if (answers[3].Text.Equals(answer))
                score++;

            // mark question 5
            answer = "";
            if (choice51.Checked)
                answer = choice51.Text;
            if (choice52.Checked)
                answer = choice52.Text;
            if (choice53.Checked)
                answer = choice53.Text;
            if (answers[4].Text.Equals(answer))
                score++;

            db.SaveQuiz(new DataLib.Quiz(score, name));

            bool userExists = false;
            foreach (Examinee person in db.examinees)
            {
                if (person.Name.Equals(name))
                    userExists = true;
            }
            if (!userExists)
                db.SaveExaminee(new Examinee(name));

            Results result = new Results(name, score);
            result.Show();
            this.Hide();
        }

        public string NamePrompt()
        {
            Form prompt = new Form()
            {
                Width = 500,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Enter your name:",
                StartPosition = FormStartPosition.CenterScreen
            };
            Label textLabel = new Label() { Left = 50, Top = 20, Text = "Enter your name" };
            TextBox textBox = new TextBox() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100, Top = 70, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        public void ChooseQuestions()
        {
            Random r = new Random();
            for (int i = 0; i < numOfQ; i++)
            {
                Qs.Add(db.questions[r.Next(db.questions.Count)]);
            }

            question1.Text = Qs[0].Text;
            question2.Text = Qs[1].Text;
            question3.Text = Qs[2].Text;
            question4.Text = Qs[3].Text;
            question5.Text = Qs[4].Text;
        }

        public void LoadAnswers()
        {
            List<Option> options = new List<Option>();

            // question 1
            foreach (Option option in db.options)
            {
                if (option.QuestionId == Qs[0].Id)
                {
                    options.Add(option);
                    if (option.CorrectAnwser == 1)
                        answers.Add(option);
                }
            }
            choice11.Text = options[0].Text;
            choice12.Text = options[1].Text;
            choice13.Text = options[2].Text;

            // question 2
            options.Clear();
            foreach (Option option in db.options)
            {
                if (option.QuestionId == Qs[1].Id)
                {
                    options.Add(option);
                    if (option.CorrectAnwser == 1)
                        answers.Add(option);
                }
            }
            choice21.Text = options[0].Text;
            choice22.Text = options[1].Text;
            choice23.Text = options[2].Text;

            // question 3
            options.Clear();
            foreach (Option option in db.options)
            {
                if (option.QuestionId == Qs[2].Id)
                {
                    options.Add(option);
                    if (option.CorrectAnwser == 1)
                        answers.Add(option);
                }
            }
            choice31.Text = options[0].Text;
            choice32.Text = options[1].Text;
            choice33.Text = options[2].Text;

            // question 4
            options.Clear();
            foreach (Option option in db.options)
            {
                if (option.QuestionId == Qs[3].Id)
                {
                    options.Add(option);
                    if (option.CorrectAnwser == 1)
                        answers.Add(option);
                }
            }
            choice41.Text = options[0].Text;
            choice42.Text = options[1].Text;
            choice43.Text = options[2].Text;

            // question 5
            options.Clear();
            foreach (Option option in db.options)
            {
                if (option.QuestionId == Qs[4].Id)
                {
                    options.Add(option);
                    if (option.CorrectAnwser == 1)
                        answers.Add(option);
                }
            }
            choice51.Text = options[0].Text;
            choice52.Text = options[1].Text;
            choice53.Text = options[2].Text;

        }

        
    }
}
