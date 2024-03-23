using System;
using System.Collections.Generic;

namespace LinkeddListttt
{
    internal class Program
    {
        public void TryingLinkedListt()
        {
            LinkedList<int> ll = new LinkedList<int>();
            LinkedListNode<int> firstone = ll.AddFirst(0);
            ll.AddAfter(firstone, 12);
            ll.AddFirst(1);
            ll.AddFirst(2);
            ll.AddFirst(3);
            LinkedListNode<int> node = ll.AddLast(4);
            ll.AddBefore(node, 12);

            foreach (int i in ll)
            {
                Console.WriteLine(i);
            }

        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.TryingLinkedListt();
        }
    }
}
