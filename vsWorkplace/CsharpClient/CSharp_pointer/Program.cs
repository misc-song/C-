using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_pointer
{
    
    class Program
    {
        unsafe static int MyMethod() 
        {
            //int[] arr =new int[4]{ 1, 2, 3, 4 };
            int a = 7;
            int b = 6;
            int* p;
            p = &a;
            int* pt;
            pt = &b;
            Console.WriteLine("a的值为{0},b的值为:{1}",*p,*pt);
            return 0;



        }
        static void Main(string[] args)
        {
            MyMethod();
        }
    }
}
