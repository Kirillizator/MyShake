using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine : Figure // Горизонтальная линия наследуется от фигуры
    {
        // Конструктор класса линии
        public HorizontalLine(int xLeft, int xRight, int y, char sym) // параметры задающие длину и положение линии
        {
            pList = new List<Point>();
            for(int x = xLeft; x <= xRight; x++)
            {
                Point p = new Point(x, y, sym);
                pList.Add(p);
            }      
        }
    }
}
