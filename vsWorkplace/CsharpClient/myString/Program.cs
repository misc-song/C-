﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myString
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("这是Person的构造函数");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

        }
    }
}
