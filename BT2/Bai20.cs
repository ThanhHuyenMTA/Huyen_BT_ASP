using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai20
    {
        //kiem tra so nguyen to
        //Note: 1 khong phai la so nguyen to
        public bool ktraSNT(int n){
            if (n>1 && n<=3)
                return true;
            if (n == 1)
                return false;
            int i;
            for (i = 2; i < n; i++){
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }

    }
}
