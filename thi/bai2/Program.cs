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
            using (var db = new customerDataContext(@"Server=TUNGTEK-LAM0019\MSSQLSERVER08;Database=northwind;Trusted_Connection=True;"))
            {
                Console.OutputEncoding = Encoding.UTF8;

                //1. Xuất ra màn hình các thông tin ContactName trong table Customers.
                //var customers = db.Customers.ToList();
                //foreach (var customea in customers)
                //{
                //    Console.WriteLine(customea.ContactName);
                //}

                //2. Thêm một dòng dữ liệu vào bảng Customers với dữ liệu CustomerID=”Fpoly” và CompanyName = “FPT”
                Console.WriteLine("thêm được rồi");
                var customer = new Customer()
                {
                    CustomerID = "Fpoly2",
                    CompanyName = "FPT"
                };
                db.Customers.InsertOnSubmit(customer);
                db.SubmitChanges();
            }
        }
    }
}
