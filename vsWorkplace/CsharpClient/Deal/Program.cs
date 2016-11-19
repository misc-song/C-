using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deal
{
    interface Price
    {
        void Compare(double salary);
    }
   public class Person :Price
    {
        public double Salary { get; set; }
        public void Compare(double salary)
        {
            if (this.Salary < 0)
            {
                throw new ArgumentOutOfRangeException("不存在金额");
            }
            if (this.Salary < 1000)
            {
                Group_leader grou = new Group_leader();
 
            }
            if (this.Salary >1000&&this.Salary<5000)
            {
                Manger man = new Manger();

            }
            if (this.Salary > 5000)
            {
                Chief chi = new Chief();

            }
            
        }

    }
    public class Group_leader 
    {
        public Group_leader()
        {
            Console.WriteLine("组长已审批");
        
        }
    }
    public class Manger
    {
        public Manger()
        {
            Console.WriteLine("经理已审批");
        }
    }
   public class Chief
    {
        public Chief()
        {
            Console.WriteLine("总监已审批");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();

           p.Salary = double.Parse(Console.ReadLine());
           p.Compare(p.Salary);
        }
    }
}
