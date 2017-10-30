using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BT2
{
    class Bai25
    {
        /// <summary>
        /// chuoi chay ngang tren man hinh
        /// </summary>
        /// <param name="s"></param>
        public void RunString(string S)
        {
            int l = (int)S.Length;
            for (int i = 0; i <= Console.WindowWidth; i++)
            {
                Console.SetCursorPosition(i, 10);
                Console.WriteLine("{0}", S);
                Thread.Sleep(50);
                Console.Clear();
                if (Console.KeyAvailable == true)
                {
                    ConsoleKeyInfo k;
                    k = Console.ReadKey(); 
                    if (k.Key == ConsoleKey.Escape)
                        return;
                }
                if (i == Console.WindowWidth - l)
                {
                    for (int j = Console.WindowWidth - l; j >= 0; j--)
                    {
                        Console.SetCursorPosition(j, 10);
                        Console.WriteLine("{0}", S);
                        Thread.Sleep(50);
                        Console.Clear();
                        if (j == 0)
                             i = 0;
                        if (Console.KeyAvailable == true)
                        {
                            ConsoleKeyInfo k;
                            k = Console.ReadKey();
                            if (k.Key == ConsoleKey.Escape)
                                return;
                        }
                    }
                }

            }
        }
    }
}
