using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rooms
{
    public partial class Form1 : Form
    {
        private Room room;
        private Player player;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            room = new Room(pbCanvas.Width, pbCanvas.Height);
            player = new Player(pbCanvas.Width/2, pbCanvas.Height/2, pbCanvas.Width, pbCanvas.Height);

            mainTimer.Start();
        }

        private void mainTimer_Tick(object sender, EventArgs e)
        {
            pbCanvas.Invalidate();
        }

        private void pbCanvas_Paint(object sender, PaintEventArgs e)
        {
            room.draw(e.Graphics);
            player.draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {           
            player.keyDown(e.KeyCode);
            e.Handled = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            player.keyUp(e.KeyCode);
            e.Handled = true;
        }

        private void pbCanvas_MouseDown(object sender, MouseEventArgs e)
        {
 
            int x = Convert.ToInt32(Math.Round(Cursor.Position.X / 5.0) * 5);
            int y = Convert.ToInt32(Math.Round(Cursor.Position.Y / 5.0) * 5);

            int gcd = Gcd(x, y);
            int xMove = x / gcd;
            int yMove = y / gcd;

            player.ShootWeapon(xMove, yMove);
        }

        private static int Gcd(int a, int b)
        {
            if (a == 0)
                return b;
            else
                return Gcd(b % a, a);
        }

    }
}
