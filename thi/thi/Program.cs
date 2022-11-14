using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace thi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var contacts = new List<Contact>
            {
                new Contact {Age = 39, FirstName = "Dean", LastName = "Tran", Address = "Ha Noi"},
                new Contact {Age = 24, FirstName = "Mary", LastName = "Nguyen", Address = "Sai Gon"},
                new Contact {Age = 18, FirstName = "Pike", LastName = "Pham", Address = "Ha Noi"},
                new Contact {Age = 62, FirstName = "Thao", LastName = "Lee", Address = "Da Nang"},
                new Contact {Age = 51, FirstName = "Lan", LastName = "Ronald", Address = "Ha Noi"},
                new Contact {Age = 4, FirstName = "Jimmy", LastName = "Ly", Address = "Da Nang"},
               
            };
            //1. In danh sách những người ở “Da Nang”
            //var list = from x in contacts
            //           where x.Address.Contains("Da Nang")
            //           select x;
            //Console.WriteLine("Người Da Nang : ");
            //foreach (var x in list)
            //{
            //    Console.WriteLine(x.Age + " " + x.FirstName + " " + x.Address);
            //}
            //Console.ReadLine();

            // 1. In danh sách những người ở “Da Nang”
            var result = contacts.Where(x => x.Address == "Đà Nẵng" || x.Address == "Sài Gòn");

            foreach (var item in result)
            {
                Console.WriteLine($"Full Name:{item.FirstName,10} {item.LastName}, Age:{item.Age}, Address:{item.Address}");
            }

            //2. In tổng số người trong danh sách
            //var Snguoi = contacts.Count();
            //Console.WriteLine("Số người " + Snguoi);
            //Console.ReadKey();

            //3. In sách sách theo thứ tự tuổi từ lớn đến nhỏ
            //Console.WriteLine("FirstName\tLastName\tAge\tAddress");
            //var DecContacts = contacts.OrderByDescending(x => x.Age).ThenByDescending(x => x.FirstName);
            //foreach (var item in DecContacts)
            //{
            //    Console.WriteLine(item.FirstName + "\t\t" + item.LastName + "\t\t" + item.Age + "\t" + item.Address);
            //}
            //Console.ReadKey();

            //4. In người nhỏ tuổi nhất trong danh sách.
            //var AgeM = contacts.Min(x => x.Age);
            //var listMinAgeM = contacts.Where(x => x.Age == AgeM);
            //Console.WriteLine("Age lon nhat : " + AgeM);
            //Console.ReadKey();

            //5. In những người có tên bắt đầu bằng chữ “T”.
            //Console.WriteLine("FirstName\tLastName\tAge\tAddress");
            //var StartTcontacts = contacts.Where(x => x.FirstName.Substring(0, 1).Contains("T")).OrderBy(x => x.Age);
            //foreach (var item in StartTcontacts)
            //{
            //    Console.WriteLine(item.FirstName + "\t\t" + item.LastName + "\t\t" + item.Age + "\t" + item.Address);
            //}
            //Console.ReadKey();

        }
        private class Contact
        {
            public int Age { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Address { get; set; }
            public object Id { get; internal set; }
        }
    }
}

