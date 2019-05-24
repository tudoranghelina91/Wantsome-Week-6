using Persons.Classes;

namespace Persons.Structs
{
    struct PeopleStruct
    {
        static Person gogu = new Person("Gogu");
        static Person vasile = new Person("Vasile", 21);
        static Person iulian = new Person("Iulian", 15);
        static Person gigi = new Person("Gigi");
        static Person murel = new Person("Murel", 22);
        static Person titi = new Person("Titi");

        public static Person[] People = new Person[] { gogu, vasile, iulian, gigi, murel, titi };
    }
}
