using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordLength
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> words = new List<string> { "dwadf", "", "sadgsdvearefsd", "adwiuunh", "dwaiuuidwa", "" };

            Predicate<string> notEmpty = s => { return string.IsNullOrEmpty(s); };

            Predicate<string> overTenSymbols = s => { return s.Length > 10; };

            foreach (string word in words)
            {
                if (!notEmpty(word) && !overTenSymbols(word))
                    Console.WriteLine(word);
            }
        }
    }
}
