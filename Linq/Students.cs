using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentLinq
{
    class Student
    {
        private string name, last_name;
        private double grade;

        public Student(string name, string last_name, double grade)
        {
            this.name = name;
            this.last_name = last_name;
            this.grade = grade;
        }

        public double Grade{ get { return grade; } }

        public string Name { get { return name; } }

        public string Last_Name { get { return last_name; } }

        public void Info_output()
        {
            Console.WriteLine(Name + " " + Last_Name);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentsList = new List<Student>()
            {
                new Student("Petko", "Petkov", 5.50),
                new Student("Ivan", "Ivanov", 5.49),
                new Student("Georgi", "Georgiev", 5.60),
                new Student("Nikola", "Nikolov", 5.20),
            };

            var great_grade = from student in studentsList
                              where student.Grade >= 5.50
                              select student;

            var good_grade = from student in studentsList
                             where student.Grade >= 5.00 && student.Grade < 5.50
                             select student;


            Console.WriteLine("Students with 5.50 and more: ");
            foreach (var student in great_grade)
                student.Info_output();

            Console.WriteLine("Students with grade between 4.99 and 5.50: ");
            foreach (var student in good_grade)
                student.Info_output();


        }
    }
}
