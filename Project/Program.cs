using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {

           //Sinh vien
            DateTime starttime = DateTime.Now;
            SinhVien[] sv = new SinhVien[3];
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Sinh vien {0} ", i + 1);
                sv[i] = new SinhVien();
               
            }
            for (int i = 0; i < 3; i++)
            {              
                sv[i].Output();
            }

            Function function = new Function();
            function.Cungtuoi(sv[0], sv[1]);

            NhapKey:
            Console.Write("Nhap key tim kiem: ");
            string key = Console.ReadLine();
            if (key == null)
            {
                Console.WriteLine("Nhap key tim kiem");
                goto NhapKey;
            }
            else
                //function.Timkiem(key, sv,3);
                function.Timkiem2(key, sv);
                //function.Timkiem3(key, sv);
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time 1: " + endTime.Subtract(starttime).TotalMilliseconds);
          

            // Giao vien

            //GiaoVien[] gv = new GiaoVien[100];
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("Sinh vien {0} ", i + 1);
            //    gv[i] = new GiaoVien();
            //    gv[i].InputSv();
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    gv[i].Output();
            //}

             Console.ReadLine();
        }
    }
}
