using System;

namespace SelectionSort
{
    internal class Program
    {
        public static void SelectionSort()              //Coding with john on yt + openAI
        {
            int[] arr = { 8, 3, 6, 12, 9, 1 };

            for (int i = 0; i < arr.Length - 1; i++)
            {
                int min = arr[i];
                int indexOfMin = i;

                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < min)
                    {
                        min = arr[j];
                        indexOfMin = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[indexOfMin];
                arr[indexOfMin] = temp;
            }

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

        }
        static void Main(string[] args)
        {
            Program.SelectionSort();
        }
    }
}
