using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    public class Program
    {
        static void Main(string[] args)
        {
         //   TestGiaiThua test = new TestGiaiThua();
            // test.Ketqua();
        //    Bai18 bai18 = new Bai18();m
          //  Bai19 bai19 = new Bai19();

            /// <summary>
            /// Kiem tra so nguyen to
            /// </summary>
            /// <param name="N"></param>
            /// <returns> So nguyen to YES/NO </returns>

            /*
            DateTime starttime = DateTime.Now;
            Bai20 bai20 = new Bai20();
            int n = Int32.Parse(Console.ReadLine());
            if (bai20.ktraSNT(n))
                Console.WriteLine("YES");
            else Console.WriteLine("NO");
            DateTime endTime = DateTime.Now;
            Console.WriteLine("\n Process.time 1: " + endTime.Subtract(starttime).TotalMilliseconds);
             */



            /// <summary>
            /// So nguyen n
            /// </summary>
            /// <param name="N"></param>
            /// <returns>he nhi phan,he thap luc phan </returns>

            /*
            Bai21 bai21 = new Bai21();
            Console.Write("Nhap gia tri n= ");
            int n21 = Int32.Parse(Console.ReadLine());
            // he nhi phan
            Console.Write("Gia tri nhi phan: ");
            bai21.Nhiphan(n21);
            //thap luc phan: 0123456789ABCDEF
            Console.Write("\nGia tri thap luc phan: ");
            bai21.Thaplucphan(n21);
             */

            /// <summary>
            /// So nguyen n,k
            /// </summary>
            /// <param name="N"></param>
            /// <returns>chinh hop, to hop </returns>
            
           /* Bai22 bai22 = new Bai22();
            Console.Write("Nhap gia tri n= ");
            int n22 = Int32.Parse(Console.ReadLine());
            Console.Write("Nhap gia tri k= ");
            int k22 = Int32.Parse(Console.ReadLine());
            bai22.Chinhhop(n22, k22);
            bai22.Tohop(n22, k22);
            */


            /// <summary>
            /// So nguyen n
            /// </summary>
            /// <param name="N"></param>
            /// <returns>n so nguyen to dau tien</returns>
            
             Bai24 bai24 = new Bai24(); 
             bai24.SoNt(1);
             bai24.SoNt(3);
             bai24.SoNt(5);
             bai24.SoNt(10);
             bai24.SoNt(15);
            

           /*
            Bai25 bai25 = new Bai25();
            Console.Write("Nhap chuoi S: ");
            string S = Console.ReadLine();
            bai25.RunString(S);
            */ 









            Console.ReadLine();
        }
    }
}
