using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Rooms
{
    class Room
    {
        private int cWidth;
        private int cHeight;
        private int cellSize = 50;

        public Room(int width, int height)
        {
            this.cWidth = width;
            this.cHeight = height;
        }

        public void draw(Graphics g)
        {
            // gridlines
            //int horizontalLines = cHeight / cellSize;
            //int verticalLines = cWidth / cellSize;
            //Pen pen = new Pen(Color.Gray);
            //for (int i = 0;i < horizontalLines;i++)
            //{
            //    g.DrawLine(pen, 0, i * cellSize, cWidth, i * cellSize);
            //}
            //for (int i = 0; i < verticalLines; i++)
            //{
            //    g.DrawLine(pen, i*cellSize, 0, i*cellSize, cHeight);
            //}

            drawWalls(g);
            DrawDoors(g);
        }

        public void NewRoom(List<Enemy> enemies, List<Coin> coins)
        {
            Random r = new Random();
            enemies.Clear();
            coins.Clear();
            
            for (int i = 0;i < 2;i++)
            {
                enemies.Add(new Enemy(r.Next(cWidth), r.Next(cHeight), cWidth, cHeight));
            }

            for (int i = 0; i < 5; i++)
            {
                coins.Add(new Coin(50+r.Next(cWidth), 50+r.Next(cHeight-100), cWidth, cHeight));
            }
        }

        public void drawWalls(Graphics g)
        {
            Brush brush = new SolidBrush(Color.BurlyWood);
            g.FillRectangle(brush, 0, 0, cWidth, cellSize);
            g.FillRectangle(brush, 0, cHeight - cellSize, cWidth, cellSize);
            g.FillRectangle(brush, 0, 0, cellSize, cHeight);
            g.FillRectangle(brush, cWidth - cellSize, 0, cellSize, cHeight);
        }

        public void DrawDoors(Graphics g)
        {
            Brush brush = new SolidBrush(Color.Black);
            g.FillRectangle(brush, cWidth/2 -50, 0, 100, cellSize);
            g.FillRectangle(brush, cWidth / 2 - 50, cHeight - cellSize, 100, cellSize);
            g.FillRectangle(brush, 0, cHeight/2 - 50, cellSize, 100);
            g.FillRectangle(brush, cWidth - cellSize, cHeight / 2 - 50, cellSize, 100);
        }

        

    }
}
