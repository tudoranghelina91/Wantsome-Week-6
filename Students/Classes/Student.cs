using System;
using System.Text;
using Students.Structs;

namespace Students.Classes
{
    class Student : ICloneable, IComparable<Student>
    {
        public string FirstName { get; }
        public string MiddleName { get; }
        public string LastName { get; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Universities.Course Course { get; set; }
        public Universities.Specialty Specialty { get; }
        public Universities.University University { get; }
        public Universities.Faculty Faculty { get; }
        public int SSN { get; set; }

        private static Random randomDigit = new Random();

        public Student()
        {

        }

        public Student(string firstName, string lastName, 
            Universities.Course course, 
            Universities.Specialty specialty, 
            Universities.University university, 
            Universities.Faculty faculty, 
            string middleName = "")
        {
            SSN = GetHashCode();
            FirstName = firstName;
            MiddleName = middleName;
            LastName = lastName;
            Course = course;
            Specialty = specialty;
            University = university;
            Faculty = faculty;
        }

        public override bool Equals(object obj)
        {
            if (CompareTo(obj as Student) == 0)
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            int ssn = 0;

            
            for (int i = 1; i <= 9; i++)
            {
                ssn = ssn * 10 + (randomDigit.Next(0, 9));
            }

            return ssn;
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            if (firstStudent.CompareTo(secondStudent) == 0)
                return true;

            return false;
        }

        public static bool operator != (Student firstStudent, Student secondStudent)
        {
            if (firstStudent.CompareTo(secondStudent) != 0)
                return true;

            return false;
        }

        public override string ToString()
        {
            StringBuilder studentDetails = new StringBuilder();
            studentDetails.Append($"First Name: {FirstName}\n");
            studentDetails.Append($"Middle Name: {MiddleName}\n");
            studentDetails.Append($"Last Name: {LastName}\n");
            studentDetails.Append($"Address: {Address}\n");
            studentDetails.Append($"Mobile: {Mobile}\n");
            studentDetails.Append($"Email: {Email}\n");
            studentDetails.Append($"Course: {Course}\n");
            studentDetails.Append($"University: {University}\n");
            studentDetails.Append($"Faculty: {Faculty}\n");
            studentDetails.Append($"SSN: {SSN}\n");

            return studentDetails.ToString();
        }

        public object Clone()
        {
            Student studentClone = new Student(FirstName, LastName, 
                Course, Specialty, University, Faculty, 
                MiddleName
                );

            studentClone.Address = Address;
            studentClone.Mobile = Mobile;
            studentClone.Email = Email;
            studentClone.SSN = SSN;

            return studentClone;
        }

        public int CompareTo(Student student)
        {
            int c = 0;

            c += string.Compare(FirstName, student.FirstName);
            c += string.Compare(LastName, student.LastName);
            c += string.Compare(MiddleName, student.MiddleName);

            if (SSN > student.SSN)
                c++;

            else if (SSN < student.SSN)
                c--;

            return c;
        }
    }
}
