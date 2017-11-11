using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class Test
    {
        
        public void menu()
        {
            SavingAccount test = new SavingAccount();
            test.SetDetail(test.CustomerName, test.AccNumber);
            Console.WriteLine("Select two function :");
            Console.WriteLine("\t1: WithDraw()");//rut tien
            Console.WriteLine("\t2: Deposit()"); //nap tien
            double bankcharge = 0;//phi giao dich
            int t = 1;
            while(t==1 ||t==2)
            {
                Nhaphinhthuc:
                    {
                        Console.Write("Nhap hinh thuc giao dich: ");
                        t = int.Parse(Console.ReadLine());
                    }
               
                if (t == 1)
                {
                    if (test.Banlace <= test.MinBalance)
                    {
                        Console.WriteLine("\tSo tien ban kh du de thuc hien giao dich nay!\n\tVui long nap them tien vao tai khoan!!!");
                        goto Nhaphinhthuc;
                    }
                    Console.Write("Nhap so tien can rut: ");
                    double tienrut = double.Parse(Console.ReadLine());
                    test.WithDraw(tienrut);
                    test.Display();
                    bankcharge+= test.BankCharge();
                }
                if (t == 2)
                {
                    Console.Write("Nhap so tien can nap: ");
                    double tiennap = double.Parse(Console.ReadLine());
                    test.Deposit(tiennap);
                    test.Display();
                    bankcharge += test.BankCharge();
                }
                if(t!=1 &&t!=2)
                    Console.WriteLine("Phi giao dich la: {0}$", bankcharge);      
            }
            
        }
        
    }
}
