using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    class CurrentAccounts : BankAccounts
    {

        private int OverdraftLimit;
        

        public CurrentAccounts()
        {

        }
        //public CurrentAccounts(int AccountNumber, string AccHName, int inBalance,string acctype) : base(AccountNumber, AccHName, inBalance,acctype)
        //{
        //    this.AccountNumber = AccountNumber; ;
        //    this.AccountHName = AccHName;
        //    this.Initialbalance = inBalance;

        //}


        public CurrentAccounts(int AccountNumber, string AccHName, int inBalance,string acctype ,int overdraftlimit) : base(AccountNumber, AccHName, inBalance,acctype)
        {
            this.AccountNumber = AccountNumber; ;
            this.AccountHName = AccHName;
            this.Initialbalance = inBalance;
            this.OverdraftLimit = overdraftlimit;
        }

        public override double DepositMoney(double amount)
        {
            return amount;
        }

        public override double WithdrawMoney(double amount)
        {
            return amount;
        }

        public double OverDraftLimit(double amount)
        {
            if (WithdrawMoney(amount) > Initialbalance) 
            {
                Initialbalance = (int)(WithdrawMoney(amount) - Initialbalance);
                Initialbalance = OverdraftLimit - Initialbalance;
                return Initialbalance;



            }
            else
            {
                return amount;
            }
        }

        public override void DisplayACcDetails()
        {
            base.DisplayACcDetails();
            foreach (CurrentAccounts s in bankAccounts)
            {


                Console.WriteLine($"OverDraft Limit is:{s.OverdraftLimit}");
            }
        }

    }
}
