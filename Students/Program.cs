using System;
using Students.Classes;
using Students.Structs;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            Student[] STUDENTS = MyStudents.studentArr;

            foreach (Student student in STUDENTS)
            {
                Console.WriteLine(student);
            }

            for (int i = 0; i < STUDENTS.Length - 1; i++)
                for (int j = i + 1; j < STUDENTS.Length; j++)
                    if (STUDENTS[i] == STUDENTS[j])
                        Console.WriteLine($"{STUDENTS[i].FirstName} is equal to {STUDENTS[j].FirstName}");
                    else
                        Console.WriteLine($"{STUDENTS[i].FirstName} is not equal to {STUDENTS[j].FirstName}");

            Console.WriteLine();

            for (int i = 0; i < STUDENTS.Length - 1; i++)
                for (int j = i + 1; j < STUDENTS.Length; j++)
                    if (STUDENTS[i].CompareTo(STUDENTS[j]) > 0)
                    {
                        Student dummyStudent = (STUDENTS[i].Clone() as Student);
                        STUDENTS[i] = (STUDENTS[j].Clone() as Student);
                        STUDENTS[j] = (dummyStudent.Clone() as Student);
                    }

            Console.WriteLine("Students after ordering them: ");
            foreach (Student student in STUDENTS)
            {
                Console.WriteLine(student);
            }


            Console.ReadKey();
        }
    }
}
