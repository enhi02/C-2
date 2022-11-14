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
            IList<Student> studentList = new List<Student>()
            {
            new Student() { StudentID=1 , StudenName = "John" , StandardID=1},
            new Student() { StudentID=2 , StudenName = "Moin" , StandardID=1},
            new Student() { StudentID=3 , StudenName = "Bill" , StandardID=2},
            new Student() { StudentID=4 , StudenName = "Ram" , StandardID=2},
            new Student() { StudentID=5 , StudenName = "Ron" },
            };
                        IList<Standard> StandardList = new List<Standard>()
            {
            new Standard() { StandardID = 1,    StandardName = "Standard 1"  },
            new Standard() { StandardID = 2 ,   StandardName = "Standard 2" },
            new Standard() { StandardID = 3,    StandardName = "Standard 3" ,},
            };
            var innerjoin = studentList.Join(
            StandardList,
            Student => Student.StandardID,
            Standard => Standard.StandardID,
            (Student, Standard) => new
            {
                StudentName = Student.StudenName,
                StandardName = Standard.StandardName
            });
            Console.WriteLine("--------------------------2A-----------------------\n");
            foreach (var item in innerjoin)
            {
                Console.WriteLine($" StudentName : " + item.StudentName + "  StandardName : " + item.StandardName);
            }
            Console.WriteLine("----------------------------2B----------------------\n");

            var groupJoin = StandardList.GroupJoin(studentList,  //Trình tự
            std => std.StandardID,         //outerKeySelector
            s => s.StandardID,          //innerKeySelector
            (std, studentsGroup) => new // resultSelector
{
                Students = studentsGroup,
                StandarFulldName = std.StandardName
            });

            foreach (var item in groupJoin)
            {
                Console.WriteLine(item.StandarFulldName);

                foreach (var stud in item.Students)
                    Console.WriteLine(stud.StudenName);
            }

            Console.ReadKey();
        }
    }
}
