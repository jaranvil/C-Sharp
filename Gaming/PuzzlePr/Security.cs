using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PuzzleBiz.Model;
using PuzzleBiz.Exceptions;
using PuzzleBiz.Util;

namespace PuzzlePr.Viewer
{
    public partial class Security : Form
    {
        public Security()
        {
            InitializeComponent();
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Security_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Player player = new Player();
            player.UserName = textBox1.Text;
            player.Password = textBox2.Text;
            if (Player.CheckCredential(ref player))
            {
                this.Hide();
                MainForm form = new MainForm();
                form.setPlayer(player);

                form.ShowDialog();
               
                
                this.Close();
            }
            else
            {
                PuzzleMessage.showMessage(3);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
