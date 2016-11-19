

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpClient
{
    /// <summary>
    /// 抽象父类
    /// </summary>
    public abstract class User
    {
        public string Account { get; set; }

        public User(string account)
        {
            this.Account = account;
        }
        public virtual void Login()
        {

            Console.WriteLine("请用{0}账号登录", this.Account);


        }
    }
    /// <summary>
    /// 密封子类
    /// </summary>
    public sealed class OridinaryUser : User
    {
        public OridinaryUser(string account) : base(account)
        {
            //this.Account = account;
        }

    }
    public sealed class VIPUser : User
    {
        public VIPUser(string account, string phone)
            : base(account)
        {

            this.Phone = phone;

        }

        public string Phone { get; set; }
        public override void Login()
        {
            Console.WriteLine("使用{0}账号登录,手机号是{1}", this.Account, this.Phone);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //User u1 = new OridinaryUser("zhangsan");
            //u1.Login();

            //OridinaryUser u2 = new OridinaryUser("lisi");
            //u2.Login();
            //VIPUser u3 = new VIPUser("lisi", "1333456677");
            //u3.Login();
            User u4 = new VIPUser("laowang", "12345");
            u4.Login();

        }
    }
}


