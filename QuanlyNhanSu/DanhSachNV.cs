using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace QuanlyNhanSu
{
    class DanhSachNV 
    {


        NVSanXuat[] nvsx ;
        NVCongNghe[] nvcn ;
        NVQuanly[] nvql;
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
            nvsx = new NVSanXuat[numberNV];
            nvcn = new NVCongNghe[numberNV];
            nvql = new NVQuanly[numberNV];
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
            int k = 1;
            for(int i=0;i<numberNV;i+=3)
            {
                Console.Write("\t({0}): ", k);
                nvsx[i].Output();
                k++;
            }
                    
            for (int i = 1; i < numberNV; i += 3)
            {
                Console.Write("\t({0}): ", k);
                nvcn[i].Output();
                k++;
               
            }
                   
            for (int i = 2; i < numberNV; i += 3)
            {
                Console.Write("\t({0}): ", k);
                nvql[i].Output();
                k++;
            }
                   
        }
    }
}
