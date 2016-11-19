using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Dog 
    {
        public string Name { get; set; }
        public int Age{get;set;}
        public void Play(string toy)
        {
            Console.WriteLine("{0}岁的{1}正在玩{2}",this.Age, this.Name, toy);
        }
        public Dog(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog("秋天犬",12);
            //myDog.Name = "二狗子";
            myDog.Play("玩具");
        }
    }
}
