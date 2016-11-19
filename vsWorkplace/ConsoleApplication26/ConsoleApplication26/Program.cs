using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication26
{
    class Program
    {
        class Person
        {
            //public String Name { get; set; }
            //public String Sex { get; set; }

            public void Use(Calculator Cal) 
            {
                Console.WriteLine("请输入第一个操作数");
                Cal.Op1 = Console.Read();
                Console.WriteLine("请输入第二个操作数");
                Cal.Op2 = Console.Read();
                Console.WriteLine("请输入运算符");
                Cal.Oper = (char)Console.Read();

                
            }
        }
        class Calculator
        {
            public Double Op1 { get; set; }
            public Double Op2 { get; set; }
            public Char Oper { get; set; }

           
            public void Calcul()
            {
                double result = 0;
                if (Oper.Equals('+'))
                {
                    result = Op1 + Op2;
                    Console.WriteLine("结果为:{0}", result);
 
                }
                if (Oper.Equals('-'))
                {
                    result = Op1 - Op2;
                    Console.WriteLine("结果为:{0}", result);

                }
                if (Oper.Equals('*'))
                {
                    result = Op1 * Op2;
                    Console.WriteLine("结果为:{0}", result);

                }
                if (Oper.Equals('/'))
                {
                    result = Op1 / Op2;
                    Console.WriteLine("结果为:{0}", result);

                }
                if (Oper.Equals('%'))
                {
                    result = Op1 % Op2;
                    Console.WriteLine("结果为:{0}", result);

                }
            }
        }
        static void Main(string[] args)
        {
            Person p = new Person();
            Calculator c = new Calculator();
            p.Use(c);
        }
    }
}
