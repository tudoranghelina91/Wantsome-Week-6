using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OverrideSystemObject.Classes;

namespace OverrideSystemObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Marian Vasile", 26);
            Student student2 = new Student("Gigi Muschi", 26);
            Student student3 = new Student("Marian Vasile", 26);

            Console.WriteLine(student.ToString());
            Console.WriteLine(student2.ToString());
            Console.WriteLine(student3.ToString());

            Console.WriteLine($"student 1 is equal to student 2? {student.Equals(student2)}");
            Console.WriteLine($"student 2 is equal to student 3? {student.Equals(student3)}");

            Console.ReadKey();
        }
    }
}
