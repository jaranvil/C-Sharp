using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment3
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
            this.tableAdapterManager.UpdateAll(this.dataAssgn3DataSet);

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataAssgn3DataSet.Option' table. You can move, or remove it, as needed.
            this.optionTableAdapter.Fill(this.dataAssgn3DataSet.Option);
            // TODO: This line of code loads data into the 'dataAssgn3DataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.dataAssgn3DataSet.Question);
            // TODO: This line of code loads data into the 'dataAssgn3DataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.dataAssgn3DataSet.Quiz);
            // TODO: This line of code loads data into the 'dataAssgn3DataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.dataAssgn3DataSet.Examinee);

        }
    }
}
