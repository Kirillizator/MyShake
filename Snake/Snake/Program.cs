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
            Point p1 = new Point(10, 15, '*');
            //p1.Draw();

            Point p2 = new Point(10, 17, '@');
            //p2.Draw();

            Point p3 = new Point(10, 19, '#'); //Своя точка
            //p3.Draw();

            Point p4 = new Point(10, 21, '%'); //Своя точка
            //p4.Draw();

            List<int> numList = new List<int>();
            numList.Add(0);
            numList.Add(1);
            numList.Add(2);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];
            
            
            foreach(int i in numList)
            {
                Console.WriteLine(i);
            }


            numList.RemoveAt(0);

            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);

            /*Мое собственное*/

            List<int> lst = new List<int>(); //Свой список с целочисленными
            lst.Add(2);
            lst.Add(4);
            lst.Add(11);

            int a = lst[0];
            int b = lst[1];
            int c = lst[2];

            foreach (int i in lst)
            {
                Console.WriteLine(i);
            }


            List<char> lstchar = new List<char>(); //Свой список с символами
            lstchar.Add('@');
            lstchar.Add('!');
            lstchar.Add('$');

            char q = lstchar[0];
            char w = lstchar[1];
            char e = lstchar[2];

            foreach (char i in lstchar)
            {
                Console.WriteLine(i);
            }

            List<Point> plst = new List<Point>();  //Свой список из точек
            plst.Add(p1);
            plst.Add(p2);
            plst.Add(p3);
            plst.Add(p4);

            foreach (Point i in plst)
            {
                i.Draw();
            }


            Console.ReadLine();
        }


    }
}
