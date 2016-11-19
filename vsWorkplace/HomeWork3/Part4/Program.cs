using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part4
{
    public class ParentClass
    {

        public int number=12;
        private int number2 = 13;
        protected int number3 = 14;
    }
    public class DerivedClass : ParentClass
    {
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            DerivedClass d = new DerivedClass();
            Console.WriteLine(d.number);
        }
    }
}

//private：只能由1.该类中的函数、2.其友元函数访问。
//不能被任何其他访问，该类的对象也不能访问。

//protected：可以被1.该类中的函数、2.其友元函数访问 3.子类的函数。
//但不能被该类的对象访问。

//public：可以被1.该类中的函数、2.其友元函数访问 3.子类的函数、也可以由4.该类的对象访问。