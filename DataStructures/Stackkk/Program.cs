using System;
using System.Collections.Generic;

namespace Stackkk
{
    internal class Program
    {
        public void StackTrying() 
        {
            Stack <int>stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            Console.WriteLine("Iterating through out stack :");
            foreach (var item in stack)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("count of elements in our staqack is :"+stack.Count);
            Console.WriteLine("The top most element of our stack is :"+stack.Peek());

            Stack<int> cloned =  new Stack<int> (stack);
            Console.WriteLine("The cloned stack is : ");
            cloned.Pop();
            foreach (var item in cloned) 
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("checking if the stack contains a object or not using contained method: "+stack.Contains(3));
            Console.WriteLine( "Passing a object in contains method that does not exist :"+stack.Contains(8) );
            Console.WriteLine();
            Console.WriteLine("Equals method "+stack.Equals(cloned)); // here the stack.Equal() will behave differently than it will behave in stack without generics
                                                                      //when we pass generics it will check not only value but also if the elements in both stacks are at same location in memeory or not
                                                                      //in stack without generics it will check if current object is equals to object in other stack
            Console.WriteLine("checking GetType() method :"+stack.GetType());

            Console.WriteLine("\n using Tosstring is tricky : ");
            string stingedStack = String.Join(" ," , stack);                //here we have to use Join method of String and passing " , " will seperate them with comma while printing and
                                                                            //stack is passed to tell on which stack it is to be perfomed
            Console.WriteLine("String stacked is :"+stingedStack);

            Console.WriteLine("\n lets try converting it to a array :");
           int[] arr = stack.ToArray();
            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }

        static void Main(string[] args)
        {
           Program p = new Program();
            p.StackTrying();
        }
    }
}
