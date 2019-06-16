using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = establishArray(100);

            Console.WriteLine("\n\nUnsorted array: \n");
            printArray(array);

            sortArray_QuickSort(array,0,array.Length-1);

            Console.WriteLine("\n\nSorted array: \n");
            printArray(array);
        }

        private static int[] sortArray_QuickSort(int[] array, int left, int right)
        {
            int i = left;
            int j = right;

            var pivot = array[(left + right) / 2];

            while(i <= j)
            {
                while (array[i] < pivot)
                    i++;

                while (array[j] > pivot)
                    j--;

                if(i <= j)
                {
                    var temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;

                    i++;
                    j--;
                }
            }

            if (left < j)
                sortArray_QuickSort(array, left, j);

            if (i < right)
                sortArray_QuickSort(array, i, right);

            return array;
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
                array[i] = r.Next(1, 100);
            }

            return array;
        }
    }
}
