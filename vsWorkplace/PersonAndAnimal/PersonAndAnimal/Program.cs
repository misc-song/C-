using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonAndAnimal
{
    class Person
    {
        public string Name;
        
        public Person(string name)
        {
            this.Name = name;
            Console.WriteLine("{0}进入场景...", this.Name);
        }
        public string Reply(Person name, string ask)
        {
            string awser;
            Console.WriteLine(ask);

            if (ask.Equals("你是谁啊?"))
            {
                awser = "不知道";
 
            }
            else
            {
                awser = "杏花村";
            }
                return awser;
 
        }
        public void Ride(Animal cow)
        {
            Console.WriteLine("{0}正在骑着{1}",this.Name,cow.Role);
 
        }
    }
    class Animal
    {
        public Animal(string name)
        {
            this.Role = name;
            Console.WriteLine("{0}进入场景...", this.Role);
           
        }
        public String Role { get; set; } 
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person passenger = new Person("行人");
            Person cowboy = new Person("牧童");
            Animal cow = new Animal("牛");
            Console.WriteLine();
            cowboy.Ride(cow);
            Console.WriteLine();
            string result = cowboy.Reply(passenger, "你是谁啊?");
            Console.WriteLine("回答的内容是:{0}", result);
            Console.WriteLine();
            result = cowboy.Reply(passenger, "哪里有酒家呀?");
            Console.WriteLine("回答的内容是:{0}", result);
        }
    }
}
