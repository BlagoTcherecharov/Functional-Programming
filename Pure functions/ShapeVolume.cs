using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeVolume
{
    class Shapes
    {
        internal static Func<double, double> CubeVolume = x => x * x * x;
        internal static Func<double, double, double, double> CuboidVolume = (x, y, z) => x * y * z;
        internal static Func<double, double, double, double> TriangularPrismVolume = (x, y, z) => (x + y) / 2 * z;
        internal static Func<double, double, double, double, double> TrapezoidalPrismVolume = (x, y, z, h) => ((x + y) / 2 * z) * h;
        internal static Func<double, double, double, double> TriangularPyramidVolume = (x, y, z) => x * y / 2 * z / 3;
        internal static Func<double, double, double, double> RectangularPyramidVolume = (x, y, z) => x * y * z / 3;
        internal static Func<double, double, double, double> ParallelogramPyramidVolume = (x, y, z) => x * y * z / 3;
        internal static Func<double, double, double, double> RhombusPyramidVolume = (x, y, z) => x * y / 2 * z / 3;
        internal static Func<double, double, double, double, double> TrapezoidalPyramidVolume = (x, y, z, h) => ((x + y) / 2 * z) * h / 3;
        internal static Func<double, double, double> CylinderVolume = (x, y) => x * x * y * Math.PI;
        internal static Func<double, double, double> ConeVolume = (x, y) => x * x * y * Math.PI / 3;

        public double ReturnVolume(double a, Func<double, double> areaFunc)
        {
            return areaFunc(a);
        }

        public double ReturnVolume(double a, double b, Func<double, double, double> areaFunc)
        {
            return areaFunc(a, b);
        }

        public double ReturnVolume(double a, double b, double c, Func<double, double, double, double> areaFunc)
        {
            return areaFunc(a, b, c);
        }

        public double ReturnVolume(double a, double b, double c, double d, Func<double, double, double, double, double> areaFunc)
        {
            return areaFunc(a, b, c, d);
        }
    }

    class Program
    {
        static double a, b, c, d;

        static void OneParam()
        {
            Console.Write("Enter a: ");
            a = Convert.ToDouble(Console.ReadLine());
        }

        static void TwoParam()
        {
            OneParam();
            Console.Write("Enter b: ");
            b = Convert.ToDouble(Console.ReadLine());
        }

        static void ThreeParam()
        {
            TwoParam();
            Console.Write("Enter c: ");
            c = Convert.ToDouble(Console.ReadLine());
        }

        static void FourParam()
        {
            ThreeParam();
            Console.Write("Enter d: ");
            d = Convert.ToDouble(Console.ReadLine());
        }


        static void Main(string[] args)
        {
            Shapes shape = new Shapes();

            Console.WriteLine("Pick figure:");
            Console.WriteLine("1. Cube");
            Console.WriteLine("2. Cuboid");
            Console.WriteLine("3. Triangular Prism");
            Console.WriteLine("4. Trapezoidal Prism");
            Console.WriteLine("5. Triangular Pyramid");
            Console.WriteLine("6. Rectangular Pyramid");
            Console.WriteLine("7. Parallelogram Pyramid");
            Console.WriteLine("8. Rhombus Pyramid");
            Console.WriteLine("9. Trapezoidal Pyramid");
            Console.WriteLine("10. Cylinder");
            Console.WriteLine("11. Cone");

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    OneParam();
                    Console.WriteLine("Cube's volume is " + shape.ReturnVolume(a, Shapes.CubeVolume));
                    break;
                case 2:
                    ThreeParam();
                    Console.WriteLine("Cuboid's volume is " + shape.ReturnVolume(a, b, c, Shapes.CuboidVolume));
                    break;
                case 3:
                    ThreeParam();
                    Console.WriteLine("Triangular prism's volume is " + shape.ReturnVolume(a, b, c, Shapes.TriangularPrismVolume));
                    break;
                case 4:
                    FourParam();
                    Console.WriteLine("Trapezoidal prism's volume is " + shape.ReturnVolume(a, b, c, d, Shapes.TrapezoidalPrismVolume));
                    break;
                case 5:
                    ThreeParam();
                    Console.WriteLine("Triangular pyramid's volume is " + shape.ReturnVolume(a, b, c, Shapes.TriangularPyramidVolume));
                    break;
                case 6:
                    ThreeParam();
                    Console.WriteLine("Rectangular pyramid's volume is " + shape.ReturnVolume(a, b, c, Shapes.RectangularPyramidVolume));
                    break;
                case 7:
                    ThreeParam();
                    Console.WriteLine("Parallelogram pyramid's volume is " + shape.ReturnVolume(a, b, c, Shapes.ParallelogramPyramidVolume));
                    break;
                case 8:
                    ThreeParam();
                    Console.WriteLine("Rhombus pyramid's volume is " + shape.ReturnVolume(a, b, c, Shapes.RhombusPyramidVolume));
                    break;
                case 9:
                    FourParam();
                    Console.WriteLine("Trapezoidal pyramid's volume is " + shape.ReturnVolume(a, b, c, d, Shapes.TrapezoidalPyramidVolume));
                    break;
                case 10:
                    TwoParam();
                    Console.WriteLine("Cylinder's volume is " + shape.ReturnVolume(a, b, Shapes.CylinderVolume));
                    break;
                case 11:
                    TwoParam();
                    Console.WriteLine("Cone's volume is " + shape.ReturnVolume(a, b, Shapes.ConeVolume));
                    break;
                default:
                    break;
            }
        }
    }
}
