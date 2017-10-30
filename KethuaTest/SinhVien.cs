using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethuaTest
{
    class SinhVien
    {
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }


        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public SinhVien()
        {
            SetSV();
        }
        public SinhVien(int id,String name)
        {
            this.id = id;
            this.name = name;         
        }
        public void SetSV()
        {
            Console.Write("Nhap masv: ");
            id =int.Parse(Console.ReadLine());
            NhapName:
            Console.Write("Nhap ten: ");
            name = Console.ReadLine();
            if(string.IsNullOrEmpty(name))
                goto NhapName;
        }
        public void ViewSV()
        {
           
            Console.Write("\t{0}: {1}", id, name);
        }
       
    }
}
