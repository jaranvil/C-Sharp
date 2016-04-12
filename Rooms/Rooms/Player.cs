using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Rooms
{
    class Player
    {
        private int cellSize = 50;
        private int x;
        private int y;
        private int cWidth;
        private int cHeight;
        private int speed = 10;

        private Boolean movingUp = false;
        private Boolean movingRight = false;
        private Boolean movingDown = false;
        private Boolean movingLeft = false;

        List<Weapon> weapons = new List<Weapon>();

        public Player(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.cWidth = width;
            this.cHeight = height;            
        }

        public void draw(Graphics g)
        {
            int newX = x;
            int newY = y;

            if (movingUp)
                newY -= speed;
            if (movingDown)
                newY += speed;
            if (movingLeft)
                newX -= speed;
            if (movingRight)
                newX += speed;

            // right wall
            if (newX < cellSize)
                newX = cellSize;
            //top
            if (newY < cellSize)
                newY = cellSize;
            // right
            if (newX + cellSize > cWidth - cellSize)
                newX = cWidth - (cellSize*2);
            //bottom
            if (newY + cellSize > cHeight - cellSize)
                newY = cHeight - (cellSize*2);

            x = newX;
            y = newY;       

            Brush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, x, y, cellSize, cellSize);

            for(int i = 0;i < weapons.Count;i++)
            {
                weapons[i].Draw(g);
            }
        }

        public void ShootWeapon(int xMove, int yMove)
        {
            weapons.Add(new Weapon(x, y, xMove, yMove));
        }

        public void keyDown(Keys key)
        {
            if (key == Keys.A)
                movingLeft = true;
            if (key == Keys.D)
                movingRight = true;
            if (key == Keys.W)
                movingUp = true;
            if (key == Keys.S)
                movingDown = true;
        }

        public void keyUp(Keys key)
        {
            if (key == Keys.A)
                movingLeft = false;
            if (key == Keys.D)
                movingRight = false;
            if (key == Keys.W)
                movingUp = false;
            if (key == Keys.S)
                movingDown = false;
        }

    
           

      
    }
}
