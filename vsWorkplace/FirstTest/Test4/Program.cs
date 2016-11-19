using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test4
{
    public class Employee 
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public int SalaryLevel { get; set; }
        public static double MonthlyPay = 2500;//基本工资
        //public Employee(string name,string number,int salarylevel,double monthlypay)
        //{
        //    this.Name = name;
        //    this.Number = number;
        //    this.SalaryLevel = salarylevel;
        //    this.MonthlyPay = monthlypay;
        //}
        public double Pay(int day)//父类pay的计算方法用于计算请假的天数
        {
            double TotalSalary = (MonthlyPay / 30) * (30 - day);
                return TotalSalary;
 
        }
    }
    public class Technician : Employee
    {
        public double HourSalary { get; set; }
        public int Hour { get; set; }

        public int HardlyLevel { get; set; }
       

        public double Pay(double hoursalary , int hour,int hardlylevel)
        {
            double TotalSalary = hoursalary * hour * hardlylevel;
            return TotalSalary;
        }
    }
    public class Salesman : Employee
    {
        public double MonthSale { get; set; }
        public double PerformanceRatio { get; set; }

        public double Pay(double MonthSale, double PerformanceRatio)
        {
            double TotalSalary = MonthSale * PerformanceRatio;
            return TotalSalary;

 
        }
 
    }
    public class Manager : Employee
    {
        public double Bonus { get; set; }
        public double PerformanceRatio { get; set; }

        public double Pay(double Bonus, double PerformanceRatio)
        {
            double TotalSalary = Bonus * PerformanceRatio;
            return TotalSalary;


        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入需要计算的雇员:1.销售人员,2.技术人员,3.经理");
            int select;
            int day;
            select = int.Parse(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Employee e1 = new Employee();
                    Console.WriteLine("请输入请假的数");
                    day =int.Parse( Console.ReadLine());
                    //Console.WriteLine();
                    Salesman s = new Salesman();
                    Console.WriteLine(s.Pay(123, 4)+e1.Pay(day));
                    break;
                case 2:
                    Employee e2 = new Employee();
                    Console.WriteLine("请输入请假的数");
                    day =int.Parse( Console.ReadLine());
                    //Console.WriteLine();
                    Technician t = new Technician();
                    Console.WriteLine(t.Pay(1, 3, 5)+e2.Pay(day));
                    break;
                case 3:
                    Employee e3 = new Employee();
                    Console.WriteLine("请输入请假的数");
                    day =int.Parse( Console.ReadLine());
                    Manager m = new Manager();
                    //Console.WriteLine();
                    Console.WriteLine(e3.Pay(day)+m.Pay(12, 78));
                    break;
                default:
                    break;
            }
                
            

            

            
            
            


        }
    }
}
