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

            // Print Students and display equality
            SortingPrinting.PrintStudents(STUDENTS);
            SortingPrinting.Equality(STUDENTS);
            Console.WriteLine();

            // Sorting Students Array
            SortingPrinting.Sort(ref STUDENTS);

            // Printing the Students Array after sorting
            Console.WriteLine("Students after ordering them: ");
            Console.WriteLine();
            SortingPrinting.PrintStudents(STUDENTS);

            Console.ReadKey();
        }
    }
}
