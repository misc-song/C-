using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @struct
{
    class Program
    {
        //public struct A 
        //{
        //     public int Number;
        //     public string Name;
        //     public A(int number, string name)
        //     {
        //         Number = number;
        //         Name = name;
 
        //     }
        //}
        static void Main(string[] args)
        {

            //A a = new A(name :"张三",number:25);
            ////a.Name = "张三";
            ////a.Number = 23;
            //Console.WriteLine(a.Name);
            //Console.WriteLine(a.Number);
            //Console.ReadKey();


            //var list = new ArrayList();
            //list.Add(12);
            //list.Add("think");
            //list.Add(123.67);

            //foreach (var i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();
            //var list = new List<int>();
            //list.Add(12);
            //foreach (var i in list)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.ReadKey();

            var list = new LinkedList<string>();
            list.AddLast("123");
            list.AddLast("string");
            list.AddLast("helloWorld");

            foreach (string a in list)
            {
                Console.WriteLine(a);
            }
            Console.ReadKey();


            
            
            
        }
    }
}
