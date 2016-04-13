using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SpecialButton
{
    [ProvideToolboxControl("SpecialButton", false)]
    public partial class SpecialButton : UserControl
    {
        public EventHandler Clicked;
        public int value { get; set; }
        
        public EventHandler Fire;
        public SpecialButton()
        {
            InitializeComponent();
        }

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length > value)
            {
                Fire(sender, e);
            }
        }

        private void SpecialButton_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
             textBox1_TextChanged( sender,  e);
        }
    }
}
