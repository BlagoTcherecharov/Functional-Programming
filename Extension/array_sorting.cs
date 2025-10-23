using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortArray
{
    static class ArraySorting
    {
        public static void sort1(this Array arr, int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int min = array[i];
                for (int j = i; j < array.Length; j++)
                {
                    if (array[j] < min)
                    {
                        int temp = min;
                        min = array[j];
                        array[j] = temp;
                    }
                }
                Console.Write(min + " ");
            }
            Console.WriteLine();
        }

        public static void sort2(this Array arr, int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            foreach (int a in array)
                Console.Write(a + " ");

            Console.WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { 1, 4, 6, 2, 3, 7 };
            int[] arr2 = new int[] { 1, 4, 6, 2, 3, 7 };

            arr1.sort1(arr1);
            arr2.sort2(arr2);
        }
    }
}
