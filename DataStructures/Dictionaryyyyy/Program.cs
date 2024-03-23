using System;
using System.Collections.Generic;

namespace Dictionaryyyyy
{
    internal class Program
    {
        public void LetsTry() 
        {
            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1, "One");
            dic.Add(2, "Two");
            dic.Add(3, "Three");
            dic.Add(4, "four");
            dic.Add(5, "Five");
            dic.Add(6, "Six");

            Dictionary <int , String> newDic = new Dictionary<int , String>();
            Console.WriteLine(newDic.ContainsKey(1));

            Console.WriteLine(newDic.Equals(dic));

            Console.WriteLine(newDic.GetEnumerator().MoveNext());

          
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.LetsTry();
        }
    }
}
