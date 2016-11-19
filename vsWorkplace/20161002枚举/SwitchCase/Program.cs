using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchCase
{
    class Program
    {
        static void Main(string[] args)
        {
            //int j = int.Parse(Console.ReadLine());

            while(true)
            {
                int j = int.Parse(Console.ReadLine());
                switch (j)
                {
                    case 1:
                        {
                            Console.WriteLine("这是1");
                            break;

                        }
                    case 2:
                        {
                            Console.WriteLine("这是2");
                            break;

                        }
                    case 3:
                        {
                            Console.WriteLine("这是3");
                            break;
                        }
                    default:
                        Console.WriteLine("程序崩溃啦,不好意思!");
                        return;
            }
            

            }
        }
    }
}
