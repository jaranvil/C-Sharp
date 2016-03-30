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

namespace Exam
{
    public partial class Search : Form
    {
        DataManager db;

        public Search(DataManager db)
        {
            InitializeComponent();
            this.db = db;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string item = textBox1.Text;
            bool found = false;
            foreach (Item i in db.items)
            {
                if (i.Name.Contains(item))
                {
                    found = true;
                    string message =
                    "Item is in Asile " + i.aisle.Name + " located " + i.aisle.Location;
                    const string caption = "Result";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.OK,
                                                 MessageBoxIcon.Information);
                }
            }
            if (!found)
            {
                string message =
                    "Could not find item.";
                const string caption = "Result";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OK,
                                             MessageBoxIcon.Information);
            }
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

         
 
        }
    }
}
