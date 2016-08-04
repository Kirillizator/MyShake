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


            HorizontalLine upline = new HorizontalLine(1, 70, 1, '+');
            upline.Drow();

            HorizontalLine dwline = new HorizontalLine(1, 70, 20, '+');
            dwline.Drow();



           
            Console.ReadLine();
        }


    }
}
