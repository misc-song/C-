using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMS.DAL;
using MMS.Model;
using System.Data;

namespace MMS.BLL
{
    public class Business
    {
        public static bool checkLogin(string account, string pwd)
        {
           // ADO.selectByName(account);
            if (ADO.selectByName(account).ACCOUNT != null && ADO.selectByName(account).PASSWORD!=null)


                return true;

            else
                return false;
        }
        public static string getID(string account)
        {
            return ADO.getID(account);
        }

        public static bool register(string account, string pwd)
        {
            //调用数据库的插入命令
           return( ADO.Register_Insert(account, pwd));
        }
        public static DataTable categorySearchALL()
        {

            return ADO.categroySearchAll();//方法
 
        }
        public static DataTable categorySearchBYName(string name)//
        {
            return ADO.categroySearchByName(name);
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
        public static bool AddDetial(string content,string date,int money)//向费用明细中插入一条记录
        {

            return ADO.AddDetial(content, date, money);//方法

        }
       
    }
}
