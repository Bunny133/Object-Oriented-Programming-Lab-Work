using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student_managment_system
{
    class Program
    {
        class Students
        {
            public string name;
            public int roll_no;
            public float CGPA;
            public string ishostellite;
            public string department;
        }
        static void Main(string[] args)
        {
            Students[] record = new Students[1];
            int count = 0;
            int choice;
            do
            {
                 choice = menu();
                if (choice == 1)
                {
                    record[count] = Addstudents();
                    count++;


                }
                else if (choice == 2)
                {
                    ViewStudents(record, count);
                }

                else if (choice == 3)
                {
                    topstudent(record, count);

                }
                else if (choice == 4 )
                {
                    break;
                }

                Console.ReadKey();
            }
            while (choice != 4);
            Console.WriteLine("Press any key to exit");
            

        }


        static int menu()
        {
            Console.Clear();
            int option;
            Console.WriteLine("1. Add Students");
            Console.WriteLine("2. Show Students");
            Console.WriteLine("3. Top 3 Students");
            Console.WriteLine("4. Exit");

            Console.WriteLine("Enter your option");
            option = int.Parse(Console.ReadLine());
            return option;
        }


        static Students Addstudents()
        {
            Console.Clear();
            Students T1 = new Students();

            Console.WriteLine("Enter Name of the student:");
            T1.name = Console.ReadLine();
            Console.WriteLine("Enter Roll Number of the student:");
            T1.roll_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter CGPA of the student:");
            T1.CGPA = float.Parse(Console.ReadLine());
            Console.WriteLine("IS Student hostelite?");
            T1.ishostellite = Console.ReadLine();
            Console.WriteLine("Enter the deparment of the student:");
            T1.department = Console.ReadLine();
            return T1;
        }


        static void ViewStudents(Students[] record, int count)
        {
            Console.Clear();
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Name: {0} Roll number:{1} CGPA:{2} ISHostellite:{3} Depatment:{4}", record[i].name, record[i].roll_no,
                    record[i].CGPA, record[i].ishostellite, record[i].department);
            }
            Console.WriteLine("Press any key to contiue");
            

        }


        static int largest(Students[] record, int start, int end)
        {
            int index = start;
            float large = record[start].CGPA;

            //starting from first index of the array
            
            for (int i = start; i < end; i++)
            {
                if (large < record[i].CGPA)
                {
                    large = record[i].CGPA;
                    index = i;
                }
            }
            return index;
        }


        static void topstudent(Students[] record, int count )
        {
            Console.Clear();
            if (count == 0)
            {
                Console.WriteLine("NO record found");
            }

            else if (count == 1)
            {
                ViewStudents(record, 1);
            }

            else if(count ==2)
            {
                for (int i=0; i <2;i++)
                {
                    int index = largest(record, count, i);
                    Students temp = record[index];
                    record[index] = record[i];
                    record[i] = temp;
                        
                }
                ViewStudents(record, 2);
            }

            else
            {
                for (int i = 0; i < 3; i++)
                {
                    int index = largest(record, count, i);
                    Students temp = record[index];
                    record[index] = record[i];
                    record[i] = temp;

                }
                ViewStudents(record, 3);
            }

        }


 }   
}
