using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part3
{
    public class Calcu 
    {
        public static double Pi = Math.PI;
        public static double CalcuRound(double r)
        {
            return r * r * Pi;
 
        }
        public static double CalcuCubeS(double l,double w)
        {
            return l * w;

        }
        public static double CalcuCubeC(double l, double w)
        {
            return (l + w) * 2;

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           double a = Calcu.CalcuCubeC(3, 5);
            double b = Calcu.CalcuCubeS(3, 5);
            double c = Calcu.CalcuRound(6);

            Console.WriteLine("长方形的周长是:{0},长方形的面积是:{1},圆的面积是{2}", a, b, c);
            
        }
    }
}
