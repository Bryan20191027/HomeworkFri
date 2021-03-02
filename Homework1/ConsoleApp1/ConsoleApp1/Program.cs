using System;

namespace ConsoleApp1
{
    class Program
    {
        
        /*static void Main(string[] args)
        {
            int a;
            int b;
            string choice;
            Console.WriteLine("Enter the first number:");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number:");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the choice");
            choice = Console.ReadLine();
            if (choice == "+")
            {
                Console.WriteLine("The Answer is {0}",a + b);
            }
            else if (choice == "-")
            {
                Console.WriteLine("The Answer is {0}", a - b);
            }
            else if (choice == "*")
            {
                Console.WriteLine("The Answer is {0}", a * b);
            }
            else if (choice == "/")
            {
                Console.WriteLine("The Answer is {0}", a / b);
            }
            else if (choice == "%")
            {
                Console.WriteLine("The Answer is {0}", a % b);
            }
            else
                Console.WriteLine("Wrong Choice");
        }*/
        static void Main(string[] args)
        {
            int a;
            int b;
            string choice;
            Console.Write("Enter the first number,second number and the symbol:");
            string str = Console.ReadLine();
            string[] strs = str.Split(" ");
            a = int.Parse(strs[0]);
            b = int.Parse(strs[1]);
            choice = strs[2];
            if (choice == "+")
            {
                Console.WriteLine("The Answer is {0}", a + b);
            }
            else if (choice == "-")
            {
                Console.WriteLine("The Answer is {0}", a - b);
            }
            else if (choice == "*")
            {
                Console.WriteLine("The Answer is {0}", a * b);
            }
            else if (choice == "/")
            {
                Console.WriteLine("The Answer is {0}", a / b);
            }
            else if (choice == "%")
            {
                Console.WriteLine("The Answer is {0}", a % b);
            }
            else
                Console.WriteLine("Wrong Choice");
        }
    }
}
