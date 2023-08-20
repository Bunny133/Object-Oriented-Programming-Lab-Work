using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
     class SavingAccounts : BankAccounts
    {
        private int InterestRate;

        public SavingAccounts()
        {

        }

        public SavingAccounts(int AccountNumber,string AccHName,int inBalance,string Acctype) : base (AccountNumber,AccHName,inBalance,Acctype) 
        {
            this.AccountNumber = AccountNumber; ;
            this.AccountHName = AccHName;
            this.Initialbalance = inBalance;
            this.AccType1 = Acctype;
        }
        public SavingAccounts(int AccountNumber,string AccHName,int inBalance,string acctype,int interestRate) : base (AccountNumber,AccHName,inBalance,acctype) 
        {
            this.AccountNumber = AccountNumber; ;
            this.AccountHName = AccHName;
            this.Initialbalance = inBalance;
            this.AccType1 = acctype;
            this.InterestRate=interestRate;
        }
       


        public override double DepositMoney(double amount)
        {
            return amount;
        }

        public override double WithdrawMoney(double amount)
        {
            if (amount > 50000 ) 
            {
                amount = amount - 60;
            }
            else
            {
                amount = amount;
            }
            return amount;
        }
        public float AddinterestRate() 
        {
            Initialbalance = Initialbalance + (InterestRate/100);
            return Initialbalance;

        }
        public override void DisplayACcDetails()
        {
            base.DisplayACcDetails();
            foreach (SavingAccounts s in bankAccounts)
            {
                Console.WriteLine($"Your interest Rate is:{s.AddinterestRate()}");
            }
        }






    }
}
