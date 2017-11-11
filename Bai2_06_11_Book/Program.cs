using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11_Book
{
    class Program
    {
        static void Main(string[] args)
        {
            int number=0;
            Novel novel = new Novel(number);
            novel.Input();
            novel.Display();
            Console.ReadLine();
        }
    }
}
