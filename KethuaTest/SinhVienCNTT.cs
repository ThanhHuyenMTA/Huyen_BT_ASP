using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethuaTest
{
    class SinhVienCNTT:SinhVien
    {
        private float dtoan;

        public float Dtoan
        {
            get { return dtoan; }
            set { dtoan = value; }
        }
        private float dtin;

        public float Dtin
        {
            get { return dtin; }
            set { dtin = value; }
        }
        private float tongdiem;

        public float Tongdiem1
        {
            get { return dtin+dtoan; }
           
        }
      
        public SinhVienCNTT()
        {
            NhapDtoan:
            Console.Write("Nhap diem toan: ");
            dtoan = float.Parse(Console.ReadLine());
            if (dtoan < 0 || dtoan > 10)
                goto NhapDtoan;
            NhapDtin:
            Console.Write("Nhap diem tin: ");
            dtin = float.Parse(Console.ReadLine());
            if (dtoan < 0 || dtoan > 10)
                goto NhapDtin;
        }
        public SinhVienCNTT(int id,string name,float dtoan,float dtin,float tongdiem):base(id,name)
        {
            this.dtoan = dtoan;
            this.dtin = dtin;
            this.tongdiem = tongdiem;
        }
        public void setSVCNTT()
        {
            base.SetSV();
           
        }
        public void viewSVCNTT()
        {
            base.ViewSV();
            Console.WriteLine("; Toan {0} diem; Tin {1} diem; Tongdiem {2} ",dtoan,dtin,Tongdiem1);
        }
       
       
    }
}
