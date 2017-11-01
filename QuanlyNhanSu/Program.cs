using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNhanSu
{
    class Program
    {
        static void Main(string[] args)
        {
            DanhSachNV dsnvsx = new DanhSachNV();
            Console.WriteLine("Nhap danh sach NV: ");
            dsnvsx.Input();
            dsnvsx.Output();
            Console.ReadLine();
        }
    }
}
