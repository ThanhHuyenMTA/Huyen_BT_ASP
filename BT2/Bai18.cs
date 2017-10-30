using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai18
    {
        //Bai tap cau truc lap 

        public int Tong1(int N)
        {
            int Tong = 0;
            for (int i = 1; i <= N; i++)
            {
                Tong += i;
            }
                return Tong;
        }

        public float Tong2(int N)
        {
            float Tong = 0;
            for(int i=1;i<=N;i++)
            {
                Tong += 1 / i;
            }
            return Tong;
        }

        public int Tong3(int N)
        {
            int Tong =1;
            for (int i = 2; i <= N; i++)
            {
                Tong += i * 10 + i;
            }
            return Tong;
        }

        public int Tich4(int N)
        {
            int Tich = 1;
            for (int i = 2; i <= N; i++)
            {
                Tich=Tich* i;
            }
            return Tich;
        }
        /// <summary>
        /// Note: rut gon time chay vong for
        /// </summary>
        /// <param name="N"></param>
        /// <returns></returns>
        public float Tong5(int N)
        {
            int Tong = 1;
            for (int i = 2; i <= N; Tong += 1 / Tich4(i)) ;
                 return Tong;
        }
       
        public float Tong6(int N)
        {
            float Tong = 0;
            for (int i = 1; i <= N; i++)
            {
                Tong += 1 / (i * (i + 1));
            }
            return Tong;
        }
    }
}
