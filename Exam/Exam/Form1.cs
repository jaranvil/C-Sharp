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
    public partial class Form1 : Form
    {
        DataManager manager;

        public Form1()
        {
            manager = new DataManager();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Data File|*.txt";
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string path = openFileDialog1.FileName;
                textBox1.Text = path;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                manager.ClearDatabase();
                manager.loadDataFromFile(textBox1.Text);
                manager.saveToDatabase();
            }
            catch (Exception excep)
            {
                Console.WriteLine("Caught exception: " + excep.Message);
            }

            string message =
                    "Data loaded into Database";
            const string caption = "Result";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OK,
                                         MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Search form = new Search(manager);
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            manager.ClearDatabase();
        }
    }
}
