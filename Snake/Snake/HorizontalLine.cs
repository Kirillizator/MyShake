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
           
            /*Point p1 = new Point(4, 4, '*');
            Point p2 = new Point(5, 4, '*');
            Point p3 = new Point(6, 4, '*');
            Point p4 = new Point(7, 4, '*');
            Point p5 = new Point(8, 4, '*');

            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);*/

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
