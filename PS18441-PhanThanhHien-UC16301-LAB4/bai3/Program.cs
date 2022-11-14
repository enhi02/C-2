using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai3
{
    class Program
    {
        static void Main(string[] args)
        {
            ////a
            //List<student> studentsList = new List<student>()
            //{
            //    new student() {studentID = 1, studentName = "John", age = 13},
            //    new student() {studentID = 2, studentName = "John", age = 21},
            //    new student() {studentID = 3, studentName = "John", age = 18},
            //    new student() {studentID = 4, studentName = "John", age = 20},
            //    new student() {studentID = 5, studentName = "John", age = 15},
            //};
            //var thongtinsv = from sinhvien in studentsList
            //                 where sinhvien.age > 12 && sinhvien.age < 20
            //                 select sinhvien;
            //Console.WriteLine("Thông tin sinh viên");

            //foreach (student std in thongtinsv)
            //{
            //    Console.WriteLine("studentID : " + std.studentID + ";" + "studentName : " + std.studentName + ";" + "age : " + std.age);
            //}
            //Console.ReadKey();

            //b
            List<student> studentsList = new List<student>()
            {
                new student() {studentID = 1, studentName = "John", age = 13},
                new student() {studentID = 2, studentName = "John", age = 21},
                new student() {studentID = 3, studentName = "John", age = 18},
                new student() {studentID = 4, studentName = "John", age = 20},
                new student() {studentID = 5, studentName = "John", age = 15},
            };
            var thongtinsv = studentsList.Where(sinhvien => sinhvien.age > 12 && sinhvien.age < 20);

            Console.WriteLine("Tên age students : ");

            foreach (student std in thongtinsv)
            {
                Console.WriteLine("studentID : " + std.studentID + ";" + "studentName : " + std.studentName + ";" + "age : " + std.age);
            }
            Console.ReadKey();
        }
    }
}
