using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace Connect_Database
{
    class ConnDB
    {
        public void sqlconn()
        {
           

            SqlConnection conn = new SqlConnection("SERVER=SHJ-PC;DATABASE=studentandcourse;PWD=111111;UID=sa;");//创建一个连接
            //使用try...catch...finally语句确保释放资源
            try
            {

                conn.Open();//打开连接
                /*********************Do something usrful*********************/

                SqlCommand cmd = new SqlCommand("selectall", conn); //创建命令实例
                //DataSet ds = new DataSet();
                //SqlDataAdapter adp = new SqlDataAdapter(cmd);
                SqlDataReader reader = cmd.ExecuteReader();//创建sqldatareader实例 执行命令 返回一个实例化的IDataReader
                //adp.Fill(ds);
                while (reader.Read())//将数据读取并打印出来
                {
                    Console.WriteLine("Sno:{0} Cno:{1}", reader[0], reader[1]);
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine("尝试数据库连接失败{0}", ex);
               
            }
            finally
            {
                conn.Close();
            }

           // Console.ReadKey();
            

        } 
 
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            ConnDB db = new ConnDB();
            db.sqlconn();
            Console.ReadKey();
        }
    }
}
