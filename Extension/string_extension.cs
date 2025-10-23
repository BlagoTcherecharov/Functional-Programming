using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionString
{
    static class StringExtension
    {
        public static void SpaceToTab(this String str, String text)
        {
            StringBuilder sb = new StringBuilder(text);
            for (int i = 0; i < text.Length; i++)
            {
                if(Char.IsWhiteSpace(text[i]))
                {
                    sb[i] = '\t';
                }
            }

            for (int i = 0; i < sb.Length; i++)
                Console.Write(sb[i]);

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            String str = "This is a test!";

            str.SpaceToTab(str);
        }
    }
}
