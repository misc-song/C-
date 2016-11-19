using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_class
{
    public abstract class Animal 
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Animal(string name ,int age)
        {
            this.Name = name;
            this.Age = age;
 
        }
    }
    public class Dog:Animal
    {

        public Dog(string name,int age):base(name,age)
        {
            //this.Name = name;
            //this.Age = age;
 
        }

    }
    //public sealed class Cat:Animal 
    //{
    //    public Cat(string name, int age)
    //        : base(name ,age)
    //    {
 
    //    }
    //}

    class Program
    {
        static void Main(string[] args)
        {
            Animal a = new Dog("汪汪", 12);
            Console.WriteLine("{0},{1}",a.Name, a.Age);

        }
    }
}
