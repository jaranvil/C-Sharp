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
        public int x;
        public int y;
        private int cWidth;
        private int cHeight;
        private int speed = 10;

        private Boolean movingUp = false;
        private Boolean movingRight = false;
        private Boolean movingDown = false;
        private Boolean movingLeft = false;

        public List<Weapon> weapons = new List<Weapon>();

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

            // left wall
            if (newX < cellSize)
            {
                int doorTop = cHeight / 2 - 50;
                int doorBottom = cHeight / 2 + 50;

                if (!(y > doorTop && y+cellSize < doorBottom))
                {
                    newX = cellSize;
                }
            }
                
            //top
            if (newY < cellSize)
            {
                int doorleft = cWidth / 2 - 50;
                int doorRight = cWidth / 2 + 50;

                if (!(x > doorleft && x+cellSize < doorRight))
                {
                    newY = cellSize;
                }
            }
                
            // right
            if (newX + cellSize > cWidth - cellSize)
            {
                int doorTop = cHeight / 2 - 50;
                int doorBottom = cHeight / 2 + 50;

                if (!(y > doorTop && y + cellSize < doorBottom))
                {
                    newX = cWidth - (cellSize * 2);
                }
            }
                
            //bottom
            if (newY + cellSize > cHeight - cellSize)
            {
                int doorleft = cWidth / 2 - 50;
                int doorRight = cWidth / 2 + 50;

                if (!(x > doorleft && x + cellSize < doorRight))
                {
                    newY = cHeight - (cellSize * 2);
                }
            }
            

            x = newX;
            y = newY;       

            Brush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, x, y, cellSize, cellSize);

            for(int i = 0;i < weapons.Count;i++)
            {
                weapons[i].Draw(g);
            }
        }

        public void ResetPosition(int id)
        {
            if (id == 1)
            {
                this.x = cWidth - (cellSize * 2);
                this.y = cHeight / 2;
            }
            if (id == 2)
            {
                this.x = cWidth/2;
                this.y = cHeight - (cellSize*2);
            }
            if (id == 3)
            {
                this.x = cellSize;
                this.y = cHeight / 2;
            }
            if (id == 4)
            {
                this.x = cWidth/2;
                this.y = cellSize;
            }
        }

        public void ShootWeapon(int x, int y)
        {
            weapons.Add(new Weapon(x, y, this.x, this.y));
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
