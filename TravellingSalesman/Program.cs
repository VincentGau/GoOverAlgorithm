using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravellingSalesman
{
    class Program
    {
        static int[,] m = { { 0, 10, 15, 20 }, { 5, 0, 9, 10 }, { 6, 13, 0, 12 }, { 8, 8, 9, 0 } };

        // 二维表
        //2^(n-1) = 8
        static int[,] pt = new int[4, 8];
        static void Main(string[] args)
        {
            // 第一列
            for (int i = 0; i < 4; i++)
            {
                pt[i, 0] = m[i, 0];
            }

            for (int j = 1; j < 8; j++)
            {
                for(int i = 0; i < 4; i++)
                {
                    pt[i, j] = 0;
                    if (((j >> i) & 1) == 1)
                    {
                        continue;
                    }
                    for(int k = 1; k <4; k++)
                    {
                        if ()
                        {
                            pt[i, j] = 0;
                        }
                    }

                }
                
            }



            for(int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write("{0} - ", pt[i, j]);
                }
                Console.WriteLine();
            }
                
                    
        }
    }
}
