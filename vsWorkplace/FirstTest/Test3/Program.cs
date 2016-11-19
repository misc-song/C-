using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    public class Person 
    {
        public string Name { get; set; }
        public int Age { set; get; }
        public string Sex { set; get; }
        public Person(string name,int age,string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
 
        }
    }
    class Student:Person
    {
        //public List<int> FiveGrade = new List<int>(); 
        /***************定义五个变量用于保存五门课的成绩******************/
        public double Grade1 { get; set; }
        public double Grade2 { get; set; }
        public double Grade3 { get; set; }
        public double Grade4 { get; set; }
        public double Grade5 { get; set; }
        public Student(string name, int age, string sex, double grade1, double grade2, double grade3, double grade4, double grade5)
            : base(name, age, sex)
        {
            this.Grade1 = grade1;
            this.Grade2 = grade2;
            this.Grade3 = grade3;
            this.Grade4 = grade4;
            this.Grade5 = grade5;
 
        }
        public  double CalcuEqualGrade()//求平均值
        {
            //foreach (int a in FiveGrade)
            //{ 
            //}
            double totalGrade = this.Grade1 + this.Grade2 + this.Grade3 + this.Grade4 + this.Grade5;
            double equalGrade = totalGrade / 5;
            return equalGrade;
             
        }
 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student("张三", 15, "男", 65, 70, 78, 97, 45);//实例化对象

            Console.WriteLine( s.CalcuEqualGrade());//打印平均成绩
        }
    }
}
