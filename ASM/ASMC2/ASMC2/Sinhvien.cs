using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMC2
{
    class Sinhvien
    {

        private string _connection;
        public Sinhvien(string connection)
        {
            _connection = connection;
        }

        ~Sinhvien()
        {
            _connection = null;
        }
        
        public void InsertSinhvien(string name, int mark, string email, int idClass)
        {
            using (var db = new ASMDBDataContext(_connection))
            {
                var item = new Student() { Name = name, Mark = mark, Email = email, IdClass = idClass };
                db.Students.InsertOnSubmit(item);
                db.SubmitChanges();
            }
            Console.Write("\tInsert dữ liệu thành công.");
        }

        public void UpdateLophoc(int idSdt, string name, int mark, string email, int idClass)
        {
            using (var db = new ASMDBDataContext(_connection))
            {
                var item = (from p in db.Students
                            where p.StId == idSdt
                            select p).FirstOrDefault();
                item.Name = name;
                item.Mark = mark;
                item.Email = email;
                item.IdClass = idClass;
                db.SubmitChanges();
            }
            Console.Write("\tUpdate dữ liệu thành công.");
        }

        public List<Student> GetListsinhvien()
        {
            List<Student> list = new List<Student>();
            using (var db = new ASMDBDataContext(_connection))
            {
                list = db.Students.ToList();
            }
            return list;
        }
    }
}

