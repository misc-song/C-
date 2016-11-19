using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    public class Calculate1 
    {
        public double Op1 { get; set; }//操作数1
        public double Op2 { get; set; }//操作数2
        public char Oper { get; set; }//操作符

        public Calculate1(double op1, double op2, char oper)//可有可无的构造函数
        {
            this.Op1 = op1;
            this.Op2 = op2;
            this.Oper = oper;
        }
        public double CalcuPM()//加减法 运算方法
        {
            double result=0;
            if (this.Oper == '+')
            {
                result = this.Op1 + this.Op2;
            }
            if (this.Oper == '-')
            {
                result = this.Op1 - this.Op2;
            }
            return result;
        }
    }
    public class Calculate2 : Calculate1//Calculate2继承于Calculate1
    {
         public Calculate2(double op1, double op2, char oper):base(op1,op2,oper)
        {
            this.Op1 = op1;
            this.Op2 = op2;
            this.Oper = oper;
        }
         public new double CalcuPM()//乘除法 运算方法
         {
             double result = 0;
             if (this.Oper == '*')
             {
                 result = this.Op1 + this.Op2;
             }
             if (this.Oper == '/')
             {
                 result = this.Op1 - this.Op2;
             }
             return result;
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Calculate1 c1 = new Calculate1(12,34,'+');
            Calculate2 c2 = new Calculate2(13, 2, '*');
            Console.WriteLine(c1.CalcuPM());
            Console.WriteLine(c2.CalcuPM());

        }
    }
}
