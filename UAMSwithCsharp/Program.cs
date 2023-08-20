using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class Program
    {
        public static List<Student> students = new List<Student>();
        static List<DegreeProgram> degrees = new List<DegreeProgram>();
        public static void Main(string[] args)
        {
            while (true)
            {
                int option = menu();
                if (option == 1)
                {
                    if (degrees.Count > 0)
                    {
                        Student s = takeInputForStudent(degrees);

                    }
                }
                else if (option == 2)
                {
                    Console.Clear();
                    degrees.Add(addDegree());
                }
                else if (option == 3)
                {
                    Console.Clear();
                    List<Student> sortedList = new List<Student>();
                    sortedList = Student.sortByMerit();
                    Student.giveAdmission(sortedList);
                    Student.printStudents();
                }
                else if (option == 4)
                {
                    Console.Clear();
                    registeredStudents(DegreeProgram.students);
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    Console.Clear();
                    specificStudents(degrees);
                }
                else if (option == 6)
                {
                    Console.Clear();
                    Console.Write("Enter Student Name: ");
                    string name = Console.ReadLine();
                    Student s = DegreeProgram.students.Find(e => e.studentName == name);
                    if (s != null)
                    {
                        Subjects.viewSubjects(s);
                        Subjects.registerSubjects(s);

                    }
                }
                else if (option == 7)
                {
                    Student.viewFeesForAll();

                }
                Console.Write("Press Any Key......");
                Console.ReadKey();

            }
        }

        static int menu()
        {
            int option = 0;
            Console.WriteLine("1.Add Student");
            Console.WriteLine("2.Add Degree Program");
            Console.WriteLine("3.Generate Merit");
            Console.WriteLine("4.View Registered Students");
            Console.WriteLine("5.View Students of a Specific Program");
            Console.WriteLine("6.Registered Subjects For Specific Student");
            Console.WriteLine("7.Calculate Fees For All Registered Students");
            option = int.Parse(Console.ReadLine());
            return option;
        }

        public static DegreeProgram addDegree()
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter Degree Duration: ");
            int duration = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Seats For The Degree: ");
            int seats = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter No Of Subjects For This Degree: ");
            int no = int.Parse(Console.ReadLine());
            DegreeProgram degree = new DegreeProgram(name, duration, seats);
            for (int i = 0; i < no; i++)
            {
                Subjects subj = takeInputForSubject();
                degree.subjects.Add(subj);

            }
            return degree;
        }
        static void specificStudents(List<DegreeProgram> degrees)
        {
            Console.WriteLine("Enter Degree Name: ");
            string name = Console.ReadLine();
            DegreeProgram degree = degrees.Find(e => e.degreeName == name);
            if (degree != null)
            {
                foreach (Student stu in degree.viewAllStudents())
                {
                    Console.WriteLine(stu.studentName + "," + stu.fscMarks + "," + stu.ecatMarks + "," + stu.studentAge);
                }
            }
        }
        static void registeredStudents(List<Student> students)
        {

            Console.WriteLine("All Students");
            foreach (Student stu in students)
            {
                Console.WriteLine(stu.studentName + "," + stu.fscMarks + "," + stu.ecatMarks + "," + stu.studentAge);
            }
            Console.ReadKey();

        }

        static Subjects takeInputForSubject()
        {
            Console.WriteLine("Enter Subject Code: ");
            int code = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Subject Type: ");
            string type = (Console.ReadLine());
            Console.WriteLine("Enter Credit Hours For This Subject: ");
            int credit = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Fees For This Subject: ");
            int fee = int.Parse(Console.ReadLine());
            Subjects sub = new Subjects(code, type, credit, fee);
            return sub;
        }

        public static Student takeInputForStudent(List<DegreeProgram> degrees)
        {
            Console.Clear();
            Console.WriteLine("Enter Student Name: ");
            string name = (Console.ReadLine());
            Console.WriteLine("Enter Student Age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student FSC Marks: ");
            int fscMarks = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Student ECAT Marks: ");
            int ecatMarks = int.Parse(Console.ReadLine());

            Console.WriteLine("Available Degree Programs:");
            for (int i = 0; i < degrees.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {degrees[i].degreeName}");
            }

            Console.WriteLine("Enter How Many Preferences: ");
            int numPreferences = int.Parse(Console.ReadLine());
            List<DegreeProgram> preferences = new List<DegreeProgram>();
            for (int i = 0; i < numPreferences; i++)
            {
                Console.WriteLine($"Enter Preference {i + 1}:");
                string preferenceName = Console.ReadLine();
                DegreeProgram degree = degrees.Find(d => d.degreeName == preferenceName);
                if (degree != null)
                {
                    preferences.Add(degree);
                }
                else
                {
                    Console.WriteLine($"Degree program '{preferenceName}' not found!");
                }
            }

            Student student = new Student(name, age, fscMarks, ecatMarks, preferences);
            foreach (DegreeProgram degree in preferences)
            {
                if (degree.seatsForDegree > 0)
                {
                    degree.addStudent(student);
                    students.Add(student);
                }
            }
            return student;
        }


    }

}