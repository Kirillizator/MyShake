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


            HorizontalLine n_line = new HorizontalLine(1, 70, 1, '+');
            n_line.Drow();

            HorizontalLine s_line = new HorizontalLine(1, 70, 20, '+');
            s_line.Drow();

            VerticalLine w_line = new VerticalLine(1, 2, 19, '+');
            w_line.Drow();

            VerticalLine o_line = new VerticalLine(70, 2, 19, '+');
            o_line.Drow();



           
            Console.ReadLine();
        }


    }
}
