using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 宋和俊
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入真实的id号码:");
            string id;
            id = Console.ReadLine();

            List<char> ch = new List<char>();
            List<char> ch1 = new List<char>();
            string str = "";
            string str1 = "";
            for (int i = 0; i < id.Length; i++)
            {
                if (i >= 0 && i <= 5)
                    ch.Add(id[i]); //6-13
                if (i >= 10 && i <= 17)
                    ch1.Add(id[i]);

            }
            foreach (char j in ch)
            {
                str = str + j;
            }
            foreach (char j in ch1)
            {
                str1 = str1 + j;
            }
            
            int fadeAge = 2016 - 20;
            fadeAge.ToString();
            Console.WriteLine("新的身份证号码是");
            Console.WriteLine(str+fadeAge+str1);
        }

    }
}
