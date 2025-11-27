using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurringMultiplication
{
    class Program
    {
        static Func<int, Func<int, Func<int, int>>> Multiplication = x => y => z => x * y * z;
        static Func<int, Func<int, int>> TwoArgsByTwo = Multiplication(2);
        static Func<int, Func<int, int>> TwoArgsByThree = Multiplication(3);
        static Func<int, Func<int, int>> TwoArgsBySix = Multiplication(6);
        static Func<int, int> OneArgsByTwo = TwoArgsByTwo(1);
        static Func<int, int> OneArgsByThree = TwoArgsByThree(1);
        static Func<int, int> OneArgsBySix = TwoArgsBySix(1);

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Results: ");
            Console.WriteLine("Multiplication: " + Multiplication(num1)(num2)(num3));

            Console.WriteLine("Multiplication by 2 with 2 arguments: " + TwoArgsByTwo(num1)(num2));
            Console.WriteLine("Multiplication by 3 with 2 arguments: " + TwoArgsByThree(num1)(num2));
            Console.WriteLine("Multiplication by 6 with 2 arguments: " + TwoArgsBySix(num1)(num2));

            Console.WriteLine("Multiplication by 2 with 1 argument: " + OneArgsByTwo(num1));
            Console.WriteLine("Multiplication by 3 with 1 argument: " + OneArgsByThree(num1));
            Console.WriteLine("Multiplication by 6 with 1 argument: " + OneArgsBySix(num1));
        }
    }
}
