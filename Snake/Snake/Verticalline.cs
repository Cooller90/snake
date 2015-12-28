using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Verticalline
    {
        List<Point> pList;

        public Verticalline(int yUp, int yDown, int x, char sym)
        {
            pList = new List<Point>();

            for (int y = yUp; y <= yDown; y++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }
        }

        public void Show()
        {
            foreach (Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
