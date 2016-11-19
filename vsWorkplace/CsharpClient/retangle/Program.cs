using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retangle
{
    class Rectangle 
    {
        private double Width { get; set; }
        private double Height { get; set; }
        private double L { get; set; }
        private double S { get; set; }
        public Rectangle(double width, double height)
        {
            this.Height = height;
            this.Width = width;
        }
        public double Area()
        {
            //double area;
            //area = 2 * this.Height + 2 * this.Width;
           // return area;
            L = 2 * this.Height + 2 * this.Width;
            return L;
        }
        public double Perimeter()
        {
            //double perimeter;
            //perimeter = this.Height * this.Width;
            //return perimeter;
            S = this.Height * this.Width;
            return S;
        }
        public void Showinfo()
        {
            Console.WriteLine("周长为:");
            Console.WriteLine(Area());

            Console.WriteLine("面积为:");
            Console.WriteLine(Perimeter());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect1 = new Rectangle(10, 5);
            rect1.Showinfo();
        }
    }
}
