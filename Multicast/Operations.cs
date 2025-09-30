using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operations
{
    class ExampleOperation
    {
        public delegate void OperationDelegate(int x, int y);

        public void Sum(int x, int y)
        {
            Console.WriteLine("Sum is: " + (x + y));
        }

        public void Substraction(int x, int y)
        {
            Console.WriteLine("Difference is: " + (x - y));
        }

        public void Multiplication(int x, int y)
        {
            Console.WriteLine("Product is: " + (x * y));
        }

        public void Division(int x, int y)
        {
            Console.WriteLine("Quotient is: " + (x / y));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ExampleOperation oper = new ExampleOperation();

            ExampleOperation.OperationDelegate operations = new ExampleOperation.OperationDelegate(oper.Sum);

            operations += oper.Substraction;
            operations += oper.Multiplication;
            operations += oper.Division;

            operations(10, 5);
        }
    }
}
