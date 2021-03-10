using System;

namespace _2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime beforDT = System.DateTime.Now;
            //int number = int.Parse(Console.ReadLine());
            int number = (int)Math.Pow(2,13)-1;
            
            /*for(int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    if (isPrime(i))
                    {
                        //number = number / i;
                        Console.WriteLine(i);
                    }
            }*/
            bool flag = true;
            int i = 2;
            while (!isPrime(number))
            {
                if (number % i == 0 && isPrime(i))
                {
                    if (flag)
                    {
                        flag = false;
                        Console.WriteLine(i);
                    }
                    number = number / i;
                }
                else
                {
                    flag = true;
                    i++;
                }
            }
            Console.WriteLine(number);
            DateTime afterDT = System.DateTime.Now;
            TimeSpan ts = afterDT.Subtract(beforDT);
            Console.WriteLine("DateTime总共花费{0}ms.", ts.TotalMilliseconds);
        }

        static bool isPrime(int n)
        {
            if (n == 2)
            {
                return true;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                        return false;
                }
                return true;
            }
        }
    }
}
