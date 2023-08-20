using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class Subjects
    {
        public int subjectCode;
        public string subjectType = "";
        public int creditHours;
        public int subjectFees;

        public Subjects(int subjectCode, string subjectType, int creditHours, int subjectFees)
        {
            this.subjectCode = subjectCode;
            this.subjectType = subjectType;
            this.creditHours = creditHours;
            this.subjectFees = subjectFees;
        }
        public int GetCode()
        {
            return subjectCode;
        }
        public static void registerSubjects(Student s)
        {
            Console.WriteLine("Enter how many subjects you want to register");
            int count = int.Parse(Console.ReadLine());
            for (int x = 0; x < count; x++)
            {
                Console.WriteLine("Enter the subject Code");
                int code = int.Parse(Console.ReadLine());
                bool Flag = false;
                foreach (Subjects sub in s.regDegree.subjects)
                {
                    if (code == sub.GetCode() && !(s.regSubject.Contains(sub)))
                    {
                        if (s.regStudentSubject(sub) == true)
                        {
                            Flag = true;
                            break;
                        }
                        else
                        {
                            Console.WriteLine("A student cannot have more than 9 CH");
                            Flag = true;
                            break;
                        }
                    }
                }
                if (Flag == false)
                {
                    Console.WriteLine("Enter Valid Course");
                    x--;
                }
            }
        }
        public static void viewSubjects(Student s)
        {
            foreach (Subjects sub in s.regDegree.subjects)
            {
                Console.WriteLine(sub.subjectType + "\t\t" + sub.subjectCode + "\t\t" + sub.subjectFees);
            }
        }

    }

}