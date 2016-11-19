using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    public class Dice
    {
        public int Face {get;set; }

        public int Point {get;set; }

        public static int[][] num =new int[3][];


        public int Roll()
        {

            if (Face == 6)
            {
                num[0] = new int[6] { 1, 2, 3, 4, 5, 6 };
                Random r = new Random();
                Point = r.Next(6)+1;
            }
            if (Face == 4)
            {
                num[0] = new int[4] { 1, 2, 3, 4 };
                Random r = new Random();
                Point = r.Next(4) + 1;
            }

            return Point;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dice d0 = new Dice();
            d0.Face = 6;
            Console.WriteLine(d0.Roll());
            Dice d1 = new Dice();
            d1.Face = 4;
            Console.WriteLine(d1.Roll());
        }
    }
}
