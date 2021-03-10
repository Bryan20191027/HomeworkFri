using System;

namespace _2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[101];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 1;
            }
            int sum = 0;
            for (int i = 2; i <= Math.Sqrt(array.Length); i++)
            {
                for (int j = 2; j < array.Length; j++)
                {
                    if (array[j] == 1)
                        if (j != i && j % i == 0)
                        {
                            array[j] = 0;
                        }
                }
            }
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == 1)
                    sum++;
            }
            int[] arrayNew = new int[sum];
            int top = 0;
            for (int i = 2; i < array.Length; i++)
            {
                if (array[i] == 1)
                    arrayNew[top++] = i;
            }
            for (int i = 0; i < sum; i++)
            {
                Console.WriteLine(arrayNew[i]);
            }
        }
    }
}