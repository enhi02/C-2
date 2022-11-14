using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace lab8._1
{
    class Program
    {
        static object syncObj1 = new object();

        static object syncObj2 = new object();

        static void Foo()
        {
            Console.WriteLine("Inside Foo method ");
            lock(syncObj1)
            {
                Console.WriteLine("Foo : lock(syncObj1)");
                Thread.Sleep(100);
                lock(syncObj2)
                {
                    Console.WriteLine("Foo : lock(syncObj2)");
                }
            }    
        }
        static void Bar()
        {
            Console.WriteLine("Inside Foo method ");
            lock (syncObj2)
            {
                Console.WriteLine("Bar : lock(syncObj2)");
                Thread.Sleep(100);
                if(Monitor.TryEnter(syncObj2,1000))
                {
                    try
                    {           
                            Console.WriteLine("Bar : lock(syncObj1)");             
                    }
                    finally
                    {
                        Monitor.Exit(syncObj2);
                    }
                }    
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main Thread Started");
            Thread t1 = new Thread(Foo);
            Thread t2 = new Thread(Bar);

            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();
            Console.WriteLine("Main thread Completed");
            Console.ReadKey();
        }
    }
}
