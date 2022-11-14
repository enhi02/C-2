using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_Asg_
{
    class Program
    {
        static void Main(string[] args)
        {
            int chon;
            ArrayList list = new ArrayList();
            DSHocVien ds = new DSHocVien();
            do
            {
                Console.WriteLine("Chao mung ban den voi menu  Assignment cua mon #C");
                Console.WriteLine("______________________________________________________");
                Console.WriteLine("1.Nhap danh sach cac hoc vien                        |");
                Console.WriteLine("2.Xuat danh sach hoc vien                            |");
                Console.WriteLine("3.Tim kiem hoc vien tu khoang diem                   |");
                Console.WriteLine("4.Tim kiem hoc vien tu khoang hoc luc                |");
                Console.WriteLine("5.Tim kiem hoc vien tu ma so va cap nhap thong tin   |");
                Console.WriteLine("6.Sap xep hoc vien theo diem                         |");
                Console.WriteLine("7.Xuat 5 hoc vien co diem cao nhat                   | ");
                Console.WriteLine("8.Tinh diem trung binh cua lop                       |");
                Console.WriteLine("9.Xuat danh sach hoc vien co diem trung cua lop      |");
                Console.WriteLine("10.Tong hop cac hoc vien theo hoc luc                |");
                Console.WriteLine("0.Exit                                               |");
                Console.WriteLine("_____________________________________________________|");
                Console.Write("Xin moi nhap chuc nang :");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:

                        ds.Nhap();
                        Console.WriteLine("1.Nhap danh sach cac hoc vien");
                        break;
                    case 2:
                        ds.Xuat();
                        Console.WriteLine("2.Xuat danh sach hoc vien");
                        break;
                    case 3:
                        ds.yeucau3();
                        ds.Xuat();
                        Console.WriteLine("3.Tim kiem hoc vien tu khoang diem");
                        break;
                    case 4:
                        ds.yeucau4();
                        ds.Xuat();
                        Console.WriteLine("4.Tim kiem hoc vien tu khoang hoc luc");
                        break;
                    case 5:
                        ds.yeucau5();
                        Console.WriteLine("5.Tim kiem hoc vien tu ma so va cap nhap thong tin");
                        break;
                    case 6:
                        ds.yeucau6();
                        ds.Xuat();
                        Console.WriteLine("6.Sap xep hoc vien theo diem");
                        break;
                    case 7:
                        ds.yeucau7();
                        Console.WriteLine("7.Xuat 5 hoc vien co diem cao nhat");
                        break;
                    case 8:
                        ds.yeucau8();
                        Console.WriteLine("8.Tinh diem trung binh cua lop");
                        break;
                    case 9:
                        ds.yeucau9();
                        Console.WriteLine("9.Xuat danh sach hoc vien co diem trung cua lop");
                        break;
                    case 10:
                        ds.yeucau10();
                        Console.WriteLine("10.Tong hop cac hoc vien theo hoc luc");
                        break;
                    default:
                        Console.WriteLine("Chon tu 0--> 10\n"); break;
                }
            }
            while (chon != 0);

            Console.ReadKey();

        }
   }

    
}
