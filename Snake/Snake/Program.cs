using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            //Point p2 = new Point(4, 5, '#');           
            //p2.Draw();
            Console.SetBufferSize(100, 100);

            HorizontalLine horizontalLine = new HorizontalLine(5, 50, 3, '+');
            HorizontalLine horizontalLine2 = new HorizontalLine(5, 50, 25, '+');
            horizontalLine.Show();
            horizontalLine2.Show();

            Verticalline verticalLine = new Verticalline(3, 25, 4, '+');
            Verticalline verticalLine2 = new Verticalline(3, 25, 50, '+');
            verticalLine.Show();
            verticalLine2.Show();

            Point pSnake = new Point(5, 5, '*');
            Snake snake = new Snake(pSnake, 4, Direction.RIGHT);
            snake.Show();

            Console.ReadLine();
        }
    }
}
