using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Test1
    {
        /// <summary>
        /// Mot so cach khai bao mang 1 chieu
        /// </summary>
        int[] array0 = new int[10];
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        public void user()
        {
            string[] user = new string[5];
            for (int i = 0; i < 5; i++)
            {
                Console.Write("Nhap name {0}: ", i + 1);
                user[i] = Console.ReadLine();
            }
            Console.Write("Nhap tu tim kiem: ");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
                Console.WriteLine("Khong co ket qua nao");
            else
            {
                StringBuilder timkiembang = new StringBuilder();
                StringBuilder timkiemchua = new StringBuilder();
                //Tim kiem chuoi moi nhap bang dung ten trong mang
                for (int i = 0; i < 5; i++)
                {
                    if (name == user[i])
                        timkiembang.Append(string.Format(" {0} . {1} ;",i+1,user[i]));
                    if (user[i].Contains(name)) //ham kiem tra chuoi con
                            timkiemchua.Append(string.Format(" {0} . {1} ;", i + 1, user[i]));
                  
                }
                //Tim kiem chuoi moi nhap bang mot phan ten trong mang
                Console.WriteLine("Danh sach tim dc: \nTrung \n{0} \nChua \n{1}",timkiembang.ToString(),timkiemchua.ToString());
            }

        }
    }
}
