using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarPrint
{
    class Program
    {
        static void Print(int n)
        {
            Console.Write("*");
            if (n > 1)
                Print(n - 1);
            else
                Console.WriteLine();
        }
        
        static void Line(int n)
        {
            if (n > 0)
            {
                Print(n);
                Line(n - 1);
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int x = int.Parse(Console.ReadLine());
            
            Line(x);
        }
    }
}
