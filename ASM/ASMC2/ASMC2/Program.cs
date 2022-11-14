using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ASMC2
{
    class Program
    {
        static string connection = @"Server=TUNGTEK-LAM0019\MSSQLSERVER08;Database=Asm_C2;Trusted_Connection=True;";            
        static void Main(string[] args)            
        {            
            Console.OutputEncoding = Encoding.UTF8;
            bool flagTieptuc = false;
            string n;
            int value;
            Yeucau yc = new Yeucau(connection);
            do
            {
                Console.Clear();
                flagTieptuc = false;
                Console.Write("\t\t\t----------------------------------MENU---------------------------------\n" +
                 "\t\t\t|1. nhập dữ liệu                                                       |\n" +
                 "\t\t\t|2. Nhập Sinh Viên                                                     |\n" +
                 "\t\t\t|3. In Danh Sách Sinh viên                                             |\n" +
                 "\t\t\t|4. In Danh Sách Sinh viên theo khoảng điểm		               |\n" +
                 "\t\t\t|5. Tìm và sửa sinh viên theo ID                                       |\n" +
                 "\t\t\t|6. In Danh Sách Sinh viên theo thứ tự điểm	                       |\n" +
                 "\t\t\t|7. In danh sách 5 sinh viên có điểm cao nhất                          |\n" +
                 "\t\t\t|8. Tạo Thread , tính điểm trung bình theo lớp ,in vào tập tin         |\n" +
                 "\t\t\t|0. thoát                                                              |\n" +
                 "\t\t\t------------------------------------------------------------------------\n");

                Console.Write("Nhập lựa chọn: ");
                n = Console.ReadLine();
                while (int.TryParse(n, out value) == false)
                {
                    Console.Write("\n yêu cầu  nhập số : ");
                    n = Console.ReadLine();
                }

                switch (value)
                {
                    case 1: yc.Yeucau01(); break;
                    case 2: yc.Yeucau2(); break;
                    case 3: yc.Yeucau03(); break;
                    case 4: yc.Yeucau04(); break;
                    case 5: yc.Yeucau05(); break;
                    case 6: yc.Yeucau06(); break;
                    case 7: yc.Yeucau07(); break; //
                    case 8: Thread DTB = new Thread(yc.Yeucau08);
                        DTB.IsBackground = true;
                        DTB.Start();
                        Console.WriteLine("\tĐã xuất ra file thành công.");
                        Console.ReadKey();
                        break;
                    case 0:
                    default:
                        Console.WriteLine("\tBạn đã nhập sai chức năng. Vui lòng nhập lại!");
                        break;
                }

                if (value != 0)
                {
                    flagTieptuc = true;
                }
            } while (flagTieptuc);
            Console.ReadLine();
        }

        //private static void ReadKey()
        //{
        //    throw new NotImplementedException();
        //}

        //private static void WriteLine(string v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}

