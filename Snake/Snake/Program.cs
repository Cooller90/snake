using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.SetBufferSize(80, 25);

            HorizontalLine horizontalLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine horizontalLine2 = new HorizontalLine(0, 78, 24, '+');
            horizontalLine.Show();
            horizontalLine2.Show();

            Verticalline verticalLine = new Verticalline(0, 24, 0, '+');
            Verticalline verticalLine2 = new Verticalline(0, 24, 78, '+');
            verticalLine.Show();
            verticalLine2.Show();

            Point pSnake = new Point(5, 5, '*');
            Snake snake = new Snake(pSnake, 4, Direction.RIGHT);
            snake.Show();
            snake.Move();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while(true)
            {
                if (snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key= Console.ReadKey();
                    snake.HandlerSnake(key.Key);
                }

            }
            
        }
    }
}
