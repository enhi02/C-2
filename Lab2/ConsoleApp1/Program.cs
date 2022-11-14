using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //a
    //public class ImlicitlyVariable
    //{
    //    static dynamic imp = 15;
    //    //Main method
    //    static public void Main()
    //    {
    //        //trying to print the value of 'imp'
    //        Console.WriteLine(imp);
    //        Console.ReadLine();
    //    }
    //}

    //b
    //class Program
    //{
    //    static void Main()
    //    { 
    //        var data = new Dictionary<string, int>();
    //        data.Add("cat", 2);
    //        data.Add("dog", 1);
    //        Console.WriteLine("cat -dog ={0}", data["cat"]-data["dog"]);
    //        Console.ReadLine();
    //    { 

    //}

    //c
    //class Program
    //{
    //    static void Main(string[]args)
    //    {
    //        GetDetails(100);
    //        GetDetails("Welcome to FPoly");
    //        GetDetails(true);
    //        GetDetails(20.50);
    //        Console.ReadLine();
    //    }

    //    static void GetDetails(dynamic d)
    //    {
    //        Console.WriteLine(d);
    //    }
    //}

    //d
    class Program
    {
        static void Main(string[] args)
        {
            dynamic dobj = new user();
            dobj.Getdetalis(10);

            dobj.Getdetalis("hien");
            Console.ReadLine();
        }
    }
    class user
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public void Getdetalis(dynamic d)
        {
            Console.WriteLine(d);
            
        }

    }

}
//}
//}
