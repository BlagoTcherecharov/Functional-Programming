using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberPrint
{
    class Program
    {
        static void PrintReverse(int n)
        {
            Console.Write(n + " ");
            if (n > 1)
                PrintReverse(n - 1);
        }

        static void Print(int n)
        {
            if (n > 1)
                Print(n - 1);
            Console.Write(n + " ");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Reverse order: ");
            PrintReverse(x);

            Console.WriteLine("\nIn order: ");
            Print(x);
        }
    }
}
