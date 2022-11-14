using Microsoft.Azure.KeyVault.Models;
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
            var contacts = new List<Contact>
            {
                new Contact {Age = 11, FirstName = "Trump", LastName = "Donald", Address = "Ha Noi"},
                new Contact {Age = 21, FirstName = "Omaba", LastName = "Barrack", Address = "Sai Gon"},
                new Contact {Age = 31, FirstName = "Bush", LastName = "George", Address = "Ha Noi"},
                new Contact {Age = 41, FirstName = "Bill", LastName = "Clinton", Address = "Da Nang"},
                new Contact {Age = 51, FirstName = "Reagan", LastName = "Ronald", Address = "Da Nang"},
                new Contact {Age = 61, FirstName = "Jimmy", LastName = "Carter", Address = "Sai Gon"},
                new Contact {Age = 71, FirstName = "Gerald", LastName = "Ford", Address = "Ha Noi"},
                new Contact {Age = 81, FirstName = "Nixon", LastName = "Richard", Address = "Ha Noi"},
            };
            //1
            //a/ Xuất ra màn hình danh sách các người có Address là “Ha Noi”
            var list = from x in contacts
                       where x.Address.Contains("Ha Noi")
                       select x;
            Console.WriteLine("Nguoi Ha Noi : ");
            foreach (var x in list)
            {
                Console.WriteLine(x.Age + " " + x.FirstName + " " + x.Address);
            }
            Console.ReadLine();

            //b/ Tìm người có Age lớn nhất
            //var AgeM = contacts.Min(x => x.Age);
            //var listMinAgeM = contacts.Where(x => x.Age == AgeM);
            //Console.WriteLine("Age lon nhat : " + AgeM);
            //Console.ReadKey();

            //c / Cho biết danh sách contacts có bao nhiêu người?
            //var Snguoi = contacts.Count();
            //Console.WriteLine("So nguoi " + Snguoi);
            //Console.ReadKey();

            //2
            //a / Sắp xếp danh sách contacts theo đô tuổi tăng dần

            //Console.WriteLine("FirstName\tLastName\tAge\tAddress");
            //var Obcontacts = contacts.OrderBy(x => x.Age);
            //foreach (var item in Obcontacts)
            //{
            //    Console.WriteLine(item.FirstName + "\t\t" + item.LastName + "\t\t" + item.Age + "\t" + item.Address);
            //}
            //Console.ReadKey();

            //b / Sắp xếp danh sách contacts theo đô tuổi và Firstname giảm dần

            //Console.WriteLine("FirstName\tLastName\tAge\tAddress");
            //var DecContacts = contacts.OrderByDescending(x => x.Age).ThenByDescending(x => x.FirstName);
            //foreach (var item in DecContacts)
            //{
            //    Console.WriteLine(item.FirstName + "\t\t" + item.LastName + "\t\t" + item.Age + "\t" + item.Address);
            //}
            //Console.ReadKey();

            //c / Liệt kê danh sách các người có FirstName băt đầu bằng ký tự “B”

            //Console.WriteLine("FirstName\tLastName\tAge\tAddress");
            //var StartBcontacts = contacts.Where(x => x.FirstName.Substring(0, 1).Contains("B")).OrderBy(x => x.Age);
            //foreach (var item in StartBcontacts)
            //{
            //    Console.WriteLine(item.FirstName + "\t\t" + item.LastName + "\t\t" + item.Age + "\t" + item.Address);
            //}
            //Console.ReadKey();

            //3
            //Dùng LINQ ToLookup() Operator chuyển danh sách List<Contact> về định
            //dạng kiểu key/value và xuất toàn bộ thông tin ra màn hình
            //var listFirstNameToLookup = contacts.ToLookup(x => x.FirstName);
            //Console.WriteLine("Danh sách Key : ");
            //foreach (var x in listFirstNameToLookup)
            //{
            //    Console.WriteLine("Có key là: " + x.Key);
            //    foreach (var value in listFirstNameToLookup[x.Key])
            //    {
            //        Console.WriteLine("Age:" + value.Age);
            //        Console.WriteLine("LastName:" + value.LastName);
            //        Console.WriteLine("Address:" + value.Address);
            //    }
            //    Console.ReadKey();
            //}

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
