using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work4
{
    public class Box 
    {
        public double Boxlength { set; get; }
        public Box(double boxlength)
        {
            this.Boxlength = boxlength;
        }
        public double CalcuS() 
        {
            double s;
            s = this.Boxlength * this.Boxlength * 6;
            return s;
        }
        public double CalcuV()
        {
            double v;
            v = this.Boxlength * this.Boxlength * this.Boxlength;
            return v;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
            Box b = new Box(5);
            Console.WriteLine("立方体的面积是:{0}",b.CalcuS());
            Console.WriteLine("立方体的体积为:{0}",b.CalcuV());
        }
    }
}
