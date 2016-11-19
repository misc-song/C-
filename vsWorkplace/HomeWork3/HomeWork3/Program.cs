using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork3
{
    public class A 
    {
        //public int Num { get; set; }
        public virtual int MyMethod(int num) 
        {
            return num + 10;
        }
    }
    public class B : A
    {
        public override int MyMethod(int num)
        {
            return num+50;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            Console.WriteLine( a.MyMethod(10));
            B b = new B();
            Console.WriteLine(b.MyMethod(10));
        }
    }
}
