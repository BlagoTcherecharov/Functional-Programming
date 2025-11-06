using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculateFunction
{
    class Program
    {
        static double x;

        static double Factoriel(double n)
        {
            if (n > 1)
                return n * Factoriel(n - 1);
            else
                return 1;
        }

        static double Func1(double n)
        {
            double element = Math.Pow(x, n) / Factoriel(n);

            if (n > 0 || element < Math.Pow(10, -7))
                return element + Func1(n - 1);

            return 1;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter n: ");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Func1(n));
        }
    }
}
