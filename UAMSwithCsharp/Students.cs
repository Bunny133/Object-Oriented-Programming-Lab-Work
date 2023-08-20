using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class Student
    {
        public string studentName = "";
        public int studentAge;
        public double fscMarks;
        public double ecatMarks;
        public double merit;
        public List<DegreeProgram> preferences;
        public List<Subjects> regSubject;
        public DegreeProgram regDegree;

        public Student(string studentName, int studentAge, double fscMarks, double ecatMarks, List<DegreeProgram> preferences)
        {
            this.studentName = studentName;
            this.studentAge = studentAge;
            this.fscMarks = fscMarks;
            this.ecatMarks = ecatMarks;
            this.preferences = preferences;
            regSubject = new List<Subjects>();
        }

        public bool regStudentSubject(Subjects s)
        {
            int stCH = getCreditHours();
            if (regDegree != null &&
            regDegree.isSubjectExists(s) && stCH +
            s.creditHours <= 9)
            {
                regSubject.Add(s);
                Console.WriteLine("Added");
                return true;
            }
            else
            {
                Console.WriteLine("A student cannot have more than 9 CH or Wrong Subject");
                return false;
            }
        }

        public int getCreditHours()
        {
            int ch = 0;
            foreach (Subjects sub in regSubject)
            {
                ch += sub.creditHours;
            }
            return ch;
        }
        public int calculateFees()
        {
            int fees = 0;
            foreach (Subjects sub in regSubject)
            {
                fees += sub.subjectFees;
            }
            return fees;
        }
        public static void viewFeesForAll()
        {
            foreach (Student stu in Program.students)
            {
                Console.WriteLine(stu.studentName + " has " + stu.calculateFees() + " fees");
            }
        }
        public void calculateMerit()
        {
            merit = (((fscMarks / 1100) * 0.45F) + ((ecatMarks / 400) * 0.55F)) * 100;

        }
        public static List<Student> sortByMerit()
        {
            List<Student> sortedList = new List<Student>();
            foreach (Student stu in Program.students)
            {
                stu.calculateMerit();
            }
            sortedList = Program.students.OrderByDescending(o => o.merit).ToList();
            return sortedList;
        }
        public static void giveAdmission(List<Student> sortedList)
        {
            foreach (Student stu in sortedList)
            {
                foreach (DegreeProgram d in stu.preferences)
                {
                    if (d.seatsForDegree > 0 && stu.regDegree == null)
                    {
                        stu.regDegree = d;
                        int seats = d.seatsForDegree;
                        seats--;
                        d.setSeats(seats);
                        break;
                    }
                }
            }
        }
        public static void printStudents()
        {
            foreach (Student stu in Program.students)
            {
                if (stu.regDegree != null)
                {
                    Console.WriteLine(stu.studentName + " got admission in " + stu.regDegree.degreeName);
                }
                else
                {
                    Console.WriteLine(stu.studentName + " did not get admission in " + stu.regDegree.degreeName);

                }
            }
        }
    }

}