using System;
using System.Diagnostics;

namespace Selection_Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = establishArray(100);

            Console.WriteLine("\n\nUnsorted array: \n");

            printArray(array);
            sortArray_SelectionSort(array);

            Console.WriteLine("\n\nSorted array: \n");
            printArray(array);
        }

        private static void sortArray_SelectionSort(int[] array)
        {
            for(int i = 0; i < array.Length; i++)
            {
                int min_index = i;

                for(int k = i + 1; k < array.Length; k++)
                {
                    if(array[k] < array[min_index])
                    {
                        min_index = k;
                    }

                    int temp = array[min_index];
                    array[min_index] = array[i];
                    array[i] = temp;
                }
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
                array[i] = r.Next(1, 1000);  
            }

            return array;
        }
    }
}
