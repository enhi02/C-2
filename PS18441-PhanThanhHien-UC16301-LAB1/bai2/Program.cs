using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    class student
    {
        string StudentName;
        string Course;
       
        public void setstudentDetails(string student, string cou)
        {
            StudentName = student;
            Course = cou;
           
        }
        public void displaystudentdetails()
        {
            Console.WriteLine(StudentName + "/" + Course );
        }
        public static string CollegeName = "FPT Polytecnic";
        public static string CollegeAddress = "391 Nam Kì Khởi Nghĩa, Phường 8, Quận 3,Hồ Chí Minh";
        public static void Display()
        {
            Console.WriteLine(CollegeName);
            Console.WriteLine(CollegeAddress);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            student.Display();
            Console.WriteLine();
            student s1 = new student();
            student s2 = new student();
            s1.setstudentDetails("thepv", "phd");
            s2.setstudentDetails("Nghiem", "MBA");
            s1.displaystudentdetails();
            s2.displaystudentdetails();
            Console.Read();
        }
    }
}
