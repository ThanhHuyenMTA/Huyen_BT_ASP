using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai19
    {
        Bai18 bai18 = new Bai18();

        public float S2(float A)
        {
            float Tong = 1;
            int i=2;
            while(A<1/i)
            {
                Tong+=1/i;
                i += 1; ;
            }
            return Tong;
        }
        public float S5(float A)
        {
            float Tong = 1;
            int i = 2;
            while(A<1/i)
            {
                Tong +=1/ bai18.Tich4(i);
                i += 1;
            }
            return Tong;
        }
        public float S6(float A)
        {
            float Tong = 0;
            int i = 1;
            while (A < 1 / i)
            {
                Tong += 1 / (i * (i + 1));
                i += 1;
            }
            return Tong;
        }
    }
    
}
