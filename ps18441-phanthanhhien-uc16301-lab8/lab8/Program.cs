using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab8
{
    class Program
    {
       public static void yc1()
        {
            Random r = new Random();
            for(int i=1;i<100;i++)
            {
                int ramNum = r.Next(1,20);
                list.Add(ramNum);
                Thread.Sleep(200); 
            }
            Console.WriteLine("Kết thúc yc1 !");
        }
        public static void yc2()
        {
            Random r = new Random();
            for (int i = 1; i < 100; i++)
            {
                if(list.Count>0)
                {
                    int vitri = r.Next(0,list.Count-1);
                    int giatri = list[vitri];
                    Console.WriteLine("Bình phương tại vị trí  " + vitri +" là: " + giatri * giatri);
                   
                }
                Thread.Sleep(500);
            }
            Console.WriteLine("Kết thúc yc2!");
        }
        static List<int> list = new List<int>();
            static void Main(string[] args)
            {
            Console.OutputEncoding = Encoding.UTF8;
            ThreadStart childref1= new ThreadStart(yc1);
            Thread t1 = new Thread(childref1);

            ThreadStart childref2= new ThreadStart(yc2);
            Thread t2 = new Thread(childref2);

            Console.WriteLine("Bắt đầu t1!");
            t1.Start();

            Console.WriteLine("Bắt đầu t2!");
            t2.Start();
            Console.WriteLine("Kết thúc main");
            Console.ReadKey();
            }
    }
    
}
