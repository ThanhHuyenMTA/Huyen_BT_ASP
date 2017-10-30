using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang
{
    class Test2
    {
        /// <summary>
        /// Mot so cach khai bao mang da chieu
        /// </summary>
        string[,] names = new string[10, 10];
        string [ , , ] chieu3;
        int [,] a = new int [3,4] {
                 {0, 1, 2, 3} ,   /*  khởi tạo cho hàng bắt đầu với chỉ mục 0 */
                 {4, 5, 6, 7} ,   /*  khởi tạo cho hàng bắt đầu với chỉ mục 1 */
                 {8, 9, 10, 11}   /*  khởi tạo cho hàng bắt đầu với chỉ mục 2 */
         };

        int[,] b = new int[5, 2] { { 0, 0 }, { 1, 2 }, { 2, 4 }, { 3, 6 }, { 4, 8 } };
    }
}
