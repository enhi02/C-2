using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            IList<int> intlist = new List<int>() { 7, 10, 21, 30, 45, 50, 87 };
            IList<string> strlist = new List<string>() { null, "Two", "Three", "Four", "Five" };
            IList<string> emptylist = new List<string>();

            Console.Write("số chẵn đầu tiên trong inlist: " + intlist.FirstOrDefault(x => x % 2 == 0));
            Console.Write("\ntìm phần tử cuối cùng trong inlist có giá trị > 200: " + intlist.LastOrDefault(x => x > 200));
            Console.Write("\n tìm phần tử đầu tiên trong strlist có giá trị bất đầu bằng ký tự 'T' : " + strlist.FirstOrDefault(x => x != null && x.Contains("T")));

            int sum = 0;
            for (int i = 1; i < intlist.Count; i += 2)
            {
                sum += intlist.ElementAt(i);
            }
            Console.WriteLine("sum: " + sum);
            Console.ReadLine();
        }
    }
}
