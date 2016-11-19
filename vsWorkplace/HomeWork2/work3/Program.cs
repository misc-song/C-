using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work3
{
    public class Student
    {
        public string StuNum { set; get; }
        public int ClassNun { set; get; }
        public string StuName { set; get; }
        private int _age;
        public int StuAge 
        {
            get
            {
                return _age;
            }
            set
            {
                while (true)
                {
                    if (_age > 0 || _age < 100)
                    {
                        Console.WriteLine("年龄的范围有误,其范围是1-100");
                        break;
                    }
                    else
                    {
                        _age = value;
                        break;
                    }

                }

                 
            }  
        }
        private string _sex;
        public string StuSex 
        {
            get
            {
                return _sex;
            }
            set
            {
                while (true)
                {
                    if (_age > 0 || _age < 100)
                    {
                        Console.WriteLine("性别有误请输入男或者女");
                        break;
                    }
                    else
                    {
                        _sex = value;
                        break;
                    }

                }


            }  
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.StuNum = Console.ReadLine();
            s.StuName = Console.ReadLine();
            s.ClassNun = int.Parse(Console.ReadLine());
            s.StuSex = Console.ReadLine();
            s.StuAge = int.Parse(Console.ReadLine());


            Console.WriteLine(s.StuNum);
            Console.WriteLine(s.StuName);
            Console.WriteLine(s.ClassNun);
            Console.WriteLine(s.StuSex);
            Console.WriteLine(s.StuAge);
        }
    }
}
