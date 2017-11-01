using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNhanSu
{
    class NVQuanly : NhanVien
    {
        private float hesoluong;

        public float Hesoluong
        {
            get { return hesoluong; }
            set { hesoluong = value; }
        }
        private float luongcoban;

        public float Luongcoban
        {
            get { return luongcoban; }
            set { luongcoban = value; }
        }

        public NVQuanly()
        {
            Input();
        }
        public NVQuanly(string name, string address, DateTime birthday, float hesoluong, float luongcoban)
            : base(name, address, birthday)
        {
            this.hesoluong = hesoluong;
            this.luongcoban = luongcoban;
        }
        public override void Input()
        {
            base.Input();
        InputHesoluong:
            Console.Write("Input hesoluong: ");
            hesoluong=float.Parse(Console.ReadLine());
            if (hesoluong < 0)
                goto InputHesoluong;
        InputLuongcoban:
            Console.Write("Input luongcoban: ");
             luongcoban = float.Parse(Console.ReadLine());
            if (luongcoban < 0)
                goto InputLuongcoban;
        }
        public override float Tienluong()
        {
            float Tienluong = hesoluong * luongcoban;
            return Tienluong;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("; Tien luong: {0}", String.Format("{0:0,0.## vnđ}", Tienluong()));
        }
    }
}
