using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pd_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Ship> ships = new List<Ship>();
            string opt;
            do
            {
                Console.Clear();
                opt = menu();
                if (opt == "1")
                {
                    bool flag = addShip(ships);
                    if (flag)
                    {
                        Console.WriteLine("Success");
                    }
                    else
                    {
                        Console.WriteLine("Issue Detected !");
                    }
                }
                else if (opt == "2")
                {
                    view_ship_position(ships);
                }
                else if (opt == "3")
                {
                    view_serialNo(ships);
                }
                else if (opt == "4")
                {
                    change_direction(ships);
                }
            } while ((opt != "5"));

        }
        static bool addShip(List<Ship> ships)
        {
            bool flag = false;
            Console.WriteLine("Enter Ship Number: ");
            string ship_number = Console.ReadLine();

            Console.WriteLine("Ship Latitude");

            Console.WriteLine("Enter Latitude’s Degree:");
            int latitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude’s Minute:");
            float latitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude’s Direction:");
            char latitude_direction = char.Parse(Console.ReadLine());
            Angle obj1 = new Angle(latitude_degree, latitude_minute, latitude_direction);

            Console.WriteLine("Longitude");

            Console.WriteLine("Enter Longitude’s Degree:");
            int longitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude’s Minute:");
            float longitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude’s Direction:");
            char longitude_direction = char.Parse(Console.ReadLine());
            Angle obj2 = new Angle(longitude_degree, longitude_minute, longitude_direction);
            Ship obj = new Ship(obj1, obj2, ship_number);
            ships.Add(obj);
            flag = true;
            return flag;
        }
        static string menu()
        {
            string option;
            Console.WriteLine("1. Add Ship");
            Console.WriteLine("2. View Ship Position");
            Console.WriteLine("3. View Ship Serial Number");
            Console.WriteLine("4. Change Ship Position");
            Console.WriteLine("5. Exit");
            Console.Write("YOur Option--> ");
            option = Console.ReadLine();
            return option;
        }
        static void view_ship_position(List<Ship> ships)
        {
            Console.WriteLine("Enter Serial No of the Ship to find its Position: ");
            string serial_num = Console.ReadLine();
            for (int i = 0; i < ships.Count; i++)
            {
                if (serial_num == ships[i].serial_number)
                {
                    Console.WriteLine(ships[i].latitude.degree + "\u00b0" + ships[i].latitude.minutes + "'" + ships[i].latitude.direction);
                    Console.WriteLine(ships[i].longitude.degree + "\u00b0" + ships[i].longitude.minutes + "'" + ships[i].longitude.direction);
                    Console.ReadKey();
                    break;
                }
            }

        }
        static void view_serialNo(List<Ship> ships)
        {
            Console.WriteLine("Ship Latitude");

            Console.WriteLine("Enter Latitude’s Degree:");
            int latitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude’s Minute:");
            float latitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Latitude’s Direction:");
            char latitude_direction = char.Parse(Console.ReadLine());


            Console.WriteLine("Longitude");

            Console.WriteLine("Enter Longitude’s Degree:");
            int longitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude’s Minute:");
            float longitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude’s Direction:");
            char longitude_direction = char.Parse(Console.ReadLine());
            for (int i = 0; i < ships.Count; i++)
            {
                if ((latitude_degree == ships[i].latitude.degree && latitude_direction == ships[i].latitude.direction && latitude_minute == ships[i].latitude.minutes)
                     && (longitude_degree == ships[i].longitude.degree && longitude_direction == ships[i].longitude.direction && longitude_minute == ships[i].longitude.minutes))
                {
                    Console.WriteLine(ships[i].serial_number);
                    Console.ReadKey();
                    break;
                }
            }
        }
        static bool change_direction(List<Ship> ships)
        {
            Console.WriteLine("Enter (New) Latitude’s Degree:");
            int latitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter (New)  Latitude’s Minute:");
            float latitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter  (New) Latitude’s Direction:");
            char latitude_direction = char.Parse(Console.ReadLine());


            Console.WriteLine("Longitude");

            Console.WriteLine("Enter (New)  Longitude’s Degree:");
            int longitude_degree = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter (New)  Longitude’s Minute:");
            float longitude_minute = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter (New)  Longitude’s Direction:");
            char longitude_direction = char.Parse(Console.ReadLine());

            Console.WriteLine("Enter Ship Serial Number: ");
            string serial_number = Console.ReadLine();

            bool flag = false;
            for (int i = 0; i < ships.Count; i++)
            {
                if (serial_number == ships[i].serial_number)
                {
                    flag = true;
                    ships[i].latitude.change_value(latitude_direction, latitude_degree, latitude_minute);
                    ships[i].longitude.change_value(longitude_direction, longitude_degree, longitude_minute);
                }
                else
                {
                    flag = false;
                }
            }
            return flag;

        }
    }
}
