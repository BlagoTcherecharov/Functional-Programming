using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq
{
    class Student
    {
        private string name, last_name, speciality;
        private int id;
        private double grade;

        public Student(string name, string last_name, string speciality, int id, double grade)
        {
            this.name = name;
            this.last_name = last_name;
            this.speciality = speciality;
            this.id = id;
            this.grade = grade;
        }

        public double Grade { get { return grade; } }
        public string Name { get { return name; } }
        public string Last_Name { get { return last_name; } }
        public int Id { get { return id; } }
        public string Speciality { get { return speciality; } }
    }

    class Program
    {
        static List<Student> studentsList;

        static void GoodGrades()
        {
            var good_grades = from student in studentsList
                              where student.Grade >= 5.00
                              select student;

            Console.WriteLine("Number of students with good grades: " + good_grades.Count());
        }

        static void SortById()
        {
            var id_sort = from student in studentsList
                          orderby student.Id
                          select student;

            Console.WriteLine("\nStudents sorted by ID:");
            foreach (var student in id_sort)
            {
                Console.WriteLine("ID: " + student.Id + "\tStudent name: " + student.Name + " " + student.Last_Name);
            }
        }

        static void SortByName()
        {
            var name_sort = from student in studentsList
                            orderby student.Name, student.Last_Name
                            select student;

            Console.WriteLine("\nStudents sorted by name:");
            foreach (var student in name_sort)
            {
                Console.WriteLine(student.Name + " " + student.Last_Name);
            }
        }

        static void SortByGrade()
        {
            var grade_sort = from student in studentsList
                             orderby student.Grade descending
                             select student;

            Console.WriteLine("\nStudents sorted by grade(Best to worst):");
            foreach (var student in grade_sort)
            {
                Console.WriteLine("Grade: " + student.Grade + "\tStudent name: " + student.Name + " " + student.Last_Name);
            }
        }

        static void GroupBySpeciality()
        {
            var speciality_group = from student in studentsList
                                   group student by student.Speciality;

            foreach (var group in speciality_group)
            {
                Console.WriteLine("\nSpeciality " + group.Key + " students: ");
                foreach (var student in group)
                {
                    Console.WriteLine(student.Name + " " + student.Last_Name);
                }
            }
        }

        static void Main(string[] args)
        {
            studentsList = new List<Student>()
            {
                new Student("Petko", "Petkov", "KST", 31, 5.10),
                new Student("Ivan", "Ivanov", "SKI", 12, 5.20),
                new Student("Georgi", "Georgiev", "KST",  32, 5.60),
                new Student("Nikola", "Nikolov", "SKI", 42, 4.90),
            };

            GoodGrades();
            SortById();
            SortByName();
            SortByGrade();
            GroupBySpeciality();
        }
    }
}
