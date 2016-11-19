using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Clint
{
    class Program
    {
        static void Water(string str)
        {
           // char c;
            int [] num={};
            int total=0;
            int A =int.Parse(str);
            for (int i=0; i < str.Length; i++)
            {

                num[i] = (int)str[i] * (int)str[i] * (int)str[i];
               
            }
            for (int j = 0; j < num.Length; j++)
            {
                
                total += num[j];
               
            }
            if (A == total)
            {
                Console.WriteLine("{0}是水仙花数",str);
            }
            else
            {
                Console.WriteLine("{0}不是水仙花数",str);
            }
            
        }
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            Water(str);

        }
    }
}
