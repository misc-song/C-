using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            /*路径path的操作*/
            //string path = @"I:\fileStream\file1.txt";
            //string p = Path.GetExtension(@"I:\fileStream\file1.docx");//获取文件的扩展名
            //Console.WriteLine(p);
            string p1 = Path.ChangeExtension(@"I:\fileStream\file2.html", "dat");
            Console.WriteLine("文件名已修改");



            /*读文件*/
            //string path = @"I:\fileStream\file.txt";
            //FileStream  fs = File.Open(path, FileMode.OpenOrCreate);
            //byte[] array = new byte[fs.Length];
            //fs.Read(array, 0, array.Length);
            //string content = Encoding.UTF8.GetString(array);
            //Console.WriteLine(content);
            //fs.Close();
            /*写文件*/
            //string path = @"I:\fileStream\file1.txt";
            //string content = "Hello world!";
            //FileStream fs = File.Open(path, FileMode.OpenOrCreate);
            //byte[] array = Encoding.UTF8.GetBytes(content);
            //fs.Write(array, 0, array.Length);
            //fs.Close();


        }
    }
}
