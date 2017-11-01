using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanlyNhanSu
{
    class DanhSachNV 
    {
        DanhSachNV[] dsnv = new DanhSachNV[100];
        NVSanXuat[] nvsx = new NVSanXuat[100];
        NVCongNghe[] nvcn = new NVCongNghe[100];
        NVQuanly[] nvql = new NVQuanly[100];
        private int numberNV;

        public int NumberNV
        {
             get { return numberNV; }
            set { numberNV = value; }
        }
        
        public DanhSachNV()
        {

        }
        public DanhSachNV(int number)
        {           
            this.numberNV = number;
        }
       
        public void Input()
        {
            InputSoNV:
            Console.Write("Input sonhanvien: ");
            numberNV = Int32.Parse(Console.ReadLine());
            if (numberNV < 0)
                goto InputSoNV;
           
            for (int i = 0; i < numberNV; i+=3)
            {
                nvsx[i] = new NVSanXuat();
                if (i+1 >= numberNV)
                    break;
                nvcn[i+1] = new NVCongNghe();
                if (i + 2 >= numberNV)
                    break;
                nvql[i+2] = new NVQuanly();
            }
        }
        public void Output()
        {
            Console.WriteLine("    Danh sach nhan vien: ");
            for(int i=0;i<numberNV;i+=3)       
                    nvsx[i].Output();
            for (int i = 1; i < numberNV; i += 3)  
                    nvcn[i].Output();
            for (int i = 2; i < numberNV; i += 3)  
                    nvql[i].Output();
        }
    }
}
