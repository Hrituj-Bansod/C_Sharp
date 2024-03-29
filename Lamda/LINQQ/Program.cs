using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQQ
{
    internal class Program
    {
        public void LamdaTry()
        {
            int[] arr = { 89, 56, 34, 67, 34, 98 };
            //int[] newList = arr.Where(num => num > 70).ToArray();
            int[] newList = arr.OrderBy(x => x).ToArray();

            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
        }
        static void Main(string[] args)
        {
            Program pp = new Program();
            pp.LamdaTry();
        }

    }
}

