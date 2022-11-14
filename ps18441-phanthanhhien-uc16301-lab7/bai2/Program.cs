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
            using (var db = new CustomerDataContext(@"Server=TUNGTEK-LAM0019\MSSQLSERVER08;Database=northwind;Trusted_Connection=True;"))       
            {
                //a.1 Xuất ra màn hình các thông tin ContactName trong table Customers và 
                // ShipName trong bảng Order

                //var customers = db.Customers.ToList();

                //foreach (var customea in customers)
                //{
                //    Console.WriteLine(customea.ContactName);
                //}

                //a

                //var Orders = db.Orders.ToList();
                //foreach (var customea in Orders)
                //{
                //    Console.WriteLine(customea.ShipName);
                //}

                //b.Thêm một dòng dữ liệu vào bảng Customers với dữ liệu CustomerID=”Fpoly” và CompanyName = “FPT”
                //Console.WriteLine("thêm được rồi");
                //var customer = new Customer()
                //{
                //    CustomerID = "Fpoly",
                //    CompanyName = "FPT"
                //};
                //db.Customers.InsertOnSubmit(customer);
                //db.SubmitChanges();

                //c.Cập nhật CompanyName = “FE” tại CustomerID =”Fpoly”
                //Console.WriteLine("thành công");
                //var customer = db.Customers
                //                .Where(c => c.CustomerID == "Fpoly")
                //                .FirstOrDefault();
                //customer.CompanyName = "FE";
                //db.SubmitChanges();
                //Console.WriteLine("chay thanh cong");

                //d/ Xóa dòng có CustumerID=” ALFKI”
               
                var customer = db.Customers
                          .Where(c => c.CustomerID == "Fpoly")
                          .FirstOrDefault();
                if (customer != null)
                {
                    db.Customers.DeleteOnSubmit(customer);
                    db.SubmitChanges();                   
                }
            }
            Console.ReadLine();
        }
    }
}
