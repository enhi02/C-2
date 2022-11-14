using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace menu_Asg_
{
  public class DSHocVien
    {
        private List<HocVien> list = new List<HocVien>();
        public  void Nhap()
        {
            do
            {
                HocVien hv = new HocVien();
                hv.nhap();
                list.Add(hv);
                Console.WriteLine("Ban co muon nhap nua hay khong? (y/n)");
                string chon = Console.ReadLine();
                if (chon == "n" || chon == "N")
                {
                    break;
                }
            } while (true);
        }
        public void Xuat ()
        {
            foreach (HocVien hv in list)
            {
                hv.Xuat();
            }
        }
        public void yeucau3()
        {
            float min, max;
            Console.WriteLine("Nhap Khoang diem nho nhat:  ");
            string st = Console.ReadLine();
            min = float.Parse(st);

            Console.WriteLine("Nhap Khoang diem lon nhat:  ");
                 st = Console.ReadLine();
            max = float.Parse(st);

            Console.WriteLine("Thong tin cac hoc vien nam trong khoang diem :");
            foreach( var item in list)
            {
                if(item.Diem >= min && item.Diem<=max)
                {
                    item.Xuat();
                }
            }
        }
        public void yeucau4()
        {
            Console.WriteLine("Nhap hoc luc can tim :");
            string hocLuc = Console.ReadLine();

            Console.WriteLine("----CAC HOC VIEN CO HOC LUC MA BAN VUA TIM LA ----");
            foreach(var item in list)
            {
                if (hocLuc==item.GetHocLuc())
                    item.Xuat();
            }
        }
        public void yeucau5()
        {
            Console.WriteLine("Nhap diem  can tim:");
            string ma = Console.ReadLine();

            foreach( var item in list)
            {
                if(item.Maso ==ma)
                {
                    item.Xuat();
                    break;
                }
            }
        }
        public void yeucau6()
        {
            list.Sort((a, b) => (int)(a.Diem - b.Diem));
        }
        public void yeucau7()
        {
            list.Sort((a, b) => (int)(a.Diem - b.Diem));
            for(int i=0;i<5 && i< list.Count;i++)
            {
                list[i].Xuat();
            }
        }
        public void yeucau8()
        {            
                double tong = 0;
                int count = 0;
                foreach (HocVien hv in list)
                {
                    tong += hv.Diem;
                    count++;
                }
                float DiemTB = (float)tong / count;
                Console.WriteLine("Diem trung binh Cua hoc vien : " + DiemTB);
            
        }
        public void yeucau9()
        {
            double tong = 0;
            int count = 0;
            foreach (HocVien hv in list)
            {
                tong += hv.Diem;
                count++;
            }
            float DiemTB = (float)tong / count;

            foreach (HocVien hv in list)
            {
                if (hv.Diem >= DiemTB)
                {
                    hv.Xuat();
                }
            }
        }
        public void yeucau10()
        {
            Console.WriteLine("-----HOC VIEN CO HOC LUC XUAT SAC------");
            foreach(HocVien hv in list)
            {
                if(hv.Diem>=9)
                {
                    hv.Xuat();
                }
            }
            Console.WriteLine("-----HOC VIEN CO HOC LUC GIOI------");
            foreach (HocVien hv in list)
            {
                if (hv.Diem >= 7.5)
                {
                    hv.Xuat();
                }
            }
            Console.WriteLine("-----HOC VIEN CO HOC LUC KHA------");
            foreach (HocVien hv in list)
            {
                if (hv.Diem >= 6.5 && hv.Diem < 7.5)
                {
                    hv.Xuat();
                }
            }
            Console.WriteLine("-----HOC VIEN CO HOC LUC TRUNG BINH------");
            foreach (HocVien hv in list)
            {
                if (hv.Diem >= 5 && hv.Diem < 6.5)
                {
                    hv.Xuat();
                }
            }
            Console.WriteLine("-----HOC VIEN CO HOC LUC YEU------");
            foreach (HocVien hv in list)
            {
                if (hv.Diem <5)
                {
                    hv.Xuat();
                }
            }
        }

    }
}
