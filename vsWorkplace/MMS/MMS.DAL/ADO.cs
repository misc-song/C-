using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MMS.Model;
using System.Data;
using System.Data.SqlClient;

namespace MMS.DAL
{
    public class ADO
    {
        public static string getID(string account)
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select [password] from [user] where [account] ='"+account+"'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string str;
            reader.Read();
            
            str = reader["ID"].ToString();
               
            
            conn.Close();
            return str;
        }
        public static User selectByName(string name)//登录
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select ACCOUNT,[PASSWORD] from [USER] where [ACCOUNT]='" + name + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User u = new User();
            while (reader.Read())
            {

                u.ACCOUNT = reader["ACCOUNT"].ToString();
                u.PASSWORD = reader["PASSWORD"].ToString();
            }
            conn.Close();
            return u;
        }
        public static bool Register_Insert(string name, string pwd)//注册
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "insert into [user](ACCOUNT,PASSWORD)values('" + name + "','" + pwd + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int u = cmd.ExecuteNonQuery();
            conn.Close();
            if (u > 0)
                return true;
            else
                return false;
        }
        public static DataTable categroySearchAll()//查询所有费用项目
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from category";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable categroySearchByName(string name)//以项目名称的形式查询
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from category where name='%"+name+"%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }


        public static DataTable detailSearchAll()//查询所有费用项目
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from detail";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable detailSearchByName(string name)//以项目名称的形式查询
        {
            SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from detail where content='%" + name + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }

        /// <summary>
        /// 给detail表中插入一条记录
        /// </summary>
        /// <param name="content"></param>
        /// <param name="date"></param>
        /// <param name="money"></param>
        /// <returns></returns>
         public static bool AddDetial(string content, string date, int money)
         {
             SqlConnection conn = new SqlConnection("server=.;database=mms;uid =sa;pwd = 111111");
             conn.Open();
             string sql = "insert into detail(content,date,money) values('" + content + "','" + date + "'," + money + ")";
             SqlCommand cmd = new SqlCommand(sql, conn);
             int i = cmd.ExecuteNonQuery();
             if (i > 0)
             {
                 return true;
             }
             else 
             {
                 return false;
             }
         }
    }
}
