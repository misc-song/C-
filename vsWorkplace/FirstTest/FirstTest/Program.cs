using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTest
{
    public class Bill
    
    {
        public double SinglePrice { get; set; }
        public int Number { get; set; }

        public double Discount { get; set; }
        public double Money { get; set; }

        public DateTime Time { get; set; }//毫无用处的属性
        public bool Promotion { get; set; }//促销
        public string MemberType { get; set; }

        public Bill(double singlePrice,int number,double discount,/*DateTime time,*/bool promotion,string memberType)
        {
            this.SinglePrice = singlePrice;
            this.Number = number;
            this.Discount = discount;
            //this.Time = time;
            this.Promotion = promotion;
            this.MemberType = memberType;
        }
        public double CalcuPrice()
        {
            double RowPrice = this.SinglePrice * this.Number;
            double Price=1;//初始化变量用于保存最终的价格
            if (this.MemberType.Equals("普通会员"))
            {
                Price = RowPrice * 1;
            }
            if (this.MemberType.Equals("黄金会员"))
            {
                Price = RowPrice * 0.9;
            }
            if (this.MemberType.Equals("白金会员"))
            {
                Price = RowPrice * 0.8;
            }
            if (this.Promotion == true)
            {
                Price = Price * 0.6;
            }
            return Price;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Bill b = new Bill(24,5,1,true,"黄金会员");
            Console.WriteLine(b.CalcuPrice());
        }
    }
}
