using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxiCompanyProgram
{
    public class Taxi
    {
        public string ModelOFTaxi;
        public string NumberPlate;
        public List<Passenger> passengerList;

        public Taxi(string ModelOFTaxi, string NumberPlate)
        {
            this.ModelOFTaxi = ModelOFTaxi;
            this.NumberPlate = NumberPlate;
            //passenger = new List<Passenger>();
        }

        public bool PickUpPassenger(Passenger obj)
        {
            if (obj != null)
            {
                passengerList.Add(obj);
                foreach (Passenger s in passengerList)
                {
                    if (s.NameofCustomer == obj.NameofCustomer)
                    {
                        Console.WriteLine("YOur name is", s.NameofCustomer, "and you have been picked ");
                    }
                }
                return true;
            }
            else
            {
                return false;
            }

        }

        public object DropOfPassenger(Passenger obj)
        {
            if (passengerList.Count>0)
            {
                
                foreach (Passenger s in passengerList)
                {
                    if (s.NameofCustomer == obj.NameofCustomer)
                    {

                        passengerList.Remove(obj);
                        break;
                    }
                }
                Console.WriteLine("You have successfully reached your destination:");
                return true;
            }
            else
            {
                return false;

            }
        }

        public bool NotifyCompanyForPickup()
        {
            if (passengerList!=null)
            {
                Console.WriteLine("I have picked the passenger and i am on my way to my passenger destination");
                return true;
            }
           
            else
            {
                return false;
            }

        }

        public bool NotifyCompanyForDropOff()
        {
            if (passengerList==null)
            {
                Console.WriteLine("I have drop my passenger successfully to his desired destination");
                return true;
            }
           
            else
            {
                return false;
            }

        }
    }
}