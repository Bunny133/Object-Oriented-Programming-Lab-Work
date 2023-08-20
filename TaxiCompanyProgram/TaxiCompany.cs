using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyProgram
{
    public class TaxiCompany
    {
        public string Name;
        public List<Taxi> taxis = new List<Taxi>();
       // public static TaxiCompany obj=new TaxiCompany();
        public TaxiCompany(string Name)
        {
            this.Name = Name;
        }

        public TaxiCompany()
        {
        }

        public bool ReceiveCall(Passenger obj)
        {
            if(obj !=null)
            {
                Console.WriteLine("I have received the info and i am about to book a taxi for u");
                return true;
            }
            else
            {
                return false;

            }
            
        }

        public 

    }

}
