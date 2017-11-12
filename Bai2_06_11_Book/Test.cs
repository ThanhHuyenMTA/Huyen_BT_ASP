using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11_Book
{
    class Test
    {
        public void Menu()
        {
            int length;
            Console.Write("Nhap do dai cua mang: ");
            length = Int32.Parse(Console.ReadLine());
            Novel novel = new Novel(length);
            novel.Input();
            novel.Display();
        }
    }
}
