using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanlyNhanSu
{
    class NVCongNghe:NhanVien
    {
        private float songaycong;

        public float Songaycong
        {
            get { return songaycong; }
            set { songaycong = value; }
        }
        public NVCongNghe()
        {          
            Input();      
        }
        public NVCongNghe(string name, string address, DateTime birthday, int songaycong)
            : base(name, address, birthday)
        {
            this.songaycong = songaycong;
        }
        public override void Input()
        {
            base.Input();
            InputSoNC:
                Console.Write("Input songaycong: ");
                songaycong =float.Parse(Console.ReadLine());
                if (songaycong < 0)
                    goto InputSoNC;
        }
        public override float Tienluong()
        {
            float Tienluong = songaycong * 50000;
            return Tienluong;
        }
        public override void Output()
        {
            base.Output();
            Console.WriteLine("; Tien luong: {0}", String.Format("{0:0,0.## vnđ}", Tienluong()));
        }
    }
}
