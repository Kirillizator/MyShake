using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class HorizontalLine
    {
        // Линия это список (List) точек.

        List<Point> pList; // Список точек

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

        // Метод для вывода линии на экран
        public void Drow()
        {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
