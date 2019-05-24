using System.Text;

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

        public override string ToString()
        {
            StringBuilder personDetails = new StringBuilder();
            personDetails.Append($"Name: {Name}\n");
            if (Age == null)
                personDetails.Append($"Age: NO\n");

            else
                personDetails.Append($"Age: {Age}\n");

            return personDetails.ToString();
        }
    }
}
