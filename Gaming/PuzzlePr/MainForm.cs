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
using PuzzleBiz.Util;


namespace PuzzlePr.Viewer
{
    public partial class MainForm : Form
    {
        private Player player;
        public MainForm()
        {
            InitializeComponent();
        }
        private bool CheckWinning()
        {
            bool result = true;
            Button button;
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);

                    if (button.Tag.ToString() != button.Text)
                    {
                        result = false;
                        break;
                    }
                }
            }
            return result;

        }

        private void DisplayRandomNumbers(int num)
        {
            int [] nums = GameEngine.GetRandomArray(num);
            int i = 0;
            Button button;
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    button.Text = nums[i].ToString();
                    if (nums[i++] == 0)
                    {
                        button.Text = String.Empty;
                    }
                }
                
                
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button;
            if (colorDialog1.ShowDialog()==DialogResult.OK){
                 foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    button.BackColor = colorDialog1.Color;
                }
            }
            }

           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void incrementSteps(bool increment = true)
        {
            if (!increment)
            {
                steps.Text = "0";
            }
            else
            {
                steps.Text = (int.Parse(steps.Text) + 1).ToString();
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            DisplayRandomNumbers(16);
        }

        private void Cell_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            Panel panel1 = (Panel)button.Parent;
            //GetNextControl depends on tab order
            Button left = (Button)panel1.GetNextControl(button, false);
            Button right = (Button) panel1.GetNextControl(button, true);
           

            int indexCell = panel1.Controls.GetChildIndex(button);
            int panelIndex = this.panel.Controls.GetChildIndex(panel1);
            Panel upPanel = null, downPanel = null;
            Button up = null, down = null;
            if (panelIndex == 0)
            {

                downPanel = (Panel)this.panel.Controls[panelIndex + 1];

                down = (Button)downPanel.Controls[indexCell];
            }
            else if (panelIndex == 3)
            {
                upPanel = (Panel)this.panel.Controls[panelIndex - 1];

                up = (Button)upPanel.Controls[indexCell];
            }
            else 
            {
                upPanel = (Panel)this.panel.Controls[panelIndex - 1];
                downPanel = (Panel)this.panel.Controls[panelIndex + 1];

                up = (Button)upPanel.Controls[indexCell];
                down = (Button)downPanel.Controls[indexCell];
            }

            if (left != null && left.Text == "")
            {
                left.Text = button.Text;
                button.Text = String.Empty;
                incrementSteps();

            }
            else if (right != null && right.Text == "")
            {
                right.Text = button.Text;
                button.Text = String.Empty;
                incrementSteps();

            }
            else if (up != null && up.Text == "")
            {
                up.Text = button.Text;
                button.Text = String.Empty;
                incrementSteps();

            }
            else if (down != null && down.Text == "")
            {
                down.Text = button.Text;
                button.Text = String.Empty;
                incrementSteps();

            }
            
            if (CheckWinning())
            {
                MessageBox.Show("Winner");
            }
        }
        public void setPlayer(Player player){
            this.player = player;
        }
        private void randomizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DisplayRandomNumbers(16);
            incrementSteps(false);
        }

        private void fontColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Button button;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                foreach (Control controls in panel.Controls)
                {
                    foreach (Control control in controls.Controls)
                    {
                        button = ((Button)control);
                        button.ForeColor = colorDialog1.Color;
                    }
                }
            }
        }

        private void formatToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer1_ContentPanel_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prompt prompt = new prompt();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                SavedState state = new SavedState();
                state.Name = prompt.value.Text;
                state.State = buildState();
                state.Steps = int.Parse(steps.Text);
                state.Time = DateTime.Now;
                player.SaveGame(state);
            }
          

        }
        private String buildState()
        {
            StringBuilder build = new StringBuilder();
            Button button; ;
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    build.Append(button.Text);
                    build.Append(",");
                }
            }
            return build.Remove(build.Length - 1, 1).ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            prompt prompt = new prompt();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string name = prompt.value.Text;

                SavedState state = new SavedState();
                player.LoadGame(state, name);

                if (player.states == null || player.states[player.states.Count-1] == null)
                {             
                    PuzzleMessage.showMessage(5);
                }
                else
                {
                    LoadState(state);
                }
            }
        }

        private void LoadState(SavedState state)
        {
            int i = 0;
            Button button;
            string[] nums = state.State.Split(',');
            foreach (Control controls in panel.Controls)
            {
                foreach (Control control in controls.Controls)
                {
                    button = ((Button)control);
                    button.Text = nums[i];
                    if (nums[i].Equals(""))
                    {
                        button.Text = String.Empty;
                    }
                    i++;
                }
            }
            steps.Text = state.Steps.ToString();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void formatToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void fontColorToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void loadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            prompt prompt = new prompt();
            if (prompt.ShowDialog() == DialogResult.OK)
            {
                string name = prompt.value.Text;

                SavedState state = new SavedState();
                player.LoadGame(state, name);

                if (player.states == null || player.states[player.states.Count - 1] == null)
                {
                    PuzzleMessage.showMessage(5);
                }
                else
                {
                    LoadState(state);
                }
            }
        }
    }
}
