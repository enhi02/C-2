using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_Asg_
{
    class HocVien
    {
        public string Maso { get; set; }
        public string Hoten { get; set; }
        public string Email { get; set; }
        public float Diem { get; set; }
        public HocVien()
        {
        }
        public HocVien( string maso, string hoten, float diem,string email)
        {
        }
        public void nhap()
        {
            Console.Write(" Ma so sv:");
            this.Maso = Console.ReadLine();

            Console.Write("Ho Ten sv:");
            this.Hoten = Console.ReadLine();

            Console.Write("email:");
            this.Email = Console.ReadLine();

            Console.Write("Diem:");
            this.Diem = float.Parse(Console.ReadLine());
        }
        public void Xuat()
        {
            Console.WriteLine($" Ma So:{Maso} - Ten:{Hoten} - Email :{Email}  -Diem :{Diem}- Hoc Luc  :{GetHocLuc()}");
        }
       
        public string GetHocLuc()
        {
            string hocluc = "Xuat Sac";
           
             if (Diem >= 7.5)
            {
                hocluc = "Gioi";
            }
            else if (Diem >= 6.5)
            {
                hocluc = "Kha";
            }
            else if (Diem >= 5 && Diem < 6.5)
            {
                hocluc = "Trung binh";
            }
            else
            {
                hocluc = "Yeu";
            }
            return hocluc;
        }
    }
}

