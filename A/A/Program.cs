using System;
using System.Collections.Generic;
using System.Linq;

namespace A
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            Student s2 = new Student();

            s1.Id = 45;
            s1.Name = "Hrituj";

            s2.Id = 98;
            s2.Name = "Nitesh";

            List<Student> stud = new List<Student>();
            stud.Add(s1);
            stud.Add(s2);

          var newss =  stud.Select(s => s.Name).ToList();

            foreach (var s in newss) 
            {
                Console.WriteLine(s);
            }
        }
    }
}
