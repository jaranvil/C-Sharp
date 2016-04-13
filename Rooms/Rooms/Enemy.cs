using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Rooms.Properties;

namespace Rooms
{
    class Enemy
    {
        private int cellSize = 50;
        public int x;
        public int y;
        private int cWidth;
        private int cHeight;

        Bitmap image;

        public Boolean dead = false;

        public Enemy(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.cWidth = width;
            this.cHeight = height;

            Random r = new Random();
            Bitmap[] images = { Resources.yellow_01, Resources.blue_01, Resources.green_01 };
            image = images[r.Next(images.Length)];

            
        }

        public void Draw(Graphics g, int playerX, int playerY)
        {
            if (!dead)
            {
                int deltaX = playerX - x;
                int deltaY = playerY - y;

                x += Convert.ToInt32((Math.Round(deltaX / 5.0) * 5) / 100);
                y += Convert.ToInt32((Math.Round(deltaY / 5.0) * 5) / 100);

                //Brush brush = new SolidBrush(Color.Red);
                //g.FillRectangle(brush, x, y, cellSize, cellSize);

                g.DrawImage(image, x, y);
            }
            
        }

        public void WeaponCollisions(List<Weapon> weapons)
        {
            for (int i = 0;i < weapons.Count;i++)
            {
                int x = weapons[i].centerX;
                int y = weapons[i].centerY;

                if ((x-20 > this.x && x-20 < this.x+cellSize) || (x+20 > this.x && x+20 < this.x+cellSize))
                {
                    if ((y-20 > this.y && y-20 < this.y+cellSize) || (y+20 > this.y && y+20 < this.y+cellSize))
                    {
                        dead = true;
                    }
                }
            }
        }

        public Boolean PlayerCollsion(int playerX, int playerY)
        {
            int padding = 5;
            if (!dead)
            {
                if ((playerX >= x-padding && playerX <= x+padding + cellSize) || (playerX + cellSize >= x-padding && playerX + cellSize <= x+padding + cellSize))
                {
                    if ((playerY >= y-padding && playerY <= y+padding + cellSize) || (playerY + cellSize >= y-padding && playerY + cellSize <= y+padding + cellSize))
                    {                        
                        return true;
                    }
                }
            }

            return false;
        }

    }
}
