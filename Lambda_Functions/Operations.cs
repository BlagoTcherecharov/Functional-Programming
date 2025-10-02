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
            Action<double, double> Addition = (x, y) => { Console.WriteLine("x + y = " + (x + y)); };
            Action<double, double> Substraction = (x, y) => { Console.WriteLine("x - y = " + (x - y)); };
            Action<double, double> Multiplication = (x, y) => { Console.WriteLine("x * y = " + (x * y)); };
            Action<double, double> Division = (x, y) => { if (y != 0) { Console.WriteLine("x / y = " + (x / y)); } else { Console.WriteLine("Can't divide by 0"); } };

            Console.Write("Enter x: ");
            double input_x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter y: ");
            double input_y = Convert.ToDouble(Console.ReadLine());

            Addition(input_x, input_y);
            Substraction(input_x, input_y);
            Multiplication(input_x, input_y);
            Division(input_x, input_y);
        }
    }
}
