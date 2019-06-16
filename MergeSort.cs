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

            sortArray_MergeSort(array, 0, array.Length - 1);

            Console.WriteLine("\n\nSorted array: \n");
            printArray(array);
        }
        private static void printArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
        }

        private static int[] establishArray(int n)
        {
            int[] array = new int[n];
            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                array[i] = r.Next(1, 100);
            }

            return array;
        }

        public static int[] sortArray_MergeSort(int[] input, int left, int right)
        {
            int[] result = new int[0];

            if (left < right)
            {
                int middle = (left + right) / 2;

                sortArray_MergeSort(input, left, middle);
                sortArray_MergeSort(input, middle + 1, right);

                result = Merge(input, left, middle, right);
            }

            return result;

        }

        private static int[] Merge(int[] input, int left, int middle, int right)
        {
            int[] leftArray = new int[middle - left + 1];
            int[] rightArray = new int[right - middle];

            Array.Copy(input, left, leftArray, 0, middle - left + 1);
            Array.Copy(input, middle + 1, rightArray, 0, right - middle);

            int i = 0;
            int j = 0;

            for (int k = left; k < right + 1; k++)
            {
                if (i == leftArray.Length)
                {
                    input[k] = rightArray[j];
                    j++;
                }
                else if (j == rightArray.Length)
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else if (leftArray[i] <= rightArray[j])
                {
                    input[k] = leftArray[i];
                    i++;
                }
                else
                {
                    input[k] = rightArray[j];
                    j++;
                }
            }

            return input;
        }
    }
}

