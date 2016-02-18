using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleBiz.Util;

namespace PuzzlePr.Viewer
{
    public partial class prompt : Form
    {
        public prompt()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (value.Text.Length > 0)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                PuzzleMessage.showMessage(4);
            }
        }
    }
}
