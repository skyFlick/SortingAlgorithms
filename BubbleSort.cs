using System;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = establishArray(100);

            Console.WriteLine("\n\nUnsorted array: \n");

            printArray(array);
            sortArray_BubbleSort(array);

            Console.WriteLine("\n\nSorted array: \n");

            printArray(array);
        }

        private static void sortArray_BubbleSort(int[] array)
        {
            for(int i = 0; i < array.Length - 1; i++)
            {
                for(int j = i+1; j < array.Length; j++)
                {
                    if(array[i] > array[j])  
                    {
                        int temp = array[j];
                        array[j] = array[i];
                        array[i] = temp;
                    }
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

            for(int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(1, 1000);
            }

            return array;
        }
    }
}
