using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT1
{
    class Bai1
    {
        public void Tuoi()
        {
            string ten = Console.ReadLine();
            string namsinh = Console.ReadLine();
            int ctuoi = Int32.Parse(namsinh);
            int timenow = DateTime.Now.Year;
            int tuoi = timenow - ctuoi;
            Console.WriteLine("Ten: {0}", ten);
            Console.WriteLine("Sinh nam {0}", namsinh);
            Console.WriteLine("Tuoi: {0}", tuoi);
            Console.ReadLine();
        }

        public void Tinhtoan(int x)
        {
            x = Int32.Parse(Console.ReadLine());
            int Y = 3 * x * x + 4 * x - 7;
            Console.WriteLine("Ket qua thu duoc: {0}", Y);
            Console.ReadLine();
        }
        public void Haian(int x, int y)
        {
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());
            double KQ = Math.Pow(4, x) * Math.Pow(2, y) - 2 * x * y + 6 * x * Math.Pow(y, 2) - 13;
            Console.WriteLine("Ket qua thu duoc: {0}", KQ);
            Console.ReadLine();
        }
        public double HDTiendien()
        {
            Console.Write("Nhap name: ");
            string name = Console.ReadLine();
            Console.Write("Nhap chisocu: ");
            int chisocu = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap chisomoi: ");
            int chisomoi = Int32.Parse(Console.ReadLine());
            int tieuthu = chisomoi - chisocu;
            double tiendien = tieuthu * 452.45;
            Console.WriteLine("Hoa don tien dien:");
            Console.WriteLine("Khach hang: {0} \n Chi so cu: {1} \n Chi so cu: {2} \n Tieu thu: {3} \n Tien dien: {4}", name, chisocu, chisomoi, tieuthu, tiendien);
            Console.WriteLine("Can tiet kiem dien");
            return tiendien;
        }
        public void AddHDTiendien()
        {
            double tiendien = HDTiendien();
            double tienthu = tiendien + 12426 + tiendien * 0.1;
            Console.WriteLine("Tien thu cuoi cung: {0}", tienthu);
            Console.ReadLine();
        }
        public void kq1()
        {
            //in ra nhung so chi het cho 3 trong khoang 0-300 nhanh nhat

            DateTime starttime = DateTime.Now;
            int k = 0;
            for (int i = 0; i <= 300; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("{0} ", i);
                    k++;
                }          
            }
            //thuc hien
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time 1: " + endTime.Subtract(starttime).TotalMilliseconds);
            Console.WriteLine(" {0}", k);
        }
        public void kq2()
        {
            DateTime starttime = DateTime.Now;

            int i = 0;
            int kq = 0;
            while (kq < 300)
            {
                kq = i * 3;
                Console.Write("{0} ", kq);
                i = i + 1;
            }
            //thuc hien
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time 2: " + endTime.Subtract(starttime).TotalMilliseconds);
        }
        public void kq3()
        {
            DateTime starttime = DateTime.Now;
           
            int i = 0, k = 0;
            do
            {
                Console.Write("{0} ", i);
                i += 3;
                k++;
            } while (i<=300);
            //thuc hien
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time 3: " + endTime.Subtract(starttime).TotalMilliseconds);
            Console.WriteLine(" {0}", k);
        }
    }
}
