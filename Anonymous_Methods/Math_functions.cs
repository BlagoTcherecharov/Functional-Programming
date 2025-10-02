using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFunctions
{
    class Program
    {
        public delegate void function(int x);

        static void Main(string[] args)
        {
            Console.Write("Enter x: ");
            int input = int.Parse(Console.ReadLine());

            function f1 = delegate (int x)
            {
                double result = (x * x) + (4 * x) - 5;

                Console.WriteLine("Function 1 result: " + result);
            };

            function f2 = delegate (int x)
            {
                double result = (x * x * x) - (x * x) + (2 * x) + 6;

                Console.WriteLine("Function 2 result: " + result);
            };

            function f3 = delegate (int x)
            {
                double result;
                if (x <= 0)
                    result = 0;
                else
                    result = ((3 * x * x) - 1) / Math.Sqrt(x);

                Console.WriteLine("Function 3 result: " + result);
            };

            function f4 = delegate (int x)
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

            f1(input);
            f2(input);
            f3(input);
            f4(input);
        }
    }
}
