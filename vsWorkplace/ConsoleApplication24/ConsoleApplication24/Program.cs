using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication24
{
    class Program
    {
        static void waterNumber(string str)
        {
            List<int> total = new List<int>();
            int count = str.Length;
            
            List<int> num = new List<int>();
            int totalNum = int.Parse(str);
            for (int i = 0; i < count; i++)
            {
                num.Add (Convert.ToInt32(str[i])-48);
                //Console.WriteLine(str[i]);
                //total = k;
               // Console.WriteLine(k);
                int k = 1;
                for (int c = 0; c < count; c++)
                {
                    k *= num[i];
                }
                
                total.Add (k);
            }
            int m ;
            int ss = 0;
            for ( m=0 ; m < count; m++) 
            {
                
                ss += total[m];
               
            }
            if (totalNum == ss)
            {
                Console.WriteLine("是水仙花数");
              
            }
            else
            {
                Console.WriteLine("不是水仙花数");
               
            }
           
        }
        static void Main(string[] args)
        {
            string str;
            str = Console.ReadLine();
            waterNumber(str);
        }
    }
}
