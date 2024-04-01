using System;

namespace ConsoleApp1
{
    public class Employee
    {
        int id;
        string name;
        float slary;

        public  Employee(int i , string name , float salary) 
        {
            this.id = i;
            this.name = name;
            this.slary = salary;
        }
        public void display()
        {
            Console.WriteLine(id+" "+name+" "+slary);
        }
        static void Main(string[] args)
        {
            Employee e1 = new Employee(1, "hrituj" , 5000f);
            Employee e2 = new Employee(12, "Bansod" , 90000000f);

            e1.display();
            e2.display();

            Interface1 aa = new name();
            Console.WriteLine("\n"+ aa.id());
            Console.WriteLine("\n" + aa.name());
            
            Interface2 ab= new name();
            Console.WriteLine("\n"+ab.address());
            Console.WriteLine("\n" + ab.number());

        }
    }
}
