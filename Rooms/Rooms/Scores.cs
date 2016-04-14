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
    public partial class Scores : Form
    {
        DataManager db;

        public Scores(DataManager db)
        {
            InitializeComponent();
            this.db = db;
            setupList();
        }

        public void setupList()
        {
            foreach (Score score in db.scores)
            {
                listBox1.Items.Add(score.ScoreVal + " - " + score.Name);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
