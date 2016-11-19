using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace note.MODEL
{
    public class sqlHelper
    {
        //public static string connStr = System.Configuration.ConfigurationSettings.AppSettings["ConnStr"].ToString();
        public static String ConnStr = System.Configuration.ConfigurationManager.AppSettings["ConnStr"].ToString();
        /// <summary>
        /// Dml操作:插入，更新，删除
        /// </summary>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdPrams">命令的参数列表</param>
        /// <returns></returns>
        public static Boolean ExecuteNonQuery(CommandType cmdType, string cmdText, SqlParameter[] cmdPrams)
        {

            //创建连接对象
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnStr;

            try
            {
                conn.Open();
                //发布命令
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdText;
                cmd.Parameters.Clear();

                if (cmdPrams != null)
                {

                    foreach (SqlParameter p in cmdPrams)
                    {
                        cmd.Parameters.Add(p);
                    }
                }
                //执行命令
                int i = cmd.ExecuteNonQuery();

                return i > 0 ? true : false;


            }




            catch (Exception ex)
            {
                Console.Write("出现异常" + ex.Message);
                return false;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }
        }


        /// <summary>
        /// 执行DQL操作
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="cmdType">命令类型</param>
        /// <param name="cmdText">命令内容</param>
        /// <param name="cmdPrams">命令的参数列表</param>
        /// <returns>返回一个list</returns>
        public static List<T> ExecuteReader<T>(CommandType cmdType, string cmdText, SqlParameter[] cmdPrams) where T : new()
        {
            //结果
            List<T> list = new List<T>();

            //创建连接对象
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConnStr;

            try
            {

                conn.Open();

                //打开连接


                //发布命令
                //发布命令
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = cmdType;
                cmd.CommandText = cmdText;


                cmd.Parameters.Clear();

                if (cmdPrams != null)
                {

                    foreach (SqlParameter p in cmdPrams)
                    {
                        cmd.Parameters.Add(p);
                    }
                }


                //执行命令
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    T s = new T();
                    Type classType = s.GetType();

                    PropertyInfo[] ps = classType.GetProperties();

                    foreach (PropertyInfo pi in ps)
                    {
                        try
                        {
                            object v = reader[pi.Name];
                            pi.SetValue(s, v, null);
                        }
                        catch
                        {

                        }
                    }

                    //s.Sno = reader["SNO"].ToString(),
                    //s.Sname = reader["SNAME"].ToString(),
                    //s.Status = int.Parse(reader["STATUS"].ToString()),
                    //s.City = reader["CITY"].ToString()


                    list.Add(s);
                }
                return list;
            }
            //关闭连接
            catch (Exception ex)
            {
                Console.Write("出现异常" + ex.Message);
                return null;
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }

        }
    }
}
