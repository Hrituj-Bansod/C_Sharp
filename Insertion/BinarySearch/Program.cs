using System;

namespace BinarySearch
{
    internal class Program
    {

        public static int[] sorting(int[] array)
        {
            int temp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    while (array[i] < array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            foreach (var item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine("Length = "+array.Length);
            
            return array;
        }

        public static int binarySearch(int[] arr, int key)
        {
            arr = Program.sorting(arr);

            int low = 0;
            int high = arr.Length - 1;
            int mid = 0;

            while (low <= high)
            {
                mid = (low + high) / 2;

                if (key == arr[mid])
                {
                    return mid;
                }
                else if (key < arr[mid])
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            int[] a = { 12, 44, 65, 3, 88, 98, 11, 24 };


            int result = Program.binarySearch(a, 3);
            Console.WriteLine(result);
        }
    }
}
