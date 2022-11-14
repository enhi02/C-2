using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace bai4
{
    class Program
    {
        static void Main(string[] args)
        {
            int times = 10000000;
            for(int listsize = 1; listsize < 10; listsize ++)
            {
                List<string> list = new List<string>();
                HashSet<string> hashet = new HashSet<string>();
                for(int i = 0; i < listsize; i++)
                {
                    list.Add("string" + i.ToString());
                    hashet.Add("string" + i.ToString());
                }
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i <times; i++)
                {
                    list.Remove("string0");
                    list.Add("string0");
                }
                timer.Stop();
                Console.WriteLine(listsize.ToString() + "item list strs time:" + timer.ElapsedMilliseconds.ToString() + "ms");
                timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i < times; i++)
                {
                    hashet.Remove("string0");
                    hashet.Add("string0");
                }
                timer.Stop();
                Console.WriteLine(listsize.ToString() + "item hashset strs  time" + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine("");
            }
            for(int listSize = 1; listSize < 10; listSize +=3)
            {
                List<object> list = new List<object>();
                HashSet<object> hashSet = new HashSet<object>();
                for(int i = 0; i< listSize; i++)
                {
                    list.Add(new object());
                    hashSet.Add(new object());
                }
                object objToaddRem = list[0];
                Stopwatch timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i < times; i++)
                {
                    list.Remove(objToaddRem);
                    list.Add(objToaddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + "item list objs time" + timer.ElapsedMilliseconds.ToString() + "ms");
                timer = new Stopwatch();
                timer.Start();
                for(int i = 0; i <times; i++)
                {
                    hashSet.Remove(objToaddRem);
                    hashSet.Add(objToaddRem);
                }
                timer.Stop();
                Console.WriteLine(listSize.ToString() + "item hashSet objs timme" + timer.ElapsedMilliseconds.ToString() + "ms");
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
        /*
            var names = new HashSet<string>();
            names.Add("sonoo");
            names.Add("ankit");
            names.Add("peter");
            names.Add("irfan");
            names.Add("ankit");
            foreach (var name in names)
            {
                Console.WriteLine(names);
            }
            Console.Read();
        */
    }
}
