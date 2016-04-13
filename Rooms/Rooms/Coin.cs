using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Rooms.Properties;

namespace Rooms
{
    class Coin
    {
        private int cellSize = 50;
        public int x;
        public int y;
        private int cWidth;
        private int cHeight;

        Bitmap image;

        public Boolean collected = false;

        public Coin(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.cWidth = width;
            this.cHeight = height;

            image = Resources.blue_gem_01;
        }

        public void Draw(Graphics g)
        {
            if (!collected)
            {
                //Brush brush = new SolidBrush(Color.Yellow);
                //g.FillRectangle(brush, x, y, cellSize, cellSize);

                g.DrawImage(image, x, y);
            }            
        }

        public Boolean Collect(int playerX, int playerY)
        {
            if (!collected)
            {
                if ((playerX > x && playerX < x + cellSize) || (playerX + cellSize > x && playerX + cellSize < x + cellSize))
                {
                    if ((playerY > y && playerY < y + cellSize) || (playerY + cellSize > y && playerY + cellSize < y + cellSize))
                    {
                        collected = true;
                        return true;
                    }
                }
            }
            
            return false;
        }
    }
}
