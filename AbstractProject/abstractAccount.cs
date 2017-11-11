using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractProject
{
    abstract class abstractAccount
    {
        
        
        /// <summary>
        /// -	AccNumber: kiểu long để lưu số tài khoản.
        ///-	CustomerName: kiểu string lưu tên của khách hàng.
        ///-	Banlace: kiểu double lưu giữ số tiền trong tài khoản của 1 khách hàng.
        /// </summary>
        private long accNumber;
        public long AccNumber
        {
            get { return accNumber; }
            set { accNumber = value; }
        }
        private string customerName;

        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        private double banlace;

        public double Banlace
        {
            get { return banlace; }
            set { banlace = value; }
        }

        public abstractAccount() 
        { 

        }
        public abstractAccount(long accNumber, string customerName, double banlace)
        {
            this.accNumber = accNumber;
            this.customerName = customerName;
            this.banlace = banlace;
        }
        //.......
        public virtual void SetDetail(string name,long number)
        {
            customerName = name;
            accNumber = number;
        }
        //rut tien tu tai khoan
        public virtual void WithDraw(double moneyR)
        {
            banlace = banlace - moneyR;
        }
        //gui tien vao tai khoan
        public virtual void Deposit(double moneyG)
        {
             banlace = banlace + moneyG;
        }
        //Hien thi thong tin tai khoan
        public virtual void Display()
        {
            Console.WriteLine("\tSoTk\t\tName\t\tSotien");
            Console.WriteLine("\t{0}\t\t{1}\t\t{2}$",accNumber,customerName,banlace);
        }
        //pt truu tuong de tinh chi phi giao dich
         public abstract double BankCharge();
    }

}
