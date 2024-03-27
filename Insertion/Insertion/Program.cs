using System;

namespace Insertion
{
    internal class Program
    {
        public static void insert()                        //TELUSKO video on YT
        {
            int[] arr = { 8, 4, 6, 2, 9, 1 };
            for (int i = 1; i < arr.Length; i++) 
            {
                int j = i - 1;
                int key = arr[i];

                while (j >= 0 && arr[j] > key) 
                {
                    arr[j+1] = arr[j];
                    j--;
                }
                arr[j+1] = key;
            }

            foreach (var item in arr)
            {
                Console.Write(item+" ");
            }

        }
        static void Main(string[] args)
        {
        Program.insert();
        }
    }
}
