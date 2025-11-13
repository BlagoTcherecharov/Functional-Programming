using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAverage
{
    class Program
    {
        static void Average(Tuple<string, int, int, int, int> student)
        {
            double average = (student.Item2 + student.Item3 + student.Item4 + student.Item5)/4;

            Console.WriteLine("Student " + student.Item1 + " has an average of " + average);
        }

        static void Main(string[] args)
        {
            Tuple<string, int, int, int, int> student = new Tuple<string, int, int, int, int> ("Ivan Ivanov", 4, 3, 5, 6);

            Average(student);
        }
    }
}
