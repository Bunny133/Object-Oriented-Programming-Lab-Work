using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
        }

        public static void  CompanyInfo()
        {
            TaxiCompany obj = new TaxiCompany();
            Console.WriteLine("ENter the name of the company:")
        }

        public static Passenger PassengerData()
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your phone Number:");
            string PhoneNumber = Console.ReadLine();
            Console.WriteLine("Enter your Pick up location:");
            string Location = Console.ReadLine();
            Passenger obj = new Passenger(name, PhoneNumber, Location);
            return obj;
        }
    }
}
