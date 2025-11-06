using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptySpace
{
    class Program
    {
        static void PrintEmptyRec(int n)
        {
            Console.Write(" ");
            if (n > 1)
                PrintEmptyRec(n - 1);
        }

        static void PrintEmptyIter(int n)
        {
            for(int i = 0; i < n; i++)
                Console.Write(" ");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Recursion:");
            Console.Write("|");
            PrintEmptyRec(x);
            Console.Write("|");

            Console.WriteLine("\nIteration:");
            Console.Write("|");
            PrintEmptyIter(x);
            Console.Write("|");
        }
    }
}
