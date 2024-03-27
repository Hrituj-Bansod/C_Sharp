using System;

namespace Bubble_Sort
{
    internal class Program
    {
        public static void bubble()             //telusko on YT
        {
            int[] arr = {4,8,2,9,7,11};
            int temp = 0;
            
            for (int i = 0; i < arr.Length; i++) 
            {
                for (int j = 0; j < arr.Length-1; j++) 
                {
                    if (arr[j] > arr[j + 1]) 
                    {
                        temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }    
            }
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }

        public static void bubbleSort()             //neter one
        {
            int[] array = { 4, 8, 2, 9, };
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
        }

        static void Main(string[] args)
        {
            //Program.bubble();
            Program.bubbleSort();
        }   
    }
}
