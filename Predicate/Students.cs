using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Student
{
    class Person
    {
        private string first_name, last_name;
        private int age;

        public Person(string first_name, string last_name, int age)
        {
            this.first_name = first_name;
            this.last_name = last_name;
            this.age = age;
        }

        public string FirstName { get { return first_name; } }
        public string LastName { get { return last_name; } }
        public int Age { get { return age; } }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Person> students = new List<Person> {
                new Person("Ivan", "Ivanov", 18),
                new Person("Georgi", "Georgiev", 20),
                new Person("Petko", "Petkov", 17)
            };

            Predicate<int> isLegalAge = a => { return a >= 18; };

            foreach (Person student in students)
            {
                if (isLegalAge(student.Age))
                    Console.WriteLine(student.FirstName + " " + student.LastName + " is 18+.");
            }
        }
    }
}
