using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons.Classes
{
    class Person
    {
        string Name { get; }
        int? Age { get; }

        public Person(string name, int? age = null)
        {
            Name = name;
            Age = age;
        }
    }
}
