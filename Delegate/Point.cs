using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatePoint
{
    class Point
    {
        private int x, y;
        private int x_translation, y_translation;
        private int scale_x, scale_y;
        private int angle;
        private double x_rotate, y_rotate;

        public delegate void translation();
        public delegate void rotation();
        public delegate void scaling();
        

        public Point()
        {
            x = y = 0;
            x_translation = y_translation = 0;
            scale_x = scale_y = 0;
            angle = 0;
            x_rotate = y_rotate = 0;
        }

        public void Translation()
        {
            Console.Write("Enter translation for x: ");
            x_translation = int.Parse(Console.ReadLine());
            Console.Write("Enter translation for y: ");
            y_translation = int.Parse(Console.ReadLine());

            x_translation += x;
            y_translation += y;

            Console.WriteLine("Point after translation: (" + x_translation + ", " + y_translation + ")");
        }

        public void Rotation()
        {
            Console.Write("Enter angle: ");
            angle = int.Parse(Console.ReadLine());

            x_rotate = x * Math.Cos(angle) - y * Math.Sin(angle);
            y_rotate = x * Math.Sin(angle) + y * Math.Cos(angle);

            Console.WriteLine("Point after rotation: (" + x_rotate + ", " + y_rotate + ")");
        }

        public void Scaling()
        {
            Console.Write("Enter scale factor for x: ");
            scale_x = int.Parse(Console.ReadLine());
            Console.Write("Enter scale factor for y: ");
            scale_y = int.Parse(Console.ReadLine());

            scale_x *= x;
            scale_y *= y;

            Console.WriteLine("Point after scale: (" + scale_x + "," + scale_y + ")");
        }

        public void Input()
        {
            Console.Write("Enter value for x: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Enter value for y: ");
            y = int.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("x = " + x);
            Console.WriteLine("y = " + y);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();
            point.Input();

            Point.translation translate = new Point.translation(point.Translation);
            Point.rotation rotate = new Point.rotation(point.Rotation);
            Point.scaling scale = new Point.scaling(point.Scaling);

            translate();
            rotate();
            scale();

            point.Output();
        }
    }
}
