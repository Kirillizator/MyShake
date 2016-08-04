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
            Point p1 = new Point(30, 15, '*');
            p1.Draw();

            Point p2 = new Point(30, 16, '@');
            p2.Draw();


            HorizontalLine line = new HorizontalLine(5, 30, 8, '+');
            line.Drow();

           
            Console.ReadLine();
        }


    }
}
