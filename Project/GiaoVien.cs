using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    //da ke thua can su dung Interface 
    class GiaoVien :SinhVien
    {
        private string DayLop;

        public string DayLop1
        {
            get { return DayLop; }
            set { DayLop = value; }
        }
        public GiaoVien():base()
        {
            Console.Write("Nhap lop day: ");
            DayLop = Console.ReadLine();

        }
        public GiaoVien(string name, DateTime ngaysinh, string quequan, string daylop): base(name,ngaysinh,quequan)
        {
            this.DayLop = daylop;
        }

       

    }
}
