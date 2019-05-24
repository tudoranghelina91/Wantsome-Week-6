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

        static Student student3 = new Student("Vasile", "Capota",
            Universities.Course.AdvancedMathematics,
            Universities.Specialty.AppliedInformatics,
            Universities.University.UT,
            Universities.Faculty.AppliedInformatics
            );

        static Student student4 = new Student("Dumitru", "Trompeta",
            Universities.Course.MusicTheory,
            Universities.Specialty.Clarinet,
            Universities.University.UNAGE,
            Universities.Faculty.FICSMT
            );

        static Student student5 = new Student("Petrica", "Vasilescu",
            Universities.Course.MusicTheory,
            Universities.Specialty.Clarinet,
            Universities.University.UNAGE,
            Universities.Faculty.FICSMT
            );

        static Student student6 = new Student("Maria", "Aavasilcai",
            Universities.Course.DataStructures,
            Universities.Specialty.ComputerScience,
            Universities.University.UAIC,
            Universities.Faculty.ComputerScience
            );

        public static Student[] studentArr = new Student[] { student1, student2, student3, student4, student5, student6 };
    }
}
