using System;

namespace Exercise_4
{
    class Program{
        static void Main(string[] args){
            Console.Write("Enter the number of row and column:");
            string str = Console.ReadLine();
            string[] strs = str.Split(' ');
            Console.WriteLine("Enter the matrix:");
            int row = int.Parse(strs[0]);
            int col = int.Parse(strs[1]);
            int[,] matrixNew = new int[row, col];
            for (int i = 0; i < row; i++){
                string num = Console.ReadLine();
                string[] nums = num.Split(' ');
                for (int j = 0; j < col; j++){
                    matrixNew[i, j] = int.Parse(nums[j]);
                }
            }
            if (isToeplitz(row, col, matrixNew)) 
               Console.WriteLine("It is a Toeplitz matrix");
            else
               Console.WriteLine("It is not a Toeplitz matrix");
        }
        static bool isToeplitz(int row, int col, int[,] matrix){
            bool flag = true;
            if (row == 0 || col == 0)
                flag = false;
            if(flag)
                for (int i = 0; i < row - 1; i++){
                    for (int j = 0; j < col - 1; j++){
                        if (matrix[i, j] != matrix[i + 1, j + 1])
                        {
                            flag = false;
                            break;
                        }
                    }
                    if (!flag)
                        break;
                }
            return flag;
        }
    }
}
