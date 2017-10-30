using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Bai21
    {
       
        // chuyen thanh he nhi phan, he thap luc phan
        public void Nhiphan(int n)
        {
            int[] arr = new int[100];
            int i = 0;

            while(n != 0 && n!=1)
            {

                if (n % 2 == 1)
                    arr[i] = 1;
                if (n % 2 == 0)
                    arr[i] = 0;
                n = n / 2;
                i++;
                if(n<2)
                {
                    arr[i] = n % 2;
                    break;
                }  
               
            } 
            for(int j=i;j>=0;j--)
            {
                Console.Write("{0} ", arr[j]);
            }
        }
        public void tochar(int n)
        {
            switch(n)
            {
                case 10:
                    Console.Write("A");
                    break;
                case 11:
                    Console.Write("B");
                    break;
                case 12:
                    Console.Write("C");
                    break;
                case 13:
                    Console.Write("D");
                    break;
                case 14:
                    Console.Write("E");
                    break;
                case 15:
                    Console.Write("F");
                    break;
                default: break;
            }
        }
        public void Thaplucphan(int n)
        {
            int[] arr = new int[100];
            int k = 0;
            while(n>16)
            {
                arr[k] = n % 16;
                n = n / 16;
                k++;
                if(n<16)
                {
                    arr[k] = n % 16;
                    break;
                }
            }
            for (int j = k; j >= 0; j--)
            {
                if(arr[j]>9)
                     tochar(arr[j]);
                else
                    Console.Write("{0}", arr[j]);
            }
        }
    }
}
