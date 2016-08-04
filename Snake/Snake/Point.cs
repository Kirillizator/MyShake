using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Point
    {
        // Данные класса
        public int x;
        public int y;
        public char sym;

        // Конструкторы при помощи которых можно создавать различные точки
        public Point()
        {
        }

        public Point(int _x, int _y, char _sym)
        {
            x = _x;
            y = _y;
            sym = _sym;
        }

        // Методы которые можно вызывать для каждой конкретной точки
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
