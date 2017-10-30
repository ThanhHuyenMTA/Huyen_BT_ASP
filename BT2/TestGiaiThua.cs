using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class TestGiaiThua
    {
        public float  gt(int N)
        {
            float Gt=1;
            if(N>1)
                for (int i = 2; i <= N; Gt *= ++i) ;
            return Gt;
        }
        public void Ketqua()
        {
            Console.WriteLine("GT0: {0}", gt(0));
            Console.WriteLine("\nGT1: {0}", gt(1));
            Console.WriteLine("\nGT5: {0}", gt(5));
            Console.WriteLine("\nGT10: {0}", gt(10));
            Console.WriteLine("\nGT15: {0}", gt(15));
            Console.WriteLine("\nGT20: {0}", gt(20));
            Console.WriteLine("\nGT50: {0}", gt(50));
            Console.ReadLine();
        }
    }
}
