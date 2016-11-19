using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndCalcu
{

    class People
    {
        public void Use(Calcuror c)
        {

            Console.Write("请输入第一个数字:");
            double number1;
            number1 = double.Parse(Console.ReadLine());

            Console.Write("请输入第二个数字:");
            double number2;
            number2 = double.Parse(Console.ReadLine());

            Console.Write("请输入运算符:");
            char oper;
            oper = char.Parse(Console.ReadLine());

            c.Calculate(number1, number2,oper);
        }
    }
    class Calcuror
    {
        public void Calculate(double op1,double op2,char oper)
        {

            if (oper.Equals('+'))
            {
                Console.WriteLine("{0}", (op1 + op2));
 
            }
            if (oper.Equals('-'))
            {
                Console.WriteLine("结果为:{0}", (op1 - op2));

            }
            if (oper.Equals('*'))
            {
                Console.WriteLine("结果为:{0}", (op1 * op2));

            }
            if (oper.Equals('%'))
            {
                Console.WriteLine("结果为:{0}", (op1 % op2));

            }
            if (oper.Equals('/'))
            {
                Console.WriteLine("结果为:{0}", (op1 / op2));

            }
            //Console.WriteLine("{0}", (op1 + op2));
            //Console.WriteLine("这是计算器的方法");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            People p = new People();
            Calcuror c = new Calcuror();
            p.Use(c);
        }
    }
}
