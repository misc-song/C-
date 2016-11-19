using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AB
{
    class A 
    {
        public A()
        {
            Console.Write("A");
 
        }
        public virtual void Fun()
        {
            Console.Write("A.Fun()");
        }
    }
    class B:A
    {
        public B()
        {
            Console.Write("B");

        }
        public new void Fun()
        {
            Console.Write("B.Fun()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.Fun();
        }
    }
}
