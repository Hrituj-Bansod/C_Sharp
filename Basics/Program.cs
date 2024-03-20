using System;

namespace Basics
{
    internal class Program
    {
        public void UserInput()
        {
            Console.Write("Enter you name: ");
            string UName = Console.ReadLine();
            Console.WriteLine("welcome " + UName);
        }

        public void MathsOperations()
        {
            int min = Math.Min(5, 81);
            int max = Math.Max(53, 67);
            double sqrt = Math.Sqrt(min + max);
            double absolute = Math.Abs(-12.397);
            double round = Math.Round(12.340);
            Console.WriteLine("Following are the obtained values :" + "\n" +
                "Minimum of two number is" + min + "\n" +
                "Maximum of two number is :" + max + "\n" +
                "squrate root of mix + max is:" + sqrt + "\n" +
                "absolute value is :" + absolute + "\n" +
                "Rounded values is :" + round);
        }
        public void StringProperties()
        {
            string String = "My name is Hrituj and currently i'am in mumbai";
            Console.WriteLine("String in upper case will look like :" + String.ToUpper());
            Console.WriteLine("String in lower case will look like :" + String.ToLower());
            Console.WriteLine("Length of String is :" + String.Length);
        }
        public void StringConcat()
        {
            Console.WriteLine("Two ways to concat a string are as follows : ");
            string s1 = "Hrituj ";
            string s2 = "Bansod";
            Console.WriteLine("First way is by using '+' operator : " + s1 + s2);
            Console.WriteLine("second way is by using in-built method : " + string.Concat(s1, s2));
        }

        public void StringInterpolation()
        {
            string FName = "Hrituj ";
            string LName = "Bansod";
            string FullName = $"My full name is :{FName}{LName}";
            Console.WriteLine(FullName);
            Console.WriteLine("Also String can be acessed by using index numbers as :" + FName[0]);
        }
        public void BooleanLearning()
        {
            Console.WriteLine("Boolean can be used in various ways and those are as follows : ");
            int x = 12;
            int y = 24;
            Console.WriteLine(x < y);     //return true            
            Console.WriteLine(5 > 6);  //returns false 
            Console.WriteLine("It can also be used conditional statment to get perform a task if some condition is true or false :");
            if (x <= y)
            {
                Console.WriteLine("i'am inside if loop");
            }
        }
        public void Loops()
        {
            Console.Write("Enter your age :");
            int age = Convert.ToInt32(Console.ReadLine());
            if (age < 18)
            {
                Console.WriteLine("Nope! you are NOT eligible");
            }
            else if (age == 18)
            {
                Console.WriteLine("Congats! you are eligible");
            }
            else
            {
                Console.WriteLine("YUP! you are eligble!");
            }

            Console.WriteLine("We can also perform this using short hand i else which we call as ternary operator in java:");
            String result = (age > 18) ? "you are eligible" : "You are not eligible";
            Console.WriteLine(result);
        }

        public void SwitchPract()
        {
            Console.Write("Enter a number to Know it words : ");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 0:
                    Console.WriteLine("Zero");
                    break;
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    break;
                case 3:
                    Console.WriteLine("Three");
                    break;
                case 4:
                    Console.WriteLine("Four");
                    break;
                case 5:
                    Console.WriteLine("Five");
                    break;
                case 6:
                    Console.WriteLine("Six");
                    break;
                case 7:
                    Console.WriteLine("Seven");
                    break;
                default:
                    Console.WriteLine("Default");
                    break;
            }
        }

        public void WhileTry()
        {
            int num = 5;
            while (num > 0)
            {
                Console.Write(num + " ");
                num--;
            }
        }

        public void ForExample()
        {
            Console.WriteLine("Single for loop");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i + " ");               //Using single quote insted of dpouble quote in this statment will add the
                                                          //ASCII value of space i.e. 32 to number and then will give the output. So use "Double quote     ".
            }
            Console.WriteLine("************************************************");
            Console.WriteLine("Nested for loop");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Outer loop i =" + i);
                for (int j = 0; j < 5; j++)
                {
                    Console.WriteLine("Inner loop j = " + j);
                }
            }
        }
        
        static void Main(string[] args)
        {
            Program b = new Program();
            //b.UserInput();
            //b.MathsOperations();
            //b.StringProperties();
            //b.StringConcat();
            //b.StringInterpolation();
            //b.BooleanLearning();
            //b.Loops();
            //b.SwitchPract();
            //b.WhileTry();
            //b.ForExample();
            
            
        }
    }
}
