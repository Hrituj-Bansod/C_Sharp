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
            int[] newList = arr.Where(num => num > 70).ToArray();

            foreach (var item in newList)
            {
                Console.Write(item + " ");
            }
        }

        public void letsSee() 
        {
            
        }


        //static void Main(string[] args)
        //{
        //    Program pp = new Program();
        //    pp.LamdaTry();
        //}
    }
}
