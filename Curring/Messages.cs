using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurringMessages
{
    class Program
    {
        static Func<string, Func<string, Func<string, string>>> Message = x => y => z => x + " " + y + " " + z;
        static Func<string, string> welcomeMessage = Message("Welcome")("To");
        static Func<string, Func<string, string>> helloMessage = Message("Hello");
        static Func<string, string> dayTimeMessage = Message("Have A")("Nice");

        static void Main(string[] args)
        {
            Console.Write("Enter first name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter second name: ");
            string secondName = Console.ReadLine();
            Console.Write("Enter city: ");
            string city = Console.ReadLine();
            Console.Write("Enter daytime (Day, Night, Evening, ...): ");
            string daytime = Console.ReadLine();

            Console.WriteLine(helloMessage(firstName)(secondName));
            Console.WriteLine(welcomeMessage(city));
            Console.WriteLine(dayTimeMessage(daytime));
        }
    }
}
