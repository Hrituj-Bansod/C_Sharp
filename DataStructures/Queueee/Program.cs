﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace Queueee
{
    internal class Program
    {
        public void UseQueue() 
        {
            Queue queue = new Queue();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            Console.WriteLine("Acessing the queue : ");
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("Number of Elements presemt in queue :" + queue.Count);

           Queue cloned = new Queue(queue);
            cloned.Enqueue(88);
            cloned.Enqueue(0);

            Console.WriteLine("\nCloned queue is :");
            foreach (var item in cloned)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n Checking equals method : "+cloned.Equals(queue));
            Object [] obj = queue.ToArray();
            foreach (var item in obj) 
            {
                Console.Write($"[{item}]");
            }
            // s = cloned.ToString();
            // Console.WriteLine("\n"+s.ToString());            // printing adress
            Console.WriteLine("\n"+cloned.ToString());          //printng adress insted of string


        }
        static void Main(string[] args)
        {
            Program p= new Program();
            p.UseQueue();
        }
    }
}
