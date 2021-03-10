using System;

namespace _2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the array:");
            string str = Console.ReadLine();
            string[] strs = str.Split(" ");
            int maxNumber = int.Parse(strs[0]);
            int minNumber = int.Parse(strs[0]);
            int sum = int.Parse(strs[0]);
            int tempNum;
            for (int i = 1; i < strs.Length; i++)
            {
                tempNum = int.Parse(strs[i]);
                if (maxNumber < tempNum)
                {
                    maxNumber = tempNum;
                }
                if (minNumber > tempNum)
                {
                    minNumber = tempNum;
                }
                sum += tempNum;
            }
            Console.WriteLine($"最大值为{maxNumber},最小值为{minNumber}");
            Console.WriteLine($"平均值为{sum / strs.Length},元素和为{sum}");
        }
    }
}
