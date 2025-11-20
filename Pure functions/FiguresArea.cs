using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea
{
    class Figures
    {
        internal static Func<double, double> SquareArea = x => x * x;
        internal static Func<double, double, double> RectangleArea = (x, y) => x * y;
        internal static Func<double, double, double> RhombusArea = (x, y) => x * y / 2;
        internal static Func<double, double, double> ParallelogramArea = (x, y) => x * y;
        internal static Func<double, double, double, double> TrapezoidArea = (x, y, z) => (x + y) / 2 * z;
        internal static Func<double, double> CircleArea = x => x * x * Math.PI;
        internal static Func<double, double, double> OvalArea = (x, y) => x * y * Math.PI;

        public double ReturnArea(double a, Func<double, double> areaFunc)
        {
            return areaFunc(a);
        }

        public double ReturnArea(double a, double b, Func<double, double, double> areaFunc)
        {
            return areaFunc(a, b);
        }

        public double ReturnArea(double a, double b, double c, Func<double, double, double, double> areaFunc)
        {
            return areaFunc(a, b, c);
        }
    }

    class Program
    {
        static double x, y, z;

        static void OneParam()
        {
            Console.Write("Enter x: ");
            x = Convert.ToDouble(Console.ReadLine());
        }

        static void TwoParam()
        {
            OneParam();
            Console.Write("Enter y: ");
            y = Convert.ToDouble(Console.ReadLine());
        }

        static void ThreeParam()
        {
            TwoParam();
            Console.Write("Enter z: ");
            z = Convert.ToDouble(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Figures fig = new Figures();

            Console.WriteLine("Pick figure:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Rhombus");
            Console.WriteLine("4. Parallelogram");
            Console.WriteLine("5. Trapezoid");
            Console.WriteLine("6. Circle");
            Console.WriteLine("7. Oval");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());


            switch(choice)
            {
                case 1:
                    OneParam();
                    Console.WriteLine("Square's area is " + fig.ReturnArea(x, Figures.SquareArea));
                    break;
                case 2:
                    TwoParam();
                    Console.WriteLine("Rectangle's area is " + fig.ReturnArea(x, y, Figures.RectangleArea));
                    break;
                case 3:
                    TwoParam();
                    Console.WriteLine("Rhombus's area is " + fig.ReturnArea(x, y, Figures.RhombusArea));
                    break;
                case 4:
                    TwoParam();
                    Console.WriteLine("Parallelogram's area is " + fig.ReturnArea(x, y, Figures.ParallelogramArea));
                    break;
                case 5:
                    ThreeParam();
                    Console.WriteLine("Trapezoid's area is " + fig.ReturnArea(x, y, z, Figures.TrapezoidArea));
                    break;
                case 6:
                    OneParam();
                    Console.WriteLine("Circle's area is " + fig.ReturnArea(x, Figures.CircleArea));
                    break;
                case 7:
                    TwoParam();
                    Console.WriteLine("Oval's area is " + fig.ReturnArea(x, y, Figures.OvalArea));
                    break;
                default:
                    break;
            }
        }
    }
}
