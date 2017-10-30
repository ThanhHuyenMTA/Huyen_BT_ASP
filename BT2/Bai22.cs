using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai22
    {
        public int giaithua(int n)
        {
            int GT = 1;
            for (int i = 1; i < n; GT *= (++i)) ;
            return GT;
        }
        // A=n!/(n-k)!
        public void Chinhhop(int n, int k)
        {
            float kq = giaithua(n) / giaithua(n - k);
            Console.WriteLine("Ket qua chinh hop: {0} ", kq);
        }
        // C=n!/( k! * (n-k)!)
        public void Tohop(int n, int k)
        {
            float kq = giaithua(n) /(giaithua(k)*giaithua(n - k));
            Console.WriteLine("Ket qua to hop: {0} ", kq);
        }
    }
}
