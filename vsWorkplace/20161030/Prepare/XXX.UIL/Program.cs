using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XXX.BIL;
using XXX.MODEL;
namespace XXX.UIL
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("请选择你的操作:");
                Console.WriteLine("0:通过id获取用户信息;");
                Console.WriteLine("1.遍历整个表;");
                Console.WriteLine("2.向表中插入一个数据;");
                Console.WriteLine("3.删除表中的一条记录;");
                Console.WriteLine("4.退出系统;");
                int select = int.Parse(Console.ReadLine());
                #region
                switch (select)
                {
                    case 0:
                        {
                            #region   通过id获取用户信息
                            Console.WriteLine("请输入用户的ID:");
                            int id = int.Parse(Console.ReadLine());
                            foreach (admin ad in Business.getUserById(id))
                            {
                                Console.WriteLine("{0}\t,{1}\t,{2}\t", ad.id, ad.account, ad.passwd);
                            }
                            #endregion
                            break;
                        }
                    case 1:
                        {

                            #region 遍历整个表
                            Console.WriteLine("id, account,passwd");
                            foreach (admin ad in Business.selectAll())
                            {
                                Console.WriteLine("----------------------------------------------------");
                                Console.WriteLine("{0}\t|{1}\t|{2}\t|", ad.id, ad.account, ad.passwd);
                                Console.WriteLine("----------------------------------------------------");
                            }
                            #endregion
                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("请输入用户的账号:");
                            string account = Console.ReadLine();
                            Console.WriteLine("请输入用户的密码:");
                            string passwd = Console.ReadLine();
                            #region  向表中插入一个数据
                            if (Business.insertUser(account, passwd) == true)
                            {
                                Console.WriteLine("插入成功");
                            }
                            else
                            {
                                Console.WriteLine("插入失败");
                            }
                            #endregion
                            break;
                        }
                    case 3:
                        {
                            #region 删除表中的一条记录
                            Console.WriteLine("请输入需要删除的用户ID:");
                            int id = int.Parse(Console.ReadLine());
                            if (Business.deleteById(id) == true)
                            {
                                Console.WriteLine("删除成功");
                            }
                            else
                            {
                                Console.WriteLine("删除失败");
                            }
                            #endregion
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("输入有误请重新输入");
                            break;
                        }
                    case 4:
                        {
                            return;
                        }
                   
                #endregion
                }
            }
        }
    }
}
