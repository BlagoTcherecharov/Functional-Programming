using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurringAddition
{
    class Program
    {
        static Func<int, Func<int, Func<int, int>>> curringAdd = x => y => z => x + y + z;
        static Func<int, Func<int, int>> oneArgAdd = curringAdd(1);
        static Func<int, int> twoArgsAdd1 = curringAdd(1)(2);
        static Func<int, int> twoArgsAdd2 = oneArgAdd(1);
        static Func<int, Func<int, int>> addTen = curringAdd(10);
        static Func<int, int> addTwoFives = curringAdd(5)(5);

        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int num3 = int.Parse(Console.ReadLine());

            int result1 = curringAdd(num1)(num2)(num3);
            int result2 = twoArgsAdd1(num1);
            int result3 = twoArgsAdd2(num1);
            int result4 = addTen(num1)(num2);
            int result5 = addTwoFives(num1);

            Console.WriteLine($"Results: \n1. {result1}\n2. {result2}\n3. {result3}\n4. {result4}\n5. {result5}");
        }
    }
}
