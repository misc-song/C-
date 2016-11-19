using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using note.DAL;
using note.MODEL;
using System.Data;
namespace note.BIL
{
    public class Business
    {
        public static bool checkLogin(string account, string pwd)
        {
            // ADO.selectByName(account);
            Console.WriteLine((ADO.selectByName(account).account));
            Console.WriteLine((ADO.selectByName(account).password));
            if (((ADO.selectByName(account).account) != null) && ((ADO.selectByName(account).password) != null))
           // if (((ADO.selectByName(account).account) == account) && ((ADO.selectByName(account).password) == pwd))
            {
                return true;
            }
            else

            {
                return false;
            }

        }
        public static string getID(string account)
        {
            return ADO.getID(account);
        }

        public static bool register(string account, string pwd, string name)
        {
            //调用数据库的插入命令
            return (ADO.Register_Insert(account, pwd, name));
        }

        public static DataTable categorySearchBYName(string name)//
        {
            return ADO.categroySearchByName(name);
        }
        public static DataTable noteOfMe(int id)//个人笔记
        {
            return ADO.noteOfMe(id);
        }
        public static DataTable noteOfALL()//所有的笔记
        {
            return ADO.noteOfALL();
        }

        public static DataTable GetMessByName(string name)
        {
            return ADO.GetMessByName(name);
        }
        public static DataTable detalSearchALL()//查询所有的费用明细
        {

            return ADO.detailSearchAll();//方法

        }
        public static DataTable detalSearchBYName(string name)//按照用户的内容查询费用明细
        {
            return ADO.detailSearchByName(name);
        }

        /// <summary>
        /// 向费用明细中插入一条记录
        /// </summary>
        /// <param name="content"></param>
        /// <param name="date"></param>
        /// <param name="money"></param>
        /// <returns></returns>
        public static bool AddContent(string content, DateTime date, int userid)//向费用明细中插入一条记录
        {

            return ADO.AddContent(content, date, userid);//方法

        }
        public static int GetAllMoney(int id)
        {
            return ADO.GetAllMoney(id);
        }


        public static Boolean UpdatePwd(string pwd)
        {
            return ADO.UPdatePasswd(pwd);
        }//修改密码
        public static String getPasswd(int id)
        {
            return ADO.selectByID(id).password;
        }//获取密码



        public static Boolean DeleteMess(int id)
        {

            return ADO.DeleMess(id);
        }
    }
}
