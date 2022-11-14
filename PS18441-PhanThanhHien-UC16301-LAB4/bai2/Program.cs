using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            ////a
            //List<dog> dogs = new List<dog>()
            //{
            //    new dog { Name = "Rex" , Age = 4},
            //    new dog { Name = "Sean" , Age = 0},
            //    new dog { Name = "stacy" , Age = 3},
            //};
            //var newdog = dogs.Select(tentuoi => new { Name = tentuoi.Name, Age = tentuoi.Age });
            //foreach (var dog in newdog)
            //{
            //    Console.WriteLine(dog);
            //}
            //Console.ReadLine();


            //b
            List<dog> dogs = new List<dog>()
            {
                new dog { Name = "Rex" , Age = 4},
                new dog { Name = "Sean" , Age = 0},
                new dog { Name = "stacy" , Age = 3},
            };
            var sortdog = dogs.OrderByDescending(x => x.Age);
            foreach (var dog in sortdog)
            {
                Console.WriteLine(string.Format("{0} : {1} .", dog.Name, dog.Age));
            }
            Console.ReadLine();
        }
    }
}
