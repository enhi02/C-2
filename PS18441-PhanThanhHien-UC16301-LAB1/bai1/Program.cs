using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    static class mycollege
    {
        public static string collegename;
        public static string address;
        static mycollege()
        {
            collegename = "FPT polytechnic";
            address = "391 Nam Kì Khơi Nghĩa, Q.3, TP. Hồ Chí Minh";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(mycollege.collegename);
            Console.WriteLine(mycollege.address);
            Console.Read();
        }
    }
}
