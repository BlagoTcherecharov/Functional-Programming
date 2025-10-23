using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionArray
{
    static class ArrayExtension
    {
        public static void PrintArray(this Array arr)
        {
            foreach(int a in arr)
            {
                Console.Write(a + " ");
            }
            Console.WriteLine();
        }

        public static void ReverseArray(this Array arr, int[] array)
        {
            for(int i = array.Length - 1; i >= 0; i--)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 1, 4, 6, 2, 3, 7 };

            arr.PrintArray();

            arr.ReverseArray(arr);
        }
    }
}
