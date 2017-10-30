using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
   public class Bai24
    {
        public static bool testSNT(int n)
        {
            if (n <=1)
                return false;
            if (n == 2)
                return true;
            if (n%2==0)
                return false;
            for(int i=3;i<n;i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
        public void SoNt(int n)
        {
            DateTime starttime = DateTime.Now;
            Console.Write("N so nguyen to dau tien la: ");
            int k = 1;
            if(n>=1)
                Console.Write("2 ");
            int i = 3;
            while(k<n){
                if (testSNT(i)){
                    Console.Write("{0} ", i);
                    k++;
                }
                i+=2;
            }

            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time:  " + endTime.Subtract(starttime).TotalMilliseconds);
            
        }
    }
}
