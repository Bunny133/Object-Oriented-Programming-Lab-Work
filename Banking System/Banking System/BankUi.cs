using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Banking_System
{
    internal class BankUi
    {
        public BankAccounts UserInput()
        {
            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your Account Type (Savings or Current):");
            string accountType = Console.ReadLine();

            Console.WriteLine("Enter your acc number:");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter your Initial Balance:");
            int initialBalance = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the interest rate:");
            int interestRate =int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the overdraft limit:");
            //double overdraftLimit = double.Parse(Console.ReadLine());

            SavingAccounts ui =new SavingAccounts(accountNumber,name,initialBalance,accountType,interestRate);
            BankAccounts.bankAccounts.Add(ui);
            return ui; 
            //if (accountType == "Savings")
            //{
            //    Console.WriteLine("Enter the interest rate:");
            //    int interestRate =int.Parse(Console.ReadLine());

            //    SavingAccounts account = new SavingAccounts(accountNumber, name, initialBalance, accountType ,interestRate);
            //    return account;
            //}
            //else if (accountType == "current")
            //{
            //    Console.WriteLine("Enter the overdraft limit:");
            //    double overdraftLimit = double.Parse(Console.ReadLine());

            //    CurrentAccounts account = new CurrentAccounts(accountNumber,name,initialBalance,accountType);
            //    return account;
            //}
            //else
            //{
            //    Console.WriteLine("Invalid account type.");
            //    return null;
            //}
        }

    }
}
