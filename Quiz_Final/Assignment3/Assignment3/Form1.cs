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

namespace Assignment3
{
    public partial class Form1 : Form
    {
        DBAccess db;

        public Form1()
        {
            InitializeComponent();
            db = new DBAccess();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Manage m = new Manage();
            m.Show();
        }
    }
}
