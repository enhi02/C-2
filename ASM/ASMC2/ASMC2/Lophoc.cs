using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMC2
{
    class Lophoc
    {
        private string _connection;
        public Lophoc(string connection) { _connection = connection; }
        ~Lophoc()
        {
            _connection = null;
        }
        public void InsertLophoc(string nameClass)
        {
            using (var db = new ASMDBDataContext(_connection))
            {
                var item = new Class() { NameClass = nameClass };
                db.Classes.InsertOnSubmit(item);
                db.SubmitChanges();
            }
            Console.Write("\tInsert dữ liệu thành công.");
        }

        public void UpdateLophoc(int idClass, string nameClass)
        {
            using (var db = new ASMDBDataContext(_connection))
            {
                var item = (from p in db.Classes
                            where p.IdClass == idClass
                            select p).FirstOrDefault();
                item.NameClass = nameClass;
                db.SubmitChanges();
            }
            Console.Write("\tUpdate dữ liệu thành công.");
        }

        public List<Class> GetListLophoc()
        {
            List<Class> list = new List<Class>();
            using (var db = new ASMDBDataContext(_connection))
            {
                list = db.Classes.ToList();
            }
            return list;
        }
    }
}

