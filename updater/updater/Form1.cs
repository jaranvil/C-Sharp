using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace updater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            const string caption = "Error";
            var result = MessageBox.Show("Downloading new version...", caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Error);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
