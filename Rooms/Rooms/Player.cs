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

            // TODO validate new positions

            Brush brush = new SolidBrush(Color.Blue);
            g.FillRectangle(brush, x, y, cellSize, cellSize);
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
