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
            // Инкапсуляция - механизм который объединяет данный код, манипулирующий этими данными, а также защищает и то и другое от внешнего вмешательства или не правильного использования.
            // Наследование - позволяет создавать новые классы которые повторно использует, расширяют и изменяют поведение определенное в других классах.
            // Полиморфизм - во время выполнения объекты производного класса могут рассматриваться как объекты базового класса в таких местах как параметры, методы, коллекции и массивы.
            // Полиморфизм позволяет переопределять, в классах наследниках, реализации методов базового класса, с помощью ключевого слова virtual.

            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            // Отрисовка точки. 
            Point p = new Point(10, 10, '*');
            Snake snake = new Snake(p, 4, Direction.RIGHT); // Змейка имеет координаты, длину и направление движения
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '%');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if(walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandleKey(key.Key);
                }
            }              
        }
    }
}
