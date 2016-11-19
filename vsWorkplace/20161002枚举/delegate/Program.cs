using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegated
{
    class DeleTest
    {
        public delegate void MyDelegate();
        public void DelegateTest(string name)
        {
            Console.WriteLine("hello"+name);
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            DeleTest md = new DeleTest();
            md.DelegateTest("张三");
        }
    }
}
