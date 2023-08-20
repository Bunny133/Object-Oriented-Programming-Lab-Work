using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    abstract class BankAccounts
    {
        protected int AccountNumber;
        protected string AccountHName;
        protected int Initialbalance;
        private string AccType;
        public static  List<BankAccounts> bankAccounts = new List<BankAccounts>();

        public string AccType1 { get => AccType; set => AccType = value; }

        public BankAccounts()
        {

        }
        public BankAccounts(int AccountNumber, string AccountHName, int InitialBalance,string Acctype)
        {
            this.AccountNumber = AccountNumber;
            this.AccountHName = AccountHName;
            this.Initialbalance = InitialBalance;
            this.AccType1 = Acctype;
        }
       

        public abstract double DepositMoney(double amount);
        public abstract double WithdrawMoney(double amount);


        public virtual void DisplayACcDetails()
        {
            foreach (BankAccounts bank in bankAccounts)
            {
                Console.WriteLine($"Your name is:{bank.AccountHName}");
                Console.WriteLine($"Your Acc number is:{bank.AccountNumber}");
                Console.WriteLine($"Your Initial balance is:{bank.Initialbalance}");
            }
        }

    }
}
