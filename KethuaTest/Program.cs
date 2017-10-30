using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethuaTest
{
    class Program
    {
        static void Main(string[] args)
        {
            SinhVienCNTT[] dssv = new SinhVienCNTT[2];
            Console.WriteLine("Nhap danh sach sinh vien: ");
            for (int i = 0; i < 2; i++)
            {
                dssv[i] = new SinhVienCNTT();
            }
            Console.WriteLine("Danh sach sinh vien: ");
            for (int i = 0; i <2; i++)
            {
                dssv[i].viewSVCNTT();
            }
            //dua ra sinh vien co tong diem>10
            Console.WriteLine("Danh sach sinh vien co tong diem tren 10 : ");
            var DSSV10 = dssv.Where(s => s.Tongdiem1 > 10);
            if (DSSV10 == null || DSSV10.Count() <= 0)
                Console.WriteLine("\tKhong tim thay ket qua");
            else
            {
                foreach (var svt in DSSV10)
                {
                    svt.viewSVCNTT();
                }
            }
            //dua ra sinh vien co tong diem <5
            Console.WriteLine("Danh sach sinh vien co tong diem duoi 5: ");
            var DSSV5 = dssv.Where(s => s.Tongdiem1 < 5);
            if (DSSV5 == null || DSSV5.Count() <= 0)
                Console.WriteLine("\tKhong tim thay ket qua");
            else
            {
                foreach (var svt in DSSV5)
                {
                    svt.viewSVCNTT();
                }
            }
            Console.ReadLine();
        }
    }
}
