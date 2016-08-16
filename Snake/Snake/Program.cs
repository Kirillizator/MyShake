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
            Console.SetBufferSize(80, 25); // Установить размер окна и убрать возможность перемотки

            // Отрисовка рамочки
            HorizontalLine n_line = new HorizontalLine(0, 78, 0, '+');
            n_line.Drow();

            HorizontalLine s_line = new HorizontalLine(0, 78, 24, '+');
            s_line.Drow();

            VerticalLine w_line = new VerticalLine(0, 1, 23, '+');
            w_line.Drow();

            VerticalLine o_line = new VerticalLine(78, 1, 23, '+');
            o_line.Drow();

            // Отрисовка точки
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); // Змейка имеет координаты, длину и направление движения
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key); // Обработай нажатие ты ведь знаешь что делать
                }
                Thread.Sleep(100);
                snake.Move();
            }

                       
        }
    }
}
