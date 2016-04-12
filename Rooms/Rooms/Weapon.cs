using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rooms
{
    class Weapon
    {
        private int cellSize = 50;
        private int x;
        private int y;
        private int xMove;
        private int yMove;
        private int speed = 10;        

        public Weapon(int x, int y, int xMove, int yMove)
        {   
            this.x = x;
            this.y = y;
            this.xMove = xMove;
            this.yMove = yMove;
        }

        public void Draw(Graphics g)
        {
            x += xMove;
            y += yMove;

            Brush brush = new SolidBrush(Color.Green);
            g.FillEllipse(brush, x, y, 20, 20);
        }
    }
}
