using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz
{
    public partial class Manage : Form
    {
        public Manage()
        {
            InitializeComponent();
        }

        private void examineeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.examineeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.quizDataSet);

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'quizDataSet.Qption' table. You can move, or remove it, as needed.
            this.qptionTableAdapter.Fill(this.quizDataSet.Qption);
            // TODO: This line of code loads data into the 'quizDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.quizDataSet.Question);
            // TODO: This line of code loads data into the 'quizDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.quizDataSet.Quiz);
            // TODO: This line of code loads data into the 'quizDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.quizDataSet.Examinee);

        }
    }
}
