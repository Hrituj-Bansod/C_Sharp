using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Add
    {
        public virtual int addition(int a, int b) 
        {
            return a + b;
        }        
    }

    public class test:Add 
    {
        public override int addition(int a , int b) 
        {
            return a + b + a;
        }
    }
}
