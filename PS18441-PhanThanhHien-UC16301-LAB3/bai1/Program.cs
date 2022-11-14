using System;
using System.IO;
using System.Text;

namespace bai1
{
    class Program
    {
        //a
        static void Main(string[] args)
        {
            try
            {
                string file = @"D:\csharp\example.txt";
                //Creating File
                FileStream fs = new FileStream(file, FileMode.Create);
                //Adding current date and time in file
                byte[] bdata = Encoding.Default.GetBytes(DateTime.Now.ToString());
                fs.Write(bdata, 0, bdata.Length);
                Console.WriteLine("Data Added");
                fs.Close();
                //Reading File
                string data;
                FileStream fsread = new FileStream(file, FileMode.Open, FileAccess.Read);
                using (StreamReader sr = new StreamReader(fsread))
                {
                    data = sr.ReadToEnd();
                }
                Console.WriteLine(data);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message.ToString());
            }
            Console.ReadKey();
        }

        //////////////////////////////////////////////////////////////

        //b
        //string file = @"D:\example.txt";
        ////Creating and Writting
        //using (StreamWriter writer = new StreamWriter(file))
        //{
        //    writer.Write(DateTime.Now.ToString());
        //    Console.WriteLine("Successfully Added Current Date and Time");
        //}
        ////Reading File
        //using (StreamReader reader = new StreamReader(file))
        //{
        //    Console.Write("Reading Current Time : ");
        //    Console.WriteLine(reader.ReadToEnd());
        //}
        //Console.ReadKey();

        //////////////////////////////////////////////////////////////////    

        //c
//        string file = @"D:\example.txt";
//            //Writting File
//            using (TextWriter writer = File.CreateText(file))
//            {
//                writer.WriteLine(DateTime.Now.ToString());
//                Console.WriteLine("Successfully Added Current Date and Time");
//            }
////Reading Time
//using (TextReader reader = File.OpenText(file))
//{
//    Console.Write("Reading Current Time : ");
//    Console.WriteLine(reader.ReadToEnd());
//}
//Console.ReadLine();
        }
    }
}

