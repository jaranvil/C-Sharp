using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PuzzlePr.Viewer
{
    public partial class Management : Form
    {
        public Management()
        {
            InitializeComponent();
        }

        private void playerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.playerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.puzzleDataSet);

        }

        private void Management_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'puzzleDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.puzzleDataSet.Table);
            // TODO: This line of code loads data into the 'puzzleDataSet.SavedState' table. You can move, or remove it, as needed.
            this.savedStateTableAdapter.Fill(this.puzzleDataSet.SavedState);
            // TODO: This line of code loads data into the 'puzzleDataSet.Player' table. You can move, or remove it, as needed.
            this.playerTableAdapter.Fill(this.puzzleDataSet.Player);

        }
    }
}
