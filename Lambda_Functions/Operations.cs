using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<int, int> Addition = (x, y) => { Console.WriteLine("x + y = " + (x + y)); };
            Action<int, int> Substraction = (x, y) => { Console.WriteLine("x - y = " + (x - y)); };
            Action<int, int> Multiplication = (x, y) => { Console.WriteLine("x * y = " + (x * y)); };
            Action<int, int> Division = (x, y) => { if (y != 0) { Console.WriteLine("x / y = " + (x + y)); } else { Console.WriteLine("Can't divide by 0"); } };

            Console.Write("Enter x: ");
            int input_x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int input_y = int.Parse(Console.ReadLine());

            Addition(input_x, input_y);
            Substraction(input_x, input_y);
            Multiplication(input_x, input_y);
            Division(input_x, input_y);
        }
    }
}
