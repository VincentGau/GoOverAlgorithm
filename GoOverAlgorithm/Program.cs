using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoOverAlgorithm
{
    class Program
    {
        static int[] board = new int[8] { 0, 0, 0, 0, 0, 0, 0, 0 };
        static int count = 0;
        static void Main(string[] args)
        {

            //printResult(new int[] { 0, 1, 2, 3, 4, 5, 6, 7 });
            
            // 从第一行开始尝试放置皇后
            placeQueen(0);
            Console.WriteLine(count);
        }


        private static void placeQueen(int n)
        {
            if (n.Equals(8))
                return;

            for (int i = 0; i < 8; i++)
            {
                board[n] = i;

                if (checkConflict(n))
                {
                    if(n == 7)
                    {
                        printResult(board);
                        count++;
                    }
                    else
                    {
                        placeQueen(n + 1);
                    }
                }
            }
        }

        // 检查放置该皇后后是否产生冲突
        private static bool checkConflict(int n)
        {
            for(int i = 0; i < n; i++)
            {
                if (board[i] == board[n] || Math.Abs(board[i] - board[n]) == Math.Abs(i - n))
                    return false;
            }
            return true;
        }


        // 输出八皇后棋盘
        private static void printResult(int[] input)
        {
            int[,] result = new int[8, 8];
            for (int i = 0; i < 8; i++)
                for (int j = 0; j < 8; j++)
                    result[i, j] = 0;

            int col = 0;
            for(int i = 0; i < input.Length; i++)
            {
                result[col++, input[i]] =  1;
            }

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                    Console.Write(result[i, j]);
                Console.WriteLine();
            }

            Console.WriteLine();
                
        }
    }
}
