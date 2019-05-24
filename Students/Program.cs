using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Classes;
using Students.Structs;

namespace Students
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Student student in MyStudents.studentArr)
            {
                Console.WriteLine(student.ToString());
            }

            for (int i = 0; i < MyStudents.studentArr.Length - 1; i++)
                for (int j = i + 1; j < MyStudents.studentArr.Length; j++)
                    if (MyStudents.studentArr[i] == MyStudents.studentArr[j])
                        Console.WriteLine($"{MyStudents.studentArr[i].FirstName} is equal to {MyStudents.studentArr[j].FirstName}");
                    else
                        Console.WriteLine($"{MyStudents.studentArr[i].FirstName} is not equal to {MyStudents.studentArr[j].FirstName}");


            Console.ReadKey();
        }
    }
}
