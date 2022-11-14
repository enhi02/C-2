using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] n1 = new int[10] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // a  -Viết chương trình xuất bình phương các số chẵn > 4
            var abc = from num in n1
                      where (num % 2 == 0) && num > 4
                      select num * num;
            foreach (var num in abc)
            {
                Console.WriteLine("{0}", num);
            }

            // b/ Viết chương trình nhận vào một chuỗi ký tự, xuất ra màn hình số lần xuất hiện của từng ký tự trong chuỗi:

            Console.Write("\n\tXin moi nhap vào chuoi:");
            String sample = Console.ReadLine();

            var list = sample.GroupBy(c => c).Select(c => new { Char = c.Key, Count = c.Count() });
            foreach (var x in list)
            {
                Console.WriteLine(x.Char + " : " + x.Count);
            }

           // c / Viết chương trình nhận vào một chuỗi ký tự có các chuỗi con có viết hoa, xuất ra màn hình các chuỗi con được viết hoa

            Console.Write("\n LINQ : Find the uppercase words in a string :");
            Console.Write("\n--------------------------------------------------");

            string strNew;
            Console.Write("Input the string :");
            strNew = Console.ReadLine();

            var ucWord = WordFilt(strNew);
            Console.Write("\n The UPPER CASE words are : \n");
            foreach (string strRet in ucWord)
            {
                Console.WriteLine(strRet);
            }

            Console.ReadLine();
        }
        
        static IEnumerable<string> WordFilt(string mystr)
        {
            var upWord = mystr.Split(' ')
                        .Where(x => String.Equals(x, x.ToUpper(),
                                    StringComparison.Ordinal));
            return upWord;
        }
    }
}


