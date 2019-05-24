using System;
using Persons.Classes;
using Persons.Structs;

namespace Persons
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (Person person in PeopleStruct.People)
            {
                Console.WriteLine(person.ToString());
            }
            Console.ReadKey();
        }
    }
}
