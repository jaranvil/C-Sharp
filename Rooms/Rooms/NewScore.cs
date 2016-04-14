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

namespace Rooms
{
    public partial class NewScore : Form
    {
        DataManager db;
        int score;

        public NewScore(DataManager db, int score)
        {
            InitializeComponent();
            this.db = db;
            this.score = score;
            lblScore.Text = score+"";
        }

        private void Save_Click(object sender, EventArgs e)
        {
            db.CreateScore(tbName.Text, score);
            Scores scores = new Scores(db);
            scores.Show();
            this.Hide();
        }
    }
}
