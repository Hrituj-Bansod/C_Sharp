using System;
using System.Collections;

namespace HashTableeee
{
    internal class Program
    {
        public void Hashtableeee() 
        {
            Hashtable hst = new Hashtable();
            hst.Add(1 , "Hrituj");
            hst.Add(2 , "bansod");
            hst.Add(3 , "Mumbai");
            hst.Add(4 , "Bridgelabzz");

          ICollection v=  hst.Keys;

            foreach (var item in v)
            {
                Console.WriteLine("Item = "+item+" value = "+ hst[item]);
            }

            Console.WriteLine("Counting elements : " + hst.Count);

            Hashtable hst2 = new Hashtable(hst);
            Console.WriteLine( hst2.Equals(hst));

            Console.WriteLine(hst.IsSynchronized);
            Console.WriteLine(hst.IsFixedSize);
            Console.WriteLine(hst.IsReadOnly);





        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Hashtableeee();   
            
        }
    }
}
