using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test3
{
    public class Animal
    {
        public string Aname { get; set; }
        public Animal(string aname)
        {
            this.Aname = aname;
        }
    }
    public class Person
    {
        public string Name { get; set; }
        public Person(string name)
        {
            this.Name = name;
        }
        public void Feed(Animal a,Food f)
        {
            Console.WriteLine("{0}拿{1}喂{2}", this.Name, f.Fname, a.Aname);

        }
    }
    public class Cat : Animal
    {
        public Cat(string name):base(name)
        {
            
        }
    }
    public class Dog : Animal
    {
        public Dog(string name)
            : base(name)
        {
            
        }
    }
    public class Elephant : Animal
    {
        public Elephant(string name)
            : base(name)
        {
            
        }
    }
    public class Food
    {
        public string Fname { get; set; }
        public Food(string fname)
        {
            this.Fname = fname;
            
 
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person("饲养员");
            Animal a1 = new Cat("猫");
            Animal a2 = new Dog("狗");
            Animal a3 = new Elephant("大象");
            Food f1 = new Food("鱼");
            Food f2 = new Food("肉");
            Food f3 = new Food("香蕉");
            p.Feed(a1, f1);
            p.Feed(a2, f2);
            p.Feed(a3, f3);

        }
    }
}
