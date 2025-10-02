using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<double> f1 = x =>
            {
                double result = (x * x) + (4 * x) - 5;

                Console.WriteLine("Function 1 result: " + result);
            };

            Action<double> f2 = x =>
            {
                double result = (x * x * x) - (x * x) + (2 * x) + 6;

                Console.WriteLine("Function 2 result: " + result);
            };

            Action<double> f3 = x =>
            {
                double result;
                if (x <= 0)
                    result = 0;
                else
                    result = ((3 * x * x) - 1) / Math.Sqrt(x);

                Console.WriteLine("Function 3 result: " + result);
            };

            Action<double> f4 = x =>
            {
                double result;
                if (x <= 0)
                    result = 2;
                else if (x > 0 && x < 1)
                    result = x + 2;
                else if (x >= 1 && x <= 2)
                    result = 3;
                else if (x > 2 && x < 3)
                    result = 5 - x;
                else
                    result = 2;

                Console.WriteLine("Function 4 result: " + result);
            };

            Console.Write("Enter x: ");
            double input = Convert.ToDouble(Console.ReadLine());

            f1(input);
            f2(input);
            f3(input);
            f4(input);
        }
    }
}
