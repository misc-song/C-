using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part2
{
    public class A 
    {
        private int _Mynumber = 1000;
        public int MyNumber 
        {
            get 
            {
                //Console.WriteLine(_Mynumber * 100);
                return _Mynumber / 100;
               
            }
            set
            {
                _Mynumber = value * 100;
                Console.WriteLine(_Mynumber);
            }                
        }
        //public A(int number)
        //{
        //    this.MyNumber = number;
        //}

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("其初始值为1000");
            Console.WriteLine("存储时");
            A a = new A();
            a.MyNumber = 1000;
            Console.WriteLine("读取时");
            A b = new A();
            Console.WriteLine(b.MyNumber);
           
            
        }
    }
}
