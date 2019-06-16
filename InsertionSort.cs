using System;
using System.Diagnostics;

namespace Insertion_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = establishArray(100);

            Console.WriteLine("\n\nUnsorted array: \n");
            printArray(array);

            sortArray_InsertionSort(array);

            Console.WriteLine("\n\nSorted array: \n");
            printArray(array);
        }

        private static void sortArray_InsertionSort(int[] array)
        {
            for(int i = 1; i < array.Length; i++)
            {
                int x = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > x)
                {
                    array[j + 1] = array[j];
                    j--;
                }

                array[j + 1] = x;
            }
        }

        private static void printArray(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        private static int[] establishArray(int n)
        {
            int[] array = new int[n];
            Random r = new Random();

            for(int i = 0; i < n; i++)
            {
                array[i] = r.Next(1,1000);
            }

            return array;
        }
    }
}
