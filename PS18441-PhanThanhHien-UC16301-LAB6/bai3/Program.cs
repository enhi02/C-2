using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] little = { 0, 1, 2, 3, 4, 5, 6 };
            int[] big = { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("---------------1 A-----------------\n");
            var a = little.Union(big).ToList();
            //Query Syntax
            var b = (from num in little
                     select num)
                      .Union(big).ToList();
            foreach (var item in a)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n---------------1 B-----------------\n");

            var x = little.Intersect(big).ToList();
            //Query Syntax
            var y = (from num in little
                     select num)
                      .Union(big).ToList();
            foreach (var item in x)
            {
                Console.Write(item);
            }
            Console.WriteLine("\n---------------1C-----------------\n");
            var result = little.Concat(big);
            foreach (var item in result)
            {
                Console.Write(item);
            }

            Console.WriteLine("\n---------------1D-----------------\n");

            var c = little.Except(big).ToList();
            //Query Syntax
            var d = (from num in little
                     select num)
                      .Except(big).ToList();
            foreach (var item in c)
            {
                Console.Write(item);
            }
            Console.ReadKey();
        }
    }
}
