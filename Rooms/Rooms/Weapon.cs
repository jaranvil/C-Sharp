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
        public int centerX = 0;
        public int centerY = 0;

        private int cellSize = 50;
        private int x;
        private int y;
        private int xMove;
        private int yMove;
        private int speed = 10;

        private Boolean down = false;
        private Boolean right = false;

        public Weapon(int targetX, int targetY, int playerX, int playerY)
        {   
            this.x = playerX;
            this.y = playerY;            

            //if (x <= targetX)
            //    right = true;
            //if (y <= targetY)
            //    down = true; 

            int deltaX = targetX - playerX;
            int deltaY = targetY - playerY;
            xMove = Convert.ToInt32((Math.Round(deltaX / 5.0) * 5) / 20);
            yMove = Convert.ToInt32((Math.Round(deltaY / 5.0) * 5) / 20);
        }

        public void Draw(Graphics g)
        {            
            x += xMove;
            y += yMove;

            Brush brush = new SolidBrush(Color.Yellow);
            g.FillEllipse(brush, x, y, 20, 20);

            centerX = x + (cellSize / 2);
            centerY = y + (cellSize / 2);
        }
    }
}
