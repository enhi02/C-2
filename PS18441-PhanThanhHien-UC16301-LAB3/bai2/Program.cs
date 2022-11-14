using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDirectory();
            CreateFile();
            Console.ReadLine();
        }
        static void CreateDirectory()
        {
            DirectoryInfo dir = new DirectoryInfo("D:\\exemple");
            try
            {
                if (dir.Exists)
                {
                    Console.WriteLine("Directory already exists");
                    Console.WriteLine("Directory Name:" + dir.Name);
                    Console.WriteLine("Path: " + dir.FullName);
                    Console.WriteLine("Directory is created on : " + dir.CreationTime);
                    Console.WriteLine("Directory is Last Acc on" + dir.LastAccessTime);

                }
                else
                {
                    dir.Create();
                    Console.WriteLine("Directory created successfully. Infomation of directory");
                    Console.WriteLine("Directory Name: " + dir.Name);
                    Console.WriteLine("Path: " + dir.FullName);
                    Console.WriteLine("Directory is created on : " + dir.CreationTime);
                    Console.WriteLine("Directory is Last Acc on" + dir.LastAccessTime);
                }
            }
            catch (DirectoryNotFoundException d)
            {
                Console.WriteLine(d.Message.ToString());
            }
        }
        //// tao file
        static void CreateFile()
        {
            FileInfo file = new FileInfo("D:\\example\\test.txt");
            using (StreamWriter sw = file.CreateText())
            {
                sw.WriteLine("Hello file handling");
            }
            Console.WriteLine("\n\nDisplay file info");
            Console.WriteLine("File create on: " + file.CreationTime);
            Console.WriteLine("Diretory Name: " + file.DirectoryName);
            Console.WriteLine("Full name of file: " + file.FullName);
            Console.WriteLine("File is last acccessed on: " + file.LastAccessTime);
        }
    }
}
