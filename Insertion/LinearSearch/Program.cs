using System;

namespace LinearSearch
{
    internal class Program
    {
        public static int Linear() 
        {
            int[] arr = { 12, 66, 75, 79, 22, 1 };

            int key = 75;

            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == key) 
                {
                    return i;
                }
            }
            return -1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Program.Linear());
        }
    }
}
