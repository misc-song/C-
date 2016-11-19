using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"I:\20161009\file";
            if (Directory.Exists(path))
            {
                DirectoryInfo di = new DirectoryInfo(path);
                DirectoryInfo[] diArr = di.GetDirectories();
                FileInfo[] diArr1 = di.GetFiles();
                foreach (DirectoryInfo dri in diArr)
                Console.WriteLine("当前目录下的内容为:{0}",dri.Name);
                foreach (FileInfo dri in diArr1)
                    Console.WriteLine("当前目录下的内容为:{0}", dri.Name);


            }
            else
            {
                Directory.CreateDirectory(path);
                
            }
            string pathf = @"I:\20161009\file\file.txt";
            string content = "Hello world!";
            FileStream fs = File.Open(pathf, FileMode.OpenOrCreate);
            byte[] array = Encoding.UTF8.GetBytes(content);
            fs.Write(array, 0, array.Length);
            Console.WriteLine("文件已经创建");
            fs.Close();
        }
    }
}
