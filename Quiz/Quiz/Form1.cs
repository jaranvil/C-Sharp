using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuizLib;

namespace Quiz
{
    public partial class Form1 : Form
    {
        private DBAccess db;

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

        private void button1_Click(object sender, EventArgs e)
        {
            db.ClearDatabase();
        }
    }
}
