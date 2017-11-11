using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    class SavingAccount :abstractAccount
    {
       
        ///-	MinBalance: kiểu float khởi tạo số tiền ban đầu của tài khoản.
        ///-	_bankCharge: kiểu float để lưu trữ phí giao dịch của 1 lần giao dịch.
        private float minBalance;

        public float MinBalance
        {
            get { return minBalance; }
            set { minBalance = value; }
        }
        private float bankCharge;

        public float BankCharge1
        {
            get { return bankCharge; }
            set { bankCharge = value; }
        }
        public SavingAccount() 
        { 
            Input();
        }
        
        public override void SetDetail(string name, long number)
        {
            base.SetDetail(name, number);
            minBalance = 500;
        }
        public override void Deposit(double moneyG)
        {
           base.Deposit(moneyG);
        }
        public override void WithDraw(double moneyR)
        {
             base.WithDraw(moneyR);
        }
        public override double BankCharge()
        {
            return bankCharge;
        }
        public override void Display()
        {
            Console.WriteLine("\tSo du toi thieu trong tai khoan la: {0}$",minBalance);
            base.Display();
        }
        public void Input()
        {
            Console.WriteLine("Nhap thong tin khach hang: ");
            Console.Write("Nhap so tai khoan: "); AccNumber = long.Parse(Console.ReadLine());
            NhapTenKH:
                Console.Write("Nhap ten khach hang: ");
                CustomerName = Console.ReadLine();
                if (string.IsNullOrEmpty(CustomerName))
                    goto NhapTenKH;
            Console.Write("Nhap tien trong tai khoan: "); Banlace = double.Parse(Console.ReadLine());
            Console.Write("Phi giao dich qua 1 lan giao dich la: "); bankCharge = float.Parse(Console.ReadLine());
        }

    }
}
