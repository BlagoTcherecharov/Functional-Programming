using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculation
{
    class Program
    {
        static void Main(string[] args)
        {
            Action <int> areaSquare = x => { Console.WriteLine("Area Square = " + (x * x)); };
            Action <int, int> areaRectangle = (x, y) => { Console.WriteLine("Area Rectangle = " + (x * y)); };
            Action <int> areaCircle = x => { Console.WriteLine("Area Circle = " + (Math.PI * x * x)); };
            Action <int, int> areaRhombus = (x, y) => { Console.WriteLine("Area Rhombus = " + (x * y / 2)); };
            Action <int, int> areaParallelogram = (x, y) => { Console.WriteLine("Area Parallelogram = " + (x * y)); };

            Console.Write("Enter x: ");
            int input_x = int.Parse(Console.ReadLine());
            Console.Write("Enter y: ");
            int input_y = int.Parse(Console.ReadLine());

            areaSquare(input_x);
            areaRectangle(input_x, input_y);
            areaCircle(input_x);
            areaRhombus(input_x, input_y);
            areaParallelogram(input_x, input_y);
        }
    }
}
