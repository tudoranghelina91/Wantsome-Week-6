using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Students.Structs;
using Students.Classes;

namespace Students.Structs
{
    struct MyStudents
    {
        static Student student1 = new Student("Gigi", "Botgros",
            Universities.Course.DataStructures,
            Universities.Specialty.ComputerScience,
            Universities.University.UAIC,
            Universities.Faculty.ComputerScience
            );

        static Student student2 = student1.Clone() as Student;

        static Student student3 = new Student("Gigel", "Capota",
            Universities.Course.AdvancedMathematics,
            Universities.Specialty.AppliedInformatics,
            Universities.University.UT,
            Universities.Faculty.AppliedInformatics
            );

        static Student student4 = new Student("Gogu", "Trompeta",
            Universities.Course.MusicTheory,
            Universities.Specialty.Clarinet,
            Universities.University.UNAGE,
            Universities.Faculty.FICSMT
            );

        public static Student[] studentArr = new Student[] { student1, student2, student3, student4 };
    }
}
