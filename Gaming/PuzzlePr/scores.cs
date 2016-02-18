using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleBiz.DA;
using PuzzleBiz.Loader;
using PuzzleBiz.Model;

namespace PuzzlePr.Viewer
{
    public partial class scores : Form
    {
        public scores()
        {
            InitializeComponent();
            List<Score> scores = Configuration.da.GetHighScores();
            if (scores.Count > 0)
                lblScore1.Text = scores[0].player + ": " + scores[0].score;
            if (scores.Count > 1)
                lblScore2.Text = scores[1].player + ": " + scores[1].score;
            if (scores.Count > 2)
                lblScore3.Text = scores[2].player + ": " + scores[2].score;
            if (scores.Count > 3)
                lblScore4.Text = scores[3].player + ": " + scores[3].score;
            if (scores.Count > 4)
                lblScore5.Text = scores[4].player + ": " + scores[4].score;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
