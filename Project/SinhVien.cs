using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    public class SinhVien
    {
        
        public string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string tenLop;

        public string TenLop
        {
            get { return tenLop; }
            set { tenLop = value; }
        }

        public DateTime ngaysinh;

        public DateTime Ngaysinh
        {
            get { return ngaysinh; }
            set { ngaysinh = value; }
        }
        public string quequan;

        public string Quequan
        {
            get { return quequan; }
            set { quequan = value; }
        }
        //truong phu thuoc khong can set (phu thuoc vao truong khac)

        public int tuoi;
        public int Tuoi
        {
            get { return DateTime.Now.Year - ngaysinh.Year; }
           
        }
        //khoi tao kh tham so
        public SinhVien()
        {
            InputSv();
        }
        //khoi tao co tham so
        public SinhVien(string name, DateTime ns, string quequan)
        {
            this.name = name;
          
            this.ngaysinh = ns;
            this.quequan = quequan;
      

        }
        public SinhVien(string name,string tenlop,DateTime ns,string quequan,int tuoi)
        {
            this.name = name;
            this.tenLop = tenlop;
            this.ngaysinh = ns;
            this.quequan = quequan;
            this.tuoi = tuoi;

        }
        public void InputSv()
        {
            NhapName:
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
                goto NhapName;

            NhapLop:
            Console.Write("Nhap lop: ");
            tenLop = Console.ReadLine();
            if (string.IsNullOrEmpty(tenLop))
                goto NhapLop;

            NhapNS:
            Console.Write("Nhap ngay sinh: ");
            //ngaysinh = DateTime.Parse(Console.ReadLine());
            DateTime _ngaysinh = DateTime.Now;
            if(DateTime.TryParseExact(Console.ReadLine(),"dd/MM/yyyy",null,
                System.Globalization.DateTimeStyles.None,out _ngaysinh))
                ngaysinh=_ngaysinh;
            else
            {
                goto NhapNS;
            }
           
            NhapQQ:
            Console.Write("Nhap que quan: ");
            quequan = Console.ReadLine();
            if (string.IsNullOrEmpty(quequan))
                goto NhapQQ;
        }
        public void Output()
        {
            Console.WriteLine("\t{0} ;Lop {1} ; {2} ;{3} tuoi ; {4} ", name,tenLop, ngaysinh,Tuoi, quequan);
        }
    }
}
