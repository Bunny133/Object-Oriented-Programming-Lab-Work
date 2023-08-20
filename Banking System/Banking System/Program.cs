using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{

    class Program
    {

        static void Main(string[] args)
        {

            BankUi bankUi = new BankUi();
            BankAccounts bank = bankUi.UserInput();
            CurrentAccounts current = new CurrentAccounts();
            SavingAccounts saving = new SavingAccounts();
            
            if (bank.AccType1 == "Current") 
            {
                current.OverDraftLimit(1000);
                current.WithdrawMoney(100);
                current.DepositMoney(100);
                current.DisplayACcDetails();

            }
            else if (bank.AccType1 == "Savings")
            {
               
                saving.WithdrawMoney(100);
                saving.AddinterestRate();
                saving.DepositMoney(100);
                saving.DisplayACcDetails();

            }
            else
            {
                Console.WriteLine("EMty");
            }






        }
    }
}
