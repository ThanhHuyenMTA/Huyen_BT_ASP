using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project
{
    class Function
    {
       
        public void Cungtuoi(SinhVien A,SinhVien B)
        {
            if (A.Tuoi == B.Tuoi)
                Console.WriteLine("Sinh vien cung tuoi");
            else
                Console.WriteLine("Sinh vien khac tuoi nhau");
        }
        public void Timkiem(string key, SinhVien[] sv,int n)
        {
            int i=0;
           // StringBuilder timkiem= new StringBuilder();
            while(i<n)
            {
                if ((sv[i].Name).Contains(key))
                    sv[i].Output();
                if(key==sv[i].Quequan)
                    sv[i].Output();
                i++;
            }
            
        }
        //viet theo dang landa
        public void Timkiem2(string key, SinhVien[] sv)
        {
            var DSTimkiem = sv.Where(s => s.Name == key);
            if (DSTimkiem == null || DSTimkiem.Count() <= 0)
                Console.WriteLine("Khong tim thay ket qua");
            else
            {
                foreach(var svt in DSTimkiem)
                {
                    svt.Output();
                }
            }


        }
        //viet theo LinQ
        public void Timkiem3(string key, SinhVien[] dssv)
        {
            var DSSv = from sv in dssv
                       where sv.Name == key
                       select sv;
            if (DSSv == null || DSSv.Count() <= 0)
                Console.WriteLine("Khong tim thay ket qua");
            else
            {
                foreach (var sv in DSSv)
                {
                    sv.Output();
                }
            }


        }
    }
}
