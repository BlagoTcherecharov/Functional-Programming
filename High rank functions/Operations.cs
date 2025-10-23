using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        public delegate double OperationDelegate(double x, double y);
        public static void PrintDelegate(OperationDelegate d)
        {
            double x = 6;
            double y = 5;
            d(6, 5);

            if (d == Sum)
                Console.WriteLine($"{x} + {y} = {d(x, y)}");
            else if (d == Difference)
                Console.WriteLine($"{x} - {y} = {d(x, y)}");
            else if (d == Multiplication)
                Console.WriteLine($"{x} * {y} = {d(x, y)}");
            else if (d == Division)
                Console.WriteLine($"{x} / {y} = {d(x, y)}");
        }

        public static void PrintFunc(Func<double, double, string> f)
        {
            Console.WriteLine(f(6, 5));
        }

        public static void PrintLambda(Func<double, double, string> f)
        {
            Console.WriteLine(f(6, 5));
        }

        public static double Sum(double x, double y)
        {
            return x + y;
        }

        public static double Difference(double x, double y)
        {
            return x - y;
        }

        public static double Multiplication(double x, double y)
        {
            return x * y;
        }

        public static double Division(double x, double y)
        {
            return x / y;
        }

        static void Main(string[] args)
        {
            PrintDelegate(Sum);
            PrintDelegate(Difference);
            PrintDelegate(Multiplication);
            PrintDelegate(Division);

            Console.WriteLine();

            Func<double, double, string> fSum = ((a, b) => $"{a} + {b} = {a + b}");
            Func<double, double, string> fDifference = ((a, b) => $"{a} - {b} = {a - b}");
            Func<double, double, string> fSMultiplication = ((a, b) => $"{a} * {b} = {a * b}");
            Func<double, double, string> fDivision = ((a, b) => $"{a} / {b} = {a / b}");

            PrintFunc(fSum);
            PrintFunc(fDifference);
            PrintFunc(fSMultiplication);
            PrintFunc(fDivision);

            Console.WriteLine();

            PrintLambda((a, b) => $"{a} + {b} = {a + b}");
            PrintLambda((a, b) => $"{a} - {b} = {a - b}");
            PrintLambda((a, b) => $"{a} * {b} = {a * b}");
            PrintLambda((a, b) => $"{a} / {b} = {a / b}");
        }
    }
}
