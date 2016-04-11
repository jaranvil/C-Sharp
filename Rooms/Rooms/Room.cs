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
            int horizontalLines = cHeight / cellSize;
            int verticalLines = cWidth / cellSize;
            Pen pen = new Pen(Color.Gray);
            for (int i = 0;i < horizontalLines;i++)
            {
                g.DrawLine(pen, 0, i * cellSize, cWidth, i * cellSize);
            }
            for (int i = 0; i < verticalLines; i++)
            {
                g.DrawLine(pen, i*cellSize, 0, i*cellSize, cHeight);
            }

            drawWalls(g);
        }

        public void drawWalls(Graphics g)
        {
            Brush brush = new SolidBrush(Color.BurlyWood);
            g.FillRectangle(brush, 0, 0, cWidth, cellSize);
            g.FillRectangle(brush, 0, cHeight - cellSize, cWidth, cellSize);
            g.FillRectangle(brush, 0, 0, cellSize, cHeight);
            g.FillRectangle(brush, cWidth - cellSize, 0, cellSize, cHeight);
        }

    }
}
