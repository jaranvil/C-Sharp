using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assgn3b
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
            this.tableAdapterManager.UpdateAll(this.assgn3DataDataSet);

        }

        private void Manage_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'assgn3DataDataSet.Option' table. You can move, or remove it, as needed.
            this.optionTableAdapter.Fill(this.assgn3DataDataSet.Option);
            // TODO: This line of code loads data into the 'assgn3DataDataSet.Question' table. You can move, or remove it, as needed.
            this.questionTableAdapter.Fill(this.assgn3DataDataSet.Question);
            // TODO: This line of code loads data into the 'assgn3DataDataSet.Quiz' table. You can move, or remove it, as needed.
            this.quizTableAdapter.Fill(this.assgn3DataDataSet.Quiz);
            // TODO: This line of code loads data into the 'assgn3DataDataSet.Examinee' table. You can move, or remove it, as needed.
            this.examineeTableAdapter.Fill(this.assgn3DataDataSet.Examinee);

        }
    }
}
