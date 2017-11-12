using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai2_06_11
{
    class FixedAccount :IACount
    {
        //-	_accountHolder có kiểu là string dùng để lưu trữ tên của chủ tài khoản.
        //-	_accountNumber kiểu long dùng để lưu trữ số tài khoản.
        //-	_interestRate kiểu float dùng để tiền lãi trong tài khoản.
        //-	_numberOfYears kiểu int dùng để số năm gửi tiền trong tài khoản.
        //-	_interestEarned kiểu doble dùng để lưu trữ số tiền lãi kiếm được từ số tiền gửi vào tài khoản.
        //-	_totalBalance kiểu double dùng để lưu trữ số dư trong tài khoản bao gồm cả tiền lãi kiếm dc.
        //-	_deposit kiểu double dùng để lưu số tiền gửi vào trong tài khoản.

        private string accountHolder;

        public string AccountHolder
        {
            get { return accountHolder; }
            set { accountHolder = value; }
        }
        private long accountNumber;

        public long AccountNumber
        {
            get { return accountNumber; }
            set { accountNumber = value; }
        }

        private float interestRate;

        public float InterestRate
        {
            get { return interestRate; }
            set { interestRate = value; }
        }
        private int numberOfYears;

        public int NumberOfYears
        {
            get { return numberOfYears; }
            set { numberOfYears = value; }
        }
        private double interestEarned;

        public double InterestEarned
        {
            get { return interestEarned; }
            set { interestEarned = value; }
        }
        private double totalBalance;

        public double TotalBalance
        {
            get { return totalBalance; }
            set { totalBalance = value; }
        }
        private double deposit;

        public double Deposit
        {
            get { return deposit; }
            set { deposit = value; }
        }
        public void AcceptDetails()
        {
            Nhapten:
            Console.Write("Enter the name of the account holder: ");
            accountHolder = Console.ReadLine();
            if (string.IsNullOrEmpty(accountHolder))
                goto Nhapten;
            NhapsoTK:
            Console.Write("Enter the account number: ");
            accountNumber = long.Parse(Console.ReadLine());
            if (accountNumber <= 0)
                goto NhapsoTK;
            Nhapsotien:
                 Console.Write("Enter the deposit amount: ");
                 deposit = double.Parse(Console.ReadLine());
                 if (deposit <= 0)
                    goto Nhapsotien;
             //Nhapsonamgui:
                 Console.WriteLine("Select the tenure for the deposit amount is: ");
                 Console.WriteLine("A: 1 year\nB: 2 years\nC: 3 years");
                 Console.Write("Choose your option <A-C>: ");
                 string a = Console.ReadLine();
                 if(a=="A" ||a=="a")
                 {
                     numberOfYears = 1;
                 }
                 if (a == "B" || a == "b")
                 {
                     numberOfYears = 3;
                 }
                 if (a == "C" || a == "C")
                 {
                     numberOfYears = 5;
                 }
        }
        public double CalculateInterest()
        {
            if (deposit <= 50000)
            {
                if (numberOfYears == 1)
                {
                   interestRate=3.5f; //kieu float phai dat f or F sau so
                }
                else if (numberOfYears == 3)
                {
                    interestRate = 4;
                }
                else
                {
                    interestRate = 4.5f;
                }
            }
            else if ((deposit > 50000) && (deposit <= 200000))
            {
                if (numberOfYears == 1)
                {
                    interestRate = 5;
                }
                else if (numberOfYears == 3)
                {
                    interestRate = 5.5f;
                }
                else
                {
                    interestRate = 6;
                }
            }
            else
            {
                if (numberOfYears == 1)
                {
                    interestRate = 6.5f;
                }
                else if (numberOfYears == 3)
                {
                    interestRate = 7;
                }
                else
                {
                    interestRate = 7.5f;
                }
            }
            return ((deposit * numberOfYears * interestRate) / 100);

        }
        public double GetBalance()
        {
            interestEarned =CalculateInterest();
            return deposit + interestEarned;

        }
        public  void Display()
        {
            Console.WriteLine("\tAccount Holder: {0}\n\tAccount Number: {1}\n\tAmount Deposited: {2} $\n\tInterest Rate: {3} %\n\tYears of deposit: {4}\n\tInterest Earned: {5} $\n\tMaturity Amount: {6} $",
                accountHolder,accountNumber,deposit,interestRate,numberOfYears,interestEarned,GetBalance()); ;
        }

    }
}
