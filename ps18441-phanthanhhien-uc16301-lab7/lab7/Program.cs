using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab7
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new CustomerDataContext(@"Server=TUNGTEK-LAM0019\MSSQLSERVER08;Database=northwind;Trusted_Connection=True;"))
            {
                ////Sử dụng lớp datacontext tương tác lấy dữ liệu

                var customers = db.Customers.ToList();

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.CompanyName);
                }


                //Sử dụng lớp datacontext tương tác thêm dữ liệu với InsertOnSubmit

                //var customer = new Customer()
                //{
                //    CustomerID = "Fpoly",
                //    CompanyName = "FPT"
                //};
                //db.Customers.InsertOnSubmit(customer);
                //db.SubmitChanges();

                //Sử dụng lớp datacontext tương tác cập nhật dữ liệu với SubmitChanges()

                //var customer = db.Customers
                //                   .Where(c => c.CustomerID == "Fpoly")
                //                   .FirstOrDefault();
                //customer.CompanyName = "FE";
                //db.SubmitChanges();

                //Sử dụng lớp datacontext tương tác xóa dữ liệu với DeleteOnSubmit

                //var customer = db.Customers
                //    .Where(c => c.CustomerID == "Fpoly")
                //    .FirstOrDefault();
                //db.Customers.DeleteOnSubmit(customer);
                //db.SubmitChanges();

                //Database First: sử dụng LINQ to SQL Inner Join liên kết các bảng dữ liệu

                //var result = from c in db.Customers
                //             join o in db.Orders on c.CustomerID equals o.CustomerID
                //             select new
                //             {
                //                 conName = c.ContactName,
                //                 shipName = o.ShipName
                //             };
                //foreach (var x in result)
                //{
                //    Console.WriteLine(x);
                //}
                //Console.ReadLine();
            }
            Console.ReadLine();
        }
    }
}
