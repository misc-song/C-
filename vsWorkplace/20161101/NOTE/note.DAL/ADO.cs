using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using note.MODEL;
using System.Data;
namespace note.DAL
{
    public class ADO
    {
        public static string getID(string account)
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select [ID] from [user] where [account] ='" + account + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            string str;
            reader.Read();

            str = reader[0].ToString();


            conn.Close();
            return str;
        }
        public static User selectByName(string name)//登录  这边是数据库的操作 试过很多遍了 应该不会错 直接跳过
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select ACCOUNT,[PASSWORD] from [USER] where [ACCOUNT]='" + name + "'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader reader = cmd.ExecuteReader();
            User u = new User();
            while (reader.Read())
            {

                u.account = reader["account"].ToString();
                u.password = reader["password"].ToString();
            }
            conn.Close();
            return u;
        }
        public static bool Register_Insert(string account, string pwd, string name)//注册
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "insert into [User](account,password,name)values('" + account + "','" + pwd + "','" + name + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            int u = cmd.ExecuteNonQuery();
            conn.Close();
            if (u > 0)
                return true;
            else
                return false;
        }
        public static DataTable noteOfMe(int id)//查询个人笔记
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from Message where [userid] = "+id+"";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }
        public static DataTable noteOfALL()//查询所有笔记
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from Message";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }


        public static DataTable GetMessByName(string name)//以用户名的形式查找笔记
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from [Message], [User] where [User].id = [Message].userid and [User].name like '%" + name + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
 
        }
        public static DataTable categroySearchByName(string name)//以项目名称的形式查询
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "select * from category where name='%" + name + "%'";
            SqlCommand cmd = new SqlCommand(sql, conn);
            DataTable dt = new DataTable();
            SqlDataAdapter dap = new SqlDataAdapter(cmd);
            dap.Fill(dt);
            conn.Close();
            return dt;
        }


        public static DataTable detailSearchAll()//查询所有费用项目
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
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
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
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
        public static bool AddContent(string content, DateTime date,int userid)//向message表中插入一条记录
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "insert into [Message](content,[date],userid) values('" + content + "','" + date + "','"+userid+"')";
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
        /// <summary>
        /// 获取当前花钱的总数
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static int GetAllMoney(int id)
        {
            SqlConnection conn = new SqlConnection("server=.;database=nms;uid=sa;pwd=111111");
            conn.Open();
            string cmdtext = "select sum([money]) from [detail] where [userid]=" + id + "";
            SqlCommand cmd = new SqlCommand(cmdtext, conn);
            int i = int.Parse(cmd.ExecuteScalar().ToString());

            return i;

        }
         public static Boolean UPdatePasswd(string pwd)
         {
             int id=User.UserID;
             SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
            conn.Open();
            string sql = "update [User] set password = '"+pwd+"' where id = "+id+"";
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
         public static User selectByID(int id)//登录
         {
             SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
             conn.Open();
             string sql = "select account,[password] from [User] where [id]='" + id + "'";
             SqlCommand cmd = new SqlCommand(sql, conn);
             SqlDataReader reader = cmd.ExecuteReader();
             User u = new User();
             while (reader.Read())
             {

                 u.account = reader["account"].ToString();
                 u.password = reader["password"].ToString();
             }
             conn.Close();
             return u;
         }



         public static Boolean DeleMess(int id)
         {
             SqlConnection conn = new SqlConnection("server=.;database=nms;uid =sa;pwd = 111111");
             conn.Open();
             string sql = "delete from message where id ="+id+"";
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
