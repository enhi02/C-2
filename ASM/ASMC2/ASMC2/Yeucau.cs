using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMC2
{
    class Yeucau
    {
        private string _connection;
        private bool isNum;
        private int classId_;
        private int classId_select;
        private object c;
        private bool isSimilar;

        public Yeucau(string connection)
        {
            _connection = connection;
        }
        ~Yeucau()
        {
            _connection = null;
        }

        /// <summary>
        /// Nhập mới lớp học
        /// </summary>
        public void Yeucau01()
        {
            Console.Clear();

            bool flagTieptuc = false;
            string kytu = "";
            string nameClass;

            var lophoc = new Lophoc(_connection);

            do
            {
                flagTieptuc = false;

                Console.Write("\n\tTên lớp: ");
                nameClass = Console.ReadLine();

                if (nameClass != "")
                {
                    lophoc.InsertLophoc(nameClass);
                }
                Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");

                kytu = Console.ReadLine();
                if (kytu == "Y" || kytu == "y")
                {
                    flagTieptuc = true;
                }
                else
                {
                    Console.Write("\n\tThoát chức năng.");
                }

            } while (flagTieptuc);
        }


        /// <summary>
        /// Sửa lớp học
        /// </summary>
        /// 

        //public void Yeucau02()
        //{
        //    Console.Clear();

        //    bool flagTieptuc = false;
        //    string kytu = "";
        //    string nameClass;
        //    int idClass;
        //    var lophoc = new Lophoc(_connection);
        //    do
        //    {
        //        flagTieptuc = false;

        //        Console.Write("\n\tMã lớp: ");
        //        idClass = int.Parse(Console.ReadLine());
        //        Console.Write("\n\tTên lớp: ");
        //        nameClass = Console.ReadLine();
        //        if (nameClass != "")
        //        {
        //            lophoc.UpdateLophoc(idClass, nameClass);
        //        }

        //        Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");
        //        kytu = Console.ReadLine();
        //        if (kytu == "Y" || kytu == "y")
        //        {
        //            flagTieptuc = true;
        //        }
        //        else
        //        {
        //            Console.Write("\n\tThoát chức năng.");
        //        }
        //    } while (flagTieptuc);
        //}

        /// <summary>
        /// In danh sách lớp học
        /// </summary>
        //    public void Yeucau02()
        //    {
        //        Console.Clear();
        //        string name;
        //        double diem;
        //        string email;
        //        int idclass;


        //        bool flagTieptuc = false;
        //        string kytu = "";
        //        string nameClass;

        //        var lophoc = new Lophoc(_connection);

        //        do
        //        {
        //            flagTieptuc = false;

        //            Console.Write("\n\tTên sinh viên: ");
        //            name = Console.ReadLine();
        //            Console.Write("\n\tTên  điêm sinh viên : ");
        //            diem =Convert.ToDouble( Console.ReadLine());
        //            Console.Write("\n\tTên email : ");
        //            email = Console.ReadLine();
        //            Console.Write("\n\tTên idclass : ");
        //            idclass = Convert.ToInt32(Console.ReadLine());

        //            if (name != "")
        //            {
        //                lophoc.InsertLophoc(name);
        //            }
        //            Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");

        //            kytu = Console.ReadLine();
        //            if (kytu == "Y" || kytu == "y")
        //            {
        //                flagTieptuc = true;
        //            }
        //            else
        //            {
        //                Console.Write("\n\tThoát chức năng.");
        //            }

        //        } while (flagTieptuc);
        //    }
        //}
        public void Yeucau2()
        {
            var sinhvien = new Sinhvien(_connection);
            string name;
            string email;
            int mark;
            int idClass;
            bool flagTieptuc = false;
            string kytu = "";
            do
            {
                flagTieptuc = false;

                Console.Write("\tTên sinh sv: ");
                name = Console.ReadLine();
                Console.Write("\tĐiểm sv: ");
                mark = int.Parse(Console.ReadLine());
                Console.Write("\temail sv: ");
                email = Console.ReadLine();
                Console.Write("idclass: ");
                idClass = int.Parse(Console.ReadLine());

                if (name != " ")
                {
                    sinhvien.InsertSinhvien(name, mark, email, idClass);
                }
                Console.Write("\n\tNhập Y để tiếp tục (ký tự khác để thoát): ");

                kytu = Console.ReadLine();
                if (kytu == "Y" || kytu == "y")
                {
                    flagTieptuc = true;
                }
                else
                {
                    Console.Write("\n\tThoát chức năng.");
                }

            } while (flagTieptuc);
        }

        public void Yeucau03()
        {
            Console.Clear();
            var sinhvien = new Sinhvien(_connection);
            var list = sinhvien.GetListsinhvien();
            InDanhSach(list, "In danh sách sinh viên");
            Console.ReadLine();
        }
        public void Yeucau04()
        {
            Console.Clear();

            bool flagTieptuc = false;
            string kytu = "";
            int fromMark, toMark;

            do
            {
               
                flagTieptuc = false;
                var sinhvien = new Sinhvien(_connection);
                List<Student> list = sinhvien.GetListsinhvien();
                Console.WriteLine("\n\t Nhập điểm [từ_điểm] -> [đến_điểm] để in danh sách");
                Console.WriteLine("\n\t Nhập điểm [từ_điểm] :");
                fromMark = int.Parse(Console.ReadLine());

                Console.WriteLine("\n\t Nhập điểm [đến_điểm] :");
                toMark = int.Parse(Console.ReadLine());


                //list = list.FindAll(x => x.Mark >= fromMark && x.Mark <= toMark);
                var timtheodiem = from timdiem in list
                                  where timdiem.Mark > fromMark && timdiem.Mark < toMark
                                  select timdiem;
                foreach (var item in timtheodiem){
                    string hocluc = Hocluc((int)item.Mark);
                    Console.Write("\n\t " + item.StId + "\t" + item.Name + "\t\t" + item.Mark + "\t" + hocluc);
                        
                }
                    

                              Console.WriteLine("\n\t Nhập 'Y' or 'y' để tiếp tục (ký tự khác để thoát):");
                kytu = Console.ReadLine();

                if (kytu == "y" || kytu == "Y")
                {
                    flagTieptuc = true;
                }
                else
                {
                    Console.WriteLine("\n\t Thoát Chức Năng .Good bye");
                }
            } while (flagTieptuc);
        }
        public void Yeucau05()
        {
            Console.Clear();
            var sinhvien = new Sinhvien(_connection);
            List<Student> list = sinhvien.GetListsinhvien();
            bool flagTieptuc = false;
            string kytu = "";
            string name, email;
            int mark, idClass;
            int idStd;
            var Sinhvien = new Sinhvien(_connection);
            do
            {
                flagTieptuc = false;

                Console.Write("\n\t Mã Sinh Viên  :");
                idStd = int.Parse(Console.ReadLine());
                var timtheoid = from timid in list
                                where timid.StId == idStd
                                select timid;

                foreach (var item in timtheoid)
                {
                    string hocluc = Hocluc((int)item.Mark);
                    Console.Write("\n\t " + item.StId + "\t" + item.Name + "\t\t" + item.Mark + "\t" + hocluc);

                }
                Console.Write("\n\t Tên Sinh Viên :");
                name = Console.ReadLine();

                Console.Write("\n\t Điểm  :");
                mark = int.Parse(Console.ReadLine());

                Console.Write("\n\t Email  :");
                email = Console.ReadLine();


                Console.Write("\n\t Mã số lớp  :");
                idClass = int.Parse(Console.ReadLine());
                sinhvien.UpdateLophoc(idStd, name, mark, email,idClass);

                //if (name != "")
                //{
                //    Sinhvien.InsertSinhvien(name, mark, email, idClass);

                //}
                //Console.WriteLine("\n\t Nhập 'Y' or 'y' để tiếp tục (ký tự khác để thoát):");
                //kytu = Console.ReadLine();

                //if (kytu == "y" || kytu == "Y")
                //{
                //    flagTieptuc = true;
                //}
                //else
                //{
                //    Console.WriteLine("\n\t Thoát Chức Năng .Good bye");
                //}
            } while (flagTieptuc);
        }
        public void Yeucau06()
        {
            Console.Clear();
            var sinhvien = new Sinhvien(_connection);
            List<Student> list = sinhvien.GetListsinhvien();
            list = list.OrderBy(x => x.Mark).ToList();
            InDanhSach(list, "In danh sách sinh viên theo điểm");
            Console.ReadLine();
        }
        public void Yeucau07()
        {
            Console.Clear();
            var sinhvien = new Sinhvien(_connection);
            List<Student> list = sinhvien.GetListsinhvien();
            list = list.OrderByDescending(x => x.Mark).ThenBy(x => x.Name).Take(5).ToList();
            InDanhSach(list, "In 5 sinh viên Có điểm lớn nhất");
            Console.ReadLine();
        }
 
        public void Yeucau08()
        {
           string fpath = @"D:\csharp\DSDTB.text";
            if (File.Exists(fpath))
            {
                File.Delete(fpath);
            }


            using (var db = new ASMDBDataContext(_connection))
            {
                var listStudent = db.Students;
                var listClass = db.Classes;

                var groupJoin = listClass.GroupJoin(listStudent,
                                                    std => std.IdClass,
                                                    cls => cls.IdClass,
                                                    (std, studentgroup) => new 
                                                    {
                                                        Students = studentgroup,
                                                        ClassName = std.NameClass,
                                                    });
                foreach(var item in groupJoin)
                {

                    double sum = 0;
                    int dem = 0;
                    double diemtb = 0;
                    foreach(var stu in item.Students)
                    {
                        sum += stu.Mark;
                        dem++;
                    }
                    diemtb = sum / dem;
                    if(item.Students.Count() != 0) 
                    {
                        using (TextWriter wr = File.AppendText(fpath))
                        {
                            wr.WriteLine($"\tLớp {item.ClassName} có điểm trung bình là:{diemtb}\n");
                        }
                    }
                }
            }
        }

        private void InDanhSach(List<Student> list, string tieude)
        {
            Console.Write("\n\t " + tieude);

            Console.WriteLine("\n\t Mã Số :" + "\t Tên :" + "\t\t Điểm :" + "\t Học Lực");
            foreach (var item in list)
            {
                string hocluc = Hocluc((int)item.Mark);
                Console.Write("\n\t " + item.StId + "\t" + item.Name + "\t\t" + item.Mark + "\t" + hocluc);
            }
            Console.WriteLine();
        }
        private string Hocluc(int mark)
        {
            string hocluc = "";
            if (mark < 3) hocluc = "Kém";
            if (3 <= mark && mark < 5) hocluc = "Yếu";
            if (5 <= mark && mark < 6.5) hocluc = "Trung Bình";
            if (6.5 <= mark && mark < 7.5) hocluc = "Khá";
            if (7.5 <= mark && mark < 9) hocluc = "Giỏi";
            else hocluc = "Xuất Sắc";
            return hocluc;

        }
    }
}

