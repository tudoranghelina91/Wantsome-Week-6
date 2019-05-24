using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverrideSystemObject.Classes
{
    class Student
    {
        public string Name { get; }
        public int Age { get; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public override bool Equals(object obj)
        {
            if (this.Name == (obj as Student).Name && this.Age == (obj as Student).Age)
                return true;

            return false;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"Name: {Name}\n");
            sb.Append($"Age: {Age}\n");
            return sb.ToString();
        }
    }
}
