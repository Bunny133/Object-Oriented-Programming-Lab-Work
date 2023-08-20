using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challange_1
{
    class DegreeProgram
    {
        public string degreeName = "";
        public int degreeDuration;
        public int seatsForDegree;
        public int noOfSubjects;
        public List<Subjects> subjects;

        public DegreeProgram(string degreeName, int degreeDuration, int seatsForDegree)
        {
            this.degreeName = degreeName;
            this.degreeDuration = degreeDuration;
            this.seatsForDegree = seatsForDegree;
            subjects = new List<Subjects>();
        }
        public void setSeats(int seats)
        {
            this.seatsForDegree = seats;
        }
        public static List<Student> students = new List<Student>();

        public List<Subjects> viewAllSubjects()
        {
            return subjects;
        }

        public List<Student> viewAllStudents()
        {
            List<Student> studentsInDegreeProgram = new List<Student>();
            foreach (Student student in students)
            {
                if (student.regDegree == this)
                {
                    studentsInDegreeProgram.Add(student);
                }
            }
            return studentsInDegreeProgram;
        }

        public int calculateCreditHours()
        {
            int ch = 0;

            foreach (Subjects sub in subjects)
            {
                ch += sub.creditHours;
            }

            return ch;
        }

        public void addSubject(Subjects s)
        {
            bool flag = false;
            int creditHours = calculateCreditHours();
            if (creditHours + s.creditHours
            <= 20)
            {
                if (!isSubjectExists(s))
                {
                    subjects.Add(s);
                    Console.WriteLine("Subject Added");
                }
                else
                {
                    Console.WriteLine("Subject Already Exists");
                }
            }
            else
            {
                Console.WriteLine("20 credit hour limit exceeded");
            }
        }

        public bool isSubjectExists(Subjects s)
        {
            Subjects s1 = subjects.Find(e => e.subjectType == s.subjectType);
            if (s1 != null)
            {
                return true;
            }

            return false;


        }
        public void addStudent(Student student)
        {
            student.regDegree = this;
            students.Add(student);
        }



    }

}