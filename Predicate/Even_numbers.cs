using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumbers
{
    class Program
    {
        static bool IsEven(int x)
        {
            return x % 2 == 0;
        }

        static void Main(string[] args)
        {
            int[] array = { 20, 30, 21, 12, 15 };

            Predicate<int> isEven = IsEven;

            Predicate<int> isEvenLambda = x => x % 2 == 0;

            Predicate<int> isEvenAnonymous = delegate (int x) { return x % 2 == 0; }; 

            foreach (int a in array)
            {
                if (isEven(a) == true)
                    Console.WriteLine(a + " is even");
                else
                    Console.WriteLine(a + " is odd");

                if (isEvenLambda(a) == true)
                    Console.WriteLine(a + " is even");
                else
                    Console.WriteLine(a + " is odd");

                if (isEvenAnonymous(a) == true)
                    Console.WriteLine(a + " is even");
                else
                    Console.WriteLine(a + " is odd");

                Console.WriteLine();
            }
        }
    }
}
