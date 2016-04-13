using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biz;
using System.Threading;
using System.Globalization;
using System.Resources;


namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Test test = new Test();

        ComponentResourceManager resources;
        ResourceManager rm;

        private void Form1_Load(object sender, EventArgs e)
        {
            //subscribe methods to the delegate
            test.handler += fire;
            
           // or test.handler += new Test.FireHandler(fire);
            test.handler += update_button;

            //define component Resource.. only once
            resources = new ComponentResourceManager(typeof(Form1));

            //Define Resource Manage..only once
            rm = new ResourceManager("WindowsFormsApplication11.Form1", typeof(Form1).Assembly);

            specialButton1.Fire += button1_Click;


        }

        private void ForceLanguageChange()
        {

            String txt = textBox1.Text;
            if (txt.Length == 0)
            {
                MessageBox.Show(rm.GetString("1"));
                return;
            }
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(txt);
            
            foreach (Control control in groupBox1.Controls)
            {
                resources.ApplyResources(control, control.Name, Thread.CurrentThread.CurrentUICulture);
            }
        }

        private void fire(String data)
        {
            MessageBox.Show(data);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            test.Level1(false);
        }
        private void update_button(String text)
        {
            button1.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForceLanguageChange();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
