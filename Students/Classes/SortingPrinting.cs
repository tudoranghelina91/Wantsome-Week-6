using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students.Classes
{
    public static class SortingPrinting
    {
        public static void Equality(Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
                for (int j = i + 1; j < students.Length; j++)
                    if (students[i] == students[j])
                        Console.WriteLine($"{students[i].FirstName} is equal to {students[j].FirstName}");
                    else
                        Console.WriteLine($"{students[i].FirstName} is not equal to {students[j].FirstName}");
        }

        public static void Sort(ref Student[] students)
        {
            for (int i = 0; i < students.Length - 1; i++)
                for (int j = i + 1; j < students.Length; j++)
                    if (students[i].CompareTo(students[j]) > 0)
                    {
                        Student dummyStudent = (students[i].Clone() as Student);
                        students[i] = (students[j].Clone() as Student);
                        students[j] = (dummyStudent.Clone() as Student);
                    }
        }

        public static void PrintStudents(Student[] students)
        {
            foreach (Student student in students)
            {
                Console.WriteLine(student);
            }
        }
    }
}
