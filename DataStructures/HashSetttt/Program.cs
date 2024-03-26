using System;
using System.Collections.Generic;

namespace HashSetttt
{
    internal class Program
    {
        public static void TryHashSet()
        {
            HashSet<int> hs = new HashSet<int>();

            for (int i = 0; i < 5; i++)
            {
                hs.Add(i * i);
            }

            Console.WriteLine("Acessing the HashSet :-  ");
            foreach (int i in hs)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("\nchecking if list contains 16 or not : " + hs.Contains(16));

            int[] arr = new int[5];
            hs.CopyTo(arr);
            Console.WriteLine("\nType of arr is :" + arr.GetType());

            Console.WriteLine("\nCopied to array : ");

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }

            //Console.WriteLine(hs.Equals(arr));

            HashSet<int> hs1 = new HashSet<int>() { 9 };
            hs.ExceptWith(hs1);     //deleted the elements in hs2 from hs1

            Console.WriteLine("\nFirst HashSet after using ExceptWith() and removing 9 with it :");
            foreach (var item in hs)
            {
                Console.WriteLine(item);
            }

            HashSet<int> hsnew  = new HashSet<int>() { 1,16 };

            Console.WriteLine(hsnew.IsSubsetOf(hs));
            Console.WriteLine("\n superSet :- "+hs.IsSupersetOf(hsnew));

        }

        static void Main(string[] args)
        {
            Program.TryHashSet();
        }
    }
}
