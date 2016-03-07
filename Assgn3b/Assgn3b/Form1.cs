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
    public partial class Form1 : Form
    {
        DBAccess db;

        public Form1()
        {
            InitializeComponent();
            db = new DBAccess();
        }

        private void databaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Manage form = new Manage();
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void takeQuizToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quiz quiz = new Quiz(db);
            quiz.Show();
        }

        private void historyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History history = new History(db);
            history.Show();
        }
    }
}
