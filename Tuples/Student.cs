using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAverage
{
    class Program
    {
        static void Average(Tuple<string, double, double, double, double> student)
        {
            double average = (student.Item2 + student.Item3 + student.Item4 + student.Item5)/4;

            Console.WriteLine("Student " + student.Item1 + " has an average of " + average);
        }

        static void Main(string[] args)
        {
            Tuple<string, double, double, double, double> student = new Tuple<string, double, double, double, double> ("Ivan Ivanov", 4.50, 3, 5, 6);

            Average(student);
        }
    }
}
