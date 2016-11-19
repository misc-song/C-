using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            //XmlDocument document = new XmlDocument();
            //document.Load(@"E:\vsWorkplace\20161002枚举\xml\XMLFile1.xml");
            //XmlElement element = document.DocumentElement;
            //foreach (XmlElement Students in document.DocumentElement.ChildNodes)
            //{
            //    //读取数据   
            //    string name = Students.SelectSingleNode("Name").InnerText;
            //    string gender = Students.SelectSingleNode("Gender").InnerText;
            //    string age = Students.SelectSingleNode("Age").InnerText;
            //    Console.WriteLine("{0},{1},{2}", name, gender, age);
            //}
            
            //element.ParentNode.RemoveChild(element);
            
           // Console.WriteLine(x);
            CreateXml();
            //Console.ReadKey();
        }
        static void CreateXml()
        {
            string path = @"E:\vsWorkplace\20161002枚举\xml\XMLFile2.xml";
            XmlWriterSettings setting = new XmlWriterSettings();
            setting.Encoding = Encoding.UTF8;
            setting.Indent = true;
            setting.IndentChars = "\t";

            using (XmlWriter xw = XmlWriter.Create(path, setting))
            {
                xw.WriteStartElement("users");
                xw.WriteEndElement();
            }
        }
    }
}
