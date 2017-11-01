using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNhanSu
{
    class NVSanXuat :NhanVien
    {
        private int sosanpham;

        public int Sosanpham
        {
            get { return sosanpham; }
            set { sosanpham = value; }
        }
        public NVSanXuat()
        {          
            Input();      
        }
        public NVSanXuat(string name,string address,DateTime birthday,int sosanpham):base(name,address,birthday)
        {
            this.sosanpham = sosanpham;
        }
        public override void Input()
        {
            base.Input();
            InputSoSP:
                Console.Write("Input sosanpam: ");
                sosanpham = Int32.Parse(Console.ReadLine());
                if (sosanpham < 0)
                    goto InputSoSP;
        }
        public override float Tienluong()
        {
            float Tienluong = sosanpham * 20000;          
            return Tienluong;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("; Tien luong: {0}", String.Format("{0:0,0.## nvđ}", Tienluong()));
             
        }
    }
}
