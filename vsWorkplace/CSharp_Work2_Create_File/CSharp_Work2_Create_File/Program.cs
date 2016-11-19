using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSharp_Work2_Create_File
{
    class Program
    {
        public static void CreateFile(string path)
        {
            //判断文件是否存在,不存在则创建这个文件
            if (!File.Exists(path))
            {
                File.Create(path);
                //Console.WriteLine("文件不存在");
            }
            //else 
            //{
            //    Console.WriteLine("文件已经存在");
            //}
        }
        public static string ReName(string path, string newName)
        {
            //判断文件是否存在重名,返回修改后的路径名,否则返回空字符串
            string newPath = "";
            if (File.Exists(path))
            {
                newPath = path.Substring(0, path.LastIndexOf(@"\") + 1) + newName + Path.GetExtension(path);
                File.Move(path, newPath);
            }
            return newPath;
        }
        public static void DeleteFile(string path)
        {
            //判断如果文件存在则删除文件
            if (File.Exists(path))
            {
                File.Delete(path);
 
            }
        }
        static void Main(string[] args)
        {
            //string path = @"C:\Users\shj\Desktop\mytest\test.txt";
            
            /********************练习一************************/
            //CreateFile(path);
            //if (File.Exists(path))
            //{
            //    Console.WriteLine("创建文件成功");
            //}

            /********************练习二*********************/
            //string newName = "newtest";
            //string newPath = ReName(path, newName);
            //if (!String.IsNullOrEmpty(newPath) && File.Exists(newPath))
            //{
            //    Console.WriteLine("修改文件名成功");
            //}

            /*******************练习三*********************/
            string newFilePath = @"C:\Users\shj\Desktop\mytest\newtest.txt";
            DeleteFile(newFilePath);
            if (!File.Exists(newFilePath))
            {
                Console.WriteLine("文件删除成功");
            }

        }
    }
}
