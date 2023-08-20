using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyProgram
{
    public class Passenger
    {
        public string NameofCustomer;
        public string PhoneNumber;
        public string PickUpLocation;
       
      

        public Passenger(string NameofCustomer,string PhoneNumber,string PickUpLocation)
        {
            this.NameofCustomer = NameofCustomer;
            this.PhoneNumber = PhoneNumber;
            this.PickUpLocation = PickUpLocation;

        }

        public bool CallTaxiCompany()
        {
            if (string.IsNullOrEmpty(NameofCustomer) || string.IsNullOrEmpty(PhoneNumber) || string.IsNullOrEmpty(PickUpLocation))
            {
                Console.WriteLine("Please provide all required information to call the taxi company.");
                return false;
            }
            else
            {
                Console.WriteLine("YOu have successfully made the call to the companby:");
                return true;
                
            }


        }
    }
    
}
