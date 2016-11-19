using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geometry
{
    public interface S //接口 面积
    {
       
       void CalculateS();
        
    }
    public interface L//接口 周长
    {
        void CalculateL();
       
    }
    class Geometry//几何图形  基类
    {
        public double Height { get; set; }
        public double Width { get; set; }
        public double Radius { get; set; }
    }
    class Rectangle : Geometry, S,L//长方形 子类 
    {
        public Rectangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;

        }
        public void CalculateS()
        {
            double S = this.Height * this.Width;
            Console.WriteLine("正方形的面积为:{0}", S);
        }
        public void CalculateL()
        {
            double L = this.Height * 2 + this.Width * 2;
            Console.WriteLine("正方形的周长为:{0}", L);
        }
 
    }
    class Roundness : Geometry, S, L//圆形 子类
    {
        public Roundness(double radius) 
        {
            this.Radius = radius;
        }
        public void CalculateS()
        {
            double S = Math.PI * this.Radius * this.Radius;
            Console.WriteLine("圆形的面积为:{0}", S);
        }
        public void CalculateL()
        {
            double L = Math.PI * this.Radius * 2;
            Console.WriteLine("圆形的面积为:{0}", L);
        }
 
    }
    class Triangle : Geometry, S, L//三角形 子类
    {
        public double A { get; set; }
        public double B { get; set; }
        public Triangle(double height,double width)
        {
            this.Height = height;
            this.Width = width;

        }
        public Triangle(double a, double b,double width)
        {
            this.A = a;
            this.B = b;
            this.Width = width;

        }
        public void CalculateS()
        {
            double S = this.Height * this.Width * 0.5;
            Console.WriteLine("三角形的面积为:{0}", S);
        }
        public void CalculateL()
        {
            double L = this.A + this.B + this.Width;
            Console.WriteLine("三角形的周长为:{0}", L);
 
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rct = new Rectangle(12, 14);
            rct.CalculateL();
            rct.CalculateS();

            Roundness rou = new Roundness(6);
            rou.CalculateL();
            rou.CalculateS();

            Triangle tri1 = new Triangle(14, 6);
            tri1.CalculateS();

            Triangle tri2 = new Triangle(2,8,10);
            tri2.CalculateL();
           

        }
    }
}
