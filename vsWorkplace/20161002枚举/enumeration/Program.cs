using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumeration
{
    public enum Day
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Program
    {
        static void Main(string[] args)
        {
            ChooseDay(Day.Sunday);
            return;
        }
        static void ChooseDay(Day d)
        {
            switch (d)
            {
                case Day.Friday:
                    Console.WriteLine("烦人的一天");
                    break;
                case Day.Monday:
                    Console.WriteLine("无聊的一天");
                    break;
                case Day.Saturday:
                    Console.WriteLine("快了");
                    break;
                case Day.Tuesday:
                    Console.WriteLine("一周的开始");
                    break;
                case Day.Wednesday:
                    Console.WriteLine("开心的一天");
                    break;
                case Day.Sunday:
                    Console.WriteLine("时间过得好快啊");
                    break;


            }

        }
    }
}
