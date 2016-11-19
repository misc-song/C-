using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    public class BankAccount 
    {
        public string BankAccountId { get; set; }
        public DateTime Date { get; set; }
        public string Money { get; set; }
        public double Rest { get; set; }
        public BankAccount( string bankAccountId,DateTime date,string money,double rest)
        {
            this.BankAccountId = bankAccountId;
            this.Date = date;
            this.Money = money;
            this.Rest = rest;
 
        }
        public void Bankin() 
        {

        }
        public void Bankout() 
        {

        }
        public void AutoUp() 
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
