using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumCalculator
{
    class Program
    {
        static int Sum(int n)
        {
            if (n > 0)
                return n + Sum(n - 1);

            return 0;
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Sum: " + Sum(x));
        }
    }
}
