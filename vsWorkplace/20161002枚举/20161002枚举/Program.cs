using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20161002枚举
{
    public enum Season
    {
        Winter,
        Spring,
        Summer,
        Fall
    }

    class Program
    {

        
        static void Main(string[] args)
        {
            Season season = Season.Fall;
            switch (season)
            {
                case Season.Fall:
                    Console.WriteLine("又到秋天了");
                    break;
                case Season.Spring:
                    Console.WriteLine("还是春天比较的爽");
                    break;
                case Season.Winter:
                    Console.WriteLine("冬天好冷啊");
                    break;
                case Season.Summer:
                    Console.WriteLine("夏天真好");
                    break;

            }
        }
    }
}
