using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface Interface1
    {
        int id();
        string name();
    }

    public interface Interface2
    {
        int number();
        string address();
    }

    public class name : Interface1, Interface2
    {
        string Interface2.address()
        {
            return "vbnm";
        }

        int Interface1.id()
        {
            return 45;
        }

        string Interface1.name()
        {
            return "Hrituj";
        }

        int Interface2.number()
        {
            return 99757835;
        }
    }

}
