using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11
{
    class Test
    {
        public void menu()
        {
            Console.WriteLine("\t\t\t\t\t\tFIXED ACCOUNT DETAILS");
            string test = "Y";
            while(test=="Y")
            {
                FixedAccount a = new FixedAccount();
                a.AcceptDetails();
                a.CalculateInterest();
                a.GetBalance();
                a.Display();
                Console.Write("Do you wish to continue (Y|N) :");
                test = Console.ReadLine();
            }

        }
    }
}
