using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    //class Program
    //{
    //    //a
    //    static void Main(string[] args)
    //    {
    //        //Create anonymous type object

    //       var userInfo = new

    //        {
    //            Id = 1,
    //            Name = "Suresh Dasari",
    //            IsActive = true
    //        };
    //        //Access anonymous type object propoerties
    //        Console.WriteLine("Id:" + userInfo.Id);
    //        Console.WriteLine("Name:" + userInfo.Name);
    //        Console.WriteLine("IsActive:" + userInfo.IsActive);
    //        Console.ReadLine();

    //    }
    //}

    //b
    //class program
    //{
    //    static void Main(string[] args)
    //    {
    //        var userInfo = new
    //        {
    //            Id = 1,
    //            name = "hien",
    //            IsActive = true,
    //            jobInfo = new { designation = "Lead", location = "Hyderabad" }
    //        };
    //        Console.WriteLine("ID :" + userInfo.Id);
    //        Console.WriteLine("Name :" + userInfo.name);
    //        Console.WriteLine("isactive :" + userInfo.IsActive);
    //        Console.WriteLine("Designation: {0},location:{1}", userInfo.jobInfo.designation, userInfo.jobInfo.location);
    //        Console.ReadLine();
    //    }
    //}

    //c
    class Program
    {
        public delegate void MathOps(int a);
        static void Main(string[] args)
        {
            int y = 10;
            MathOps ops = delegate (int x)
            {
                Console.WriteLine("Add result: {0}", x + y);
                Console.WriteLine("Subtract Result: {0}", x - y);
            };
            ops(90);
            Console.ReadLine();
        }
    }
}
