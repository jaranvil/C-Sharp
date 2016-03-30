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
    public partial class History : Form
    {
        DBAccess db;

        public History(DBAccess db)
        {
            InitializeComponent();
            this.db = db;

            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            listView1.Columns.Add("Name", 100);
            listView1.Columns.Add("Score", 100);


            foreach (DataLib.Quiz quiz in db.quizes)
            {
                String[] args = { quiz.Name, quiz.Score.ToString() };
                ListViewItem row = new ListViewItem(args);
                listView1.Items.Add(row);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
