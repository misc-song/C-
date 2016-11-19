using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XXX.MODEL;
namespace XXX.BIL
{
    public class Business
    {
        public static List<admin> getUserById(int id)
        {
            string sql = "select * from [admin] where id = @id";
            SqlParameter[] para = { new SqlParameter("@id", id) };
            return sqlHelper.ExecuteReader<admin>(CommandType.Text, sql, para);
        }//通过ID来获取用户信息 返回一个对象列表
        public static List<admin> getUserByName(string name)
        {

            string sql = "select * from [admin] where account = @account";
            SqlParameter[] para = { new SqlParameter("@account", name) };

            return sqlHelper.ExecuteReader<admin>(CommandType.Text, sql, para);
        }//通过名字来获取用户信息 返回一个对象列表
        public static List<admin> selectAll()
        {
            string sql = "select * from [admin]";

            return sqlHelper.ExecuteReader<admin>(CommandType.Text, sql, null);
        }//遍历整张表返回一个对列表
        public static Boolean insertUser(string account,string passwd)
        {
            string sql = "insert into [admin](account,passwd) values(@account,@passwd)";
            SqlParameter[] para = { 
                                      new SqlParameter("@account", account) ,
                                      new SqlParameter("@passwd", passwd) 
                                  };
            return sqlHelper.ExecuteNonQuery(CommandType.Text, sql, para);
           
        }//向表中插入一条记录
        public static Boolean updateUser(string account, string passwd,int id)//通过id来修改表中的一条记录
        {
            string sql = "upadate [admin] set [account]=@account and [passwd] = @passwd where id=@id";
            SqlParameter[] para = { 
                                       new SqlParameter("@id", id) ,
                                      new SqlParameter("@account", account) ,
                                      new SqlParameter("@passwd", passwd) 
                                  };
            return sqlHelper.ExecuteNonQuery(CommandType.Text, sql, para);
        }//
        public static Boolean deleteById(int id)//通过id来删除一条记录
        {
            string sql = "delete from [admin] where id = @id";
            SqlParameter[] para = { new SqlParameter("@id", id) };
            return sqlHelper.ExecuteNonQuery(CommandType.Text, sql, para);
        }

    }
}
